from django.contrib import admin
from django.urls import path,include
from . import views

app_name="App_Login"

urlpatterns = [
    path('signup/',views.sign_up,name="signup"),
    path('login/',views.login_page,name="login"),
    path('logout/',views.logout_user,name="logout"),
    path('profile/',views.profile,name="profile"),
    path('change-profile',views.user_change,name="user_change"),
    path('password/',views.pass_Change,name="pass_change")
]

