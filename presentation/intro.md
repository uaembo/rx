# Rx Introduction


Rx ist eine Bibliothek für asynchrones und event basiertes programmieren.

Rx ist
1. eine Menge von Typen, um asynchrone data streams zu repräsentieren (**Observables**)
2. eine Menge von Operationen, die auf diesen data streams durchgeführt werden können (**LinQ**)
3. eine Menge von Typen, um Nebenläufigkeit (concurrency) zu parametrisieren (**Scheduling**)

Rx = Observables + LinQ + Scheduler

Unterschied IEnumerable und IObservable

Semantisch bieten Observables zusätzlich:
1. der Producer der Events kann dem Consumer vermitteln, wann keine Daten mehr kommen (OnCompleted)
2. der Producer der Events kann dem Consumer vermitteln, dass ein Fehler passiert ist (OnError)


