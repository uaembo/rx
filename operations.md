# Rx Operationen

[**ZUR�CK**](./readme.md) 

Auf ```IObservable<T>``` sind zahlreiche Operationen verf�gbar.
Diese k�nnen direkt �ber LinQ Extensions oder LinQ ausgedr�ckt werden.

## Operatoren
http://reactivex.io/documentation/operators.html

Kategorien:
* Creating Observables
* Transforming Observables
* Filtering Observables
* Combining Observables: mehrere Source Observables werden kombiniert ("higher order functions")

Einige Operatoren haben **zeitbasierte** Semantik!

## Wie liest man das Marble Diagramm?
![](./assets/legend.png)


## Beispiele

---
### Filter


![](./assets/filter.png)

---

### Max

![](./assets/max.png)

---

### Map

![](./assets/map.png)

---

### Buffer

![](./assets/buffer.png)

---
### Join

![Join](./assets/join.c.png)

---
### Zip

![Join](./assets/zip.png)

* kein Equality basiertes Joining, sondern basierend auf zeitlicher �berlappung


### Create Observable Operation
Events werden in eine Observable umgewandelt:

```
_fileCreatedObseringDisposable = Observable.FromEventPattern<FileEventArgs>(
                    ev => _inputFilewatcher.FileCreatedNew += ev,
                    ev => _inputFilewatcher.FileCreatedNew -= ev )
                .Select( ev => ev.EventArgs.Path )
                .Buffer( TimeSpan.FromMilliseconds( 500 ), 6 )
                .Subscribe( ( files ) => ...);
```
