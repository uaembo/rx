# Reactive Extensions (Rx) 

## TL;DR 
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

* **Pitfall**: Hot vs Cold Observable : verpass ich events oder nicht? ist die Aktivierung der Observable teuer?
* **Pitfall**: Backpressure: Fliesst mehr in die Pipe herein als heraus?
* **Pitfall**: innerhalb der "Pipeline" auf unsynchronisierte Ressource zugreifen (stateful vs stateless data streaming)

## Kapitel

* [Einf�hrung](./einfuehrung.md) 
* [Observable](./observables.md) + Observer
* [Operationen](./operations.md) auf "Events" 
* [Errorhandling](./errorhandling.md) 
* [Scheduler](./scheduler.md) 
* Challenges (inkl. [Pitfalls](./pitfalls.md) )

## Unterlagen:

[Reactive Documentation ](http://reactivex.io/)

[Microsoft Reactive Extensions](https://docs.microsoft.com/en-us/previous-versions/dotnet/reactive-extensions/hh242985(v=vs.103))

[Video Serie mit Rx.NET Beispielen](https://channel9.msdn.com/Series/Rx-Workshop/Rx-Workshop-Introduction)
