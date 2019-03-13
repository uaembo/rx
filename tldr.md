# Rx TL;DR"

[**Readme**](./readme.md) 

* Rx = Observables + LinQ + Scheduler mit  ```IObservable<T>``` <=> ```IObserver<T>``` (und ```Subject<T>``` )
* LinQ : 100+ Operationen auf "Streams". [Überblick Operatoren](http://reactivex.io/documentation/operators.html)
* Scheduler API : Nebenläufigkeit steuern
    * UIThread Events vs Background Worker
    * ObserveOn = "ab da bitte im angegebenen execution context weiter verarbeiten"
    * (selten) SubscribeOn = die ganze Observable selber soll auf dem angegebenen execution context laufen
    * für unit testing: TestScheduler
* Errorhandling innerhalb der Pipeline möglich

* Cold Observable = Observable wird beim subscriben aktiviert
* Hot Observable = Observable "läuft" bereits. Beim späteren Subscriben fehlen "Events" 
