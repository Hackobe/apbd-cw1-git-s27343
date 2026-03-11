1\. Kiedy Git wykonuje fast-forward merge, a kiedy powstaje merge commit?



Fast-forward merge następuje wtedy, gdy gałąź docelowa nie zawiera nowych commitów od momentu utworzenia drugiej gałęzi. W takim przypadku Git tylko przesuwa wskaźnik gałęzi do najnowszego commita.



Merge commit powstaje wtedy, gdy obie gałęzie mają własne nowe commity i ich historia się rozeszła. Git musi wtedy utworzyć dodatkowy commit scalający historię obu gałęzi.



2\. Czym w praktyce różni się merge od rebase?



Merge łączy historię dwóch gałęzi poprzez utworzenie merge commita i zachowuje pełną historię rozgałęzień.



Rebase przepisuje historię commitów tak, aby wyglądało jakby zmiany zostały wykonane bezpośrednio na najnowszej wersji gałęzi docelowej. Dzięki temu historia projektu jest bardziej liniowa.



3\. Jak został rozwiązany konflikt w repozytorium?



Konflikt powstał w wyniku modyfikacji tego samego fragmentu kodu w dwóch różnych gałęziach. Git oznaczył konflikt w pliku przy użyciu znaczników konfliktu.



Konflikt został rozwiązany ręcznie poprzez wybranie odpowiedniej wersji kodu oraz usunięcie znaczników konfliktu, a następnie zapisanie pliku i wykonanie commita kończącego proces scalania.

