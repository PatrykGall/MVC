from django.urls import path
from . import views

urlpatterns = [
    # Adres: /polls/
    path('', views.index, name='index'),
    # Adres: /polls/5/
    path('<int:question_id>/', views.detail, name='detail'),
]