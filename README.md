# Interface-Based Composition

```mermaid
graph TD
    A[Car] -->|Uses| G[IEngine]
    G -->|Implemented By| C[Diesel Engine]
    G -->|Implemented By| D[Petrol Engine]
    G -->|Implemented By| E[Electric Engine]
    G -->|Implemented By| F[Hydrogen Engine]
```

Car does not care/ know about type of engine it is using. It only cares about the interface of IEngine. This is an abstract constructor injection. This allows for greater flexibility and easier testing.