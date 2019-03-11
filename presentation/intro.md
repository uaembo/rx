# Rx Introduction


Rx ist eine Bibliothek f�r asynchrones und event basiertes programmieren.

Rx ist
1. eine Menge von Typen, um asynchrone data streams zu repr�sentieren (**Observables**)
2. eine Menge von Operationen, die auf diesen data streams durchgef�hrt werden k�nnen (**LinQ**)
3. eine Menge von Typen, um Nebenl�ufigkeit (concurrency) zu parametrisieren (**Scheduling**)

Rx = Observables + LinQ + Scheduler

Unterschied IEnumerable und IObservable

Semantisch bieten Observables zus�tzlich:
1. der Producer der Events kann dem Consumer vermitteln, wann keine Daten mehr kommen (OnCompleted)
2. der Producer der Events kann dem Consumer vermitteln, dass ein Fehler passiert ist (OnError)


