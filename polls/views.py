from django.http import HttpResponse

def index(request):
    return HttpResponse("Ankieta działa! Null bytes i błędy importu pokonane.")

def detail(request, question_id):
    return HttpResponse(f"Spoglądasz na pytanie numer {question_id}.")