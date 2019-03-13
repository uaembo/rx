# Rx Observables

[**ZURÜCK**](./readme.md) 

Observables und ihre Observer sind das "unifying" interface

![ObservableConversions](./assets/happyunicorn.png)


* Semantisch bieten Observables zusätzlich:
* der Producer der Events kann dem Consumer vermitteln, wann keine Daten mehr kommen (OnCompleted)
* der Producer der Events kann dem Consumer vermitteln, dass ein Fehler passiert ist (OnError)

```
namespace System
{
    public interface IObserver<in T>
    {
        void OnCompleted();
        void OnError( Exception error );
        void OnNext( T value );
    }
}
```

## Subject

* Subjects sind auch Observables, implementieren aber auch das ```IObserver<T>``` interface, d.h. es ist
möglich, dem Subject eigene Events zurück zu pushen.
* Sie halten also eine Liste der Observer und einen Zustand.
* Subjects können nach OnCompleted() nicht mehr "reaktiviert" werden.


## IEnumerable vs IObservable

* Unterschied IEnumerable<T> vs IObservable<T>
  IEnumerable : "pull" aus einer Sequenz von T
  IObservable : eine Sequenz von T

```IEnumerable<T> Observable.ToEnumerable(this IObservable<T>)```
* Wenn ein T vom Observable "gepushed" wird, landet es in einer queue, bis man es "pullt" (z.B. "To.List()")
* Wenn man auf einer leeren Sequenz "pullt", wird blockiert, bis diese queue nicht mehr leer ist und dann dequeued.

```IObservable<T> Observable.ToObservable(this IEnumerable<T>)```
* Ein Thread aus dem .NET thread pool wird periodisch versuchen die IEnumerable zu pullen
* Jedes Mal wenn er ein T "pullt, wird das über das IObservable bis zum Subscriber "gepusht"

### Wann soll was verwendet werden?

* A huge CSV text file has an item on each line, and you want to process them one at a time without loading the entire file into memory at once

* You are running an HTTP web server

* You are responding to user interface button clicks

* You have multiple incoming data that you would like to correlate


