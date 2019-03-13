# Rx Scheduler

[**ZURÜCK**](./readme.md) 

Mit Scheduler kann die Nebenläufigkeit gesteuert werden.

```
By default, an Observable and the chain of operators that you apply to it will do its work,
and will notify its observers, on the same thread on which its Subscribe method is called. 

The SubscribeOn operator changes this behavior by specifying a different Scheduler
 on which the Observable should operate. 

The ObserveOn operator specifies a different Scheduler that the Observable will use 
to send notifications to its observers. 
```

* Bestehende Asynchronität oder Event Handling wird nicht ersetzt, d.h. Rx ist per se nicht multithreaded! 
(async await / TPL, .NET event)

Ein ```IScheduler<T>``` besitzt einen Execution Context und eine eigene Zeit.

## Scheduler Typen

| Name       | Execution Context | Execution Policy | Clock               |
|------------|-------------------|------------------|---------------------|
| ThreadPool | Thread Pool       | ASAP             | Machine Time        |
| Dispatcher | UI Thread         | Priority FIFO    |  Machine Time       |
| EventLoop  | Dedicated Thread  | FIFO             | Machine Time        |
| Immediate  | Current Thread    | Immediate        | Machine Time        |
| Remote     | Another Process   | FIFO             | Remote Machine Time |
| Test       | Current Thread    | FIFO             | Virtual Time        |

* Der TestScheduler hilft beim unit testen (kein Abwarten, oder beschleunigte Durchführung etc.)
