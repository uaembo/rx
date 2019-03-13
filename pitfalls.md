# Rx Pitfalls

[**ZURÜCK**](./readme.md) 

## Hot vs Cold Observables (und das "dazwischen")

Ein Observable ist "cold", wenn die darunterliegende Quelle
erst beim subscriben erstellt und aktiviert wird.

```
IObservable<int> _observable = Observable.Range( 1, 5 );
//later...
//
 _observable.Subscribe(value => 
            {
                Console.WriteLine(value);
            } );
```

Ein Observable ist "hot", wenn bereits vor der Subscription Werte gepusht wurden,
z.B. bei data streams oder Mouse Movement Events

## Backpressure

Kommt von einem data stream zu viel, 
kann z.b. mittels den Operatoren Debounce oder Throttling
der "Druck" auf die Sink / den Konsumenten reduziert werden (lossy Backpressure). 

Mehr unter:

https://xgrommx.github.io/rx-book/content/getting_started_with_rxjs/creating_and_querying_observable_sequences/backpressure.html

## Stateless / Stateful pipelining

Das automagische Concurrency Management geht kaputt, wenn ein State aussen gehalten wird
=> unsynchronisierte Ressource

```
 int value = 0;
            var observable = Observable
                .Interval( TimeSpan.FromSeconds( 1 ))
                .Select( ts => value++ );
 //dont work with value here
 //if(value > x){...}
```



## Verschachtelte Subscriptions

//TBD

## 