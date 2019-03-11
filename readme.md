# Reactive Extensions (Rx) 
## Thema 
Introduction mit Rx .NET
## Ziel 
Jeder Teilnehmer:
* [ ] kennt den konzeptionellen Unterschied zwischen **interactive** vs **reactive** programming (Pull vs Push)
* [ ] hat mindestens eine Challenge bestanden
* [ ] weiss, wo die Unterlagen zu dieser Übungsstunde zu finden sind
* [ ]

## Ablauf:  
* [Einführung](./einfuehrung.md) (5')
* Observable + Observer (5')
* LinQ auf "Events" (10')
* Errorhandling (10')
* Scheduling (10')
* ***Pause (5')***
* Challenges (inkl. Pitfalls und Pain) (30')
* Diskussion (15')
* Wrapup (1')

## Unterlagen:
http://reactivex.io/

https://docs.microsoft.com/en-us/previous-versions/dotnet/reactive-extensions/hh242985(v=vs.103)

https://channel9.msdn.com/Series/Rx-Workshop/Rx-Workshop-Introduction



TODO:

* wo ein Fehler passiert im EventHandler (.NET) vs die pipeline
*Observable.FromEventPattern

* Scheduling bsp

* LinQ verwendung, Pipelining
* Cold vs Hot Observables
* Überblick wichtigste Operatoren
* unit testing => https://channel9.msdn.com/Series/Rx-Workshop/Rx-Workshop-Schedulers 5.Min
=> time based semantics oder sehr lange anhaltende operationen

* invalidoperationexception challenge (UI Thread mit Win Forms proj
* ObserveOn nutzen , wenn man keine Kontrolle hat, wo Concurrency eingeführt wird (wenn die Source auf irgend einem Thread generiert wurde)
* alles (OnNext, OnCompleted, OnError) was danach folgt, wird über den execution context des neuen Schedulers verarbeitet