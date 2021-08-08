from django.shortcuts import render,HttpResponseRedirect
from django.views.generic import CreateView,UpdateView,ListView,DetailView,TemplateView,View,DeleteView
from .models import Blog,Comment,Like
from django.urls import reverse,reverse_lazy
import uuid
from .forms import CommentForm

## function based view
from django.contrib.auth.decorators import login_required

## class base view
from django.contrib.auth.mixins import LoginRequiredMixin



class CreateBlog(LoginRequiredMixin,CreateView):
    model = Blog 
    template_name="App_Blog/create_blog.html"
    fields = ('blog_title','blog_content','blog_image')

    def form_valid(self,form):
        blog_obj = form.save(commit=False)
        blog_obj.author = self.request.user
        title = blog_obj.blog_title
        blog_obj.slug = title.replace(" ","-")+ "-" + str(uuid.uuid4())
        blog_obj.save()
        return HttpResponseRedirect(reverse("index"))



class BlogList(ListView):
    context_object_name="blogs"
    model = Blog
    template_name="App_Blog/blog_list.html"

@login_required
def blog_details(request,slug):
    blog = Blog.objects.get(slug=slug)
    commentform = CommentForm()
    already_liked = Like.objects.filter(blog=blog,user=request.user)
    if already_liked:
        liked=True 
    else:
        liked=False

    if request.method == "POST":
        commentform = CommentForm(request.POST)
        if commentform.is_valid():
            comment = commentform.save(commit=False)
            comment.user = request.user
            comment.blog = blog
            comment.save()
            return HttpResponseRedirect(reverse("App_Blog:blog_details",kwargs={'slug':slug}))
    return render(request,"App_Blog/blog_details.html",context={"blog":blog,'form':commentform,'liked':liked})


@login_required
def liked(request,pk):
    blog = Blog.objects.get(pk=pk)
    user = request.user
    already_liked = Like.objects.filter(blog=blog,user=user)
    if not already_liked:
        liked_post = Like(blog=blog,user=user)
        liked_post.save()
    return HttpResponseRedirect(reverse("App_Blog:blog_details",kwargs={'slug':blog.slug}))


@login_required
def unliked(request,pk):
    blog = Blog.objects.get(pk=pk)
    user = request.user
    already_liked = Like.objects.filter(blog=blog,user=user)
    if  already_liked:
        already_liked.delete()
    return HttpResponseRedirect(reverse("App_Blog:blog_details",kwargs={'slug':blog.slug}))

class MyBlogs(LoginRequiredMixin,TemplateView):
    template_name = "App_Blog/my_blogs.html"

class UpdateBlog(LoginRequiredMixin,UpdateView):
    model = Blog
    fields=['blog_title','blog_content','blog_image']
    template_name = "App_BLOG/edit_blog.html"

    # on success
    def get_success_url(self,**kwargs):
        return reverse_lazy("App_Blog:blog_details",kwargs={"slug":self.object.slug})