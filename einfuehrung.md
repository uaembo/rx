# Rx Introduction

[**ZUR�CK**](./readme.md) 

Rx ist eine Bibliothek f�r asynchrones und event basiertes programmieren.

Mit Rx kann man
1. (asynchrone) data streams repr�sentieren (**Observables**)
2. auf diesen data streams verschiedene Operationen durchgef�hren (**LinQ**)
3. Nebenl�ufigkeit (concurrency) parametrisieren (**Scheduling**)

* Rx = Observables + LinQ + Scheduler

* Observables sind das unifying interface

![ObservableConversions](./assets/happyunicorn.png)


* Semantisch bieten Observables zus�tzlich:
1. der Producer der Events kann dem Consumer vermitteln, wann keine Daten mehr kommen (OnCompleted)
2. der Producer der Events kann dem Consumer vermitteln, dass ein Fehler passiert ist (OnError)


* Bestehende Asynchronit�t oder Event Handling wird nicht ersetzt! (async await / TPL, .NET event)





