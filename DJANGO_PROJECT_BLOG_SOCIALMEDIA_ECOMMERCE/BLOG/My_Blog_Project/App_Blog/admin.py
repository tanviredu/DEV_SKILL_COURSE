from django.contrib import admin
from .models import Blog,Comment,Like

admin.site.register(Blog)
admin.site.register(Comment)
admin.site.register(Like)