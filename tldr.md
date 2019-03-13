# Rx TL;DR"

[**Readme**](./readme.md) 

* Rx = Observables + LinQ + Scheduler mit  ```IObservable<T>``` <=> ```IObserver<T>``` (und ```Subject<T>``` )
* LinQ : 100+ Operationen auf "Streams". [�berblick Operatoren](http://reactivex.io/documentation/operators.html)
* Scheduler API : Nebenl�ufigkeit steuern
    * UIThread Events vs Background Worker
    * ObserveOn = "ab da bitte im angegebenen execution context weiter verarbeiten"
    * (selten) SubscribeOn = die ganze Observable selber soll auf dem angegebenen execution context laufen
    * f�r unit testing: TestScheduler
* Errorhandling innerhalb der Pipeline m�glich

* Cold Observable = Observable wird beim subscriben aktiviert
* Hot Observable = Observable "l�uft" bereits. Beim sp�teren Subscriben fehlen "Events" 
