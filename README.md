# Interface-Based Composition

  ```mermaid
  graph TD
      A[Car] -->|Interface-Based Composition| B[Engine]
      B --> C[Diesel Engine]
      B --> D[Petrol Engine]
      B --> E[Electric Engine]
      B --> F[Hydrogen Engine]
  ```

Car does not care/ know about type of engine it is using. It only cares about the interface of IEngine. This is an abstract constructor injection. This allows for greater flexibility and easier testing.