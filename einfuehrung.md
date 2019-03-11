# Rx Scheduler

[**ZURÜCK**](./readme.md) 

| Name       | Execution Context | Execution Policy | Clock               |
|------------|-------------------|------------------|---------------------|
| ThreadPool | Thread Pool       | ASAP             | Machine Time        |
| Dispatcher | UI Thread         | Priority FIFO    |  Machine Time       |
| EventLoop  | Dedicated Thread  | FIFO             | Machine Time        |
| Immediate  | Current Thread    | Immediate        | Machine Time        |
| Remote     | Another Process   | FIFO             | Remote Machine Time |
| Test       | Current Thread    | FIFO             | Virtual Time        |
