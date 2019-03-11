# Rx Introduction

[**ZURÜCK**](./readme.md) 

Rx ist eine Bibliothek für asynchrones und event basiertes programmieren.

Mit Rx kann man
1. (asynchrone) data streams repräsentieren (**Observables**)
2. auf diesen data streams verschiedene Operationen durchgeführen (**LinQ**)
3. Nebenläufigkeit (concurrency) parametrisieren (**Scheduling**)

* Rx = Observables + LinQ + Scheduler

* Observables sind das unifying interface

![ObservableConversions](./assets/happyunicorn.png)


* Semantisch bieten Observables zusätzlich:
1. der Producer der Events kann dem Consumer vermitteln, wann keine Daten mehr kommen (OnCompleted)
2. der Producer der Events kann dem Consumer vermitteln, dass ein Fehler passiert ist (OnError)


* Bestehende Asynchronität oder Event Handling wird nicht ersetzt! (async await / TPL, .NET event)





