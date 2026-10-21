# Design patterns learning path

The examples in this directory are intentionally small. Read the record first,
then look at the caller and ask what would become difficult if the pattern were
removed.

## Suggested order

1. **Builder** — `Creational/BuilderExample.cs` is the first complete example.
2. **Factory** — centralize creation decisions.
3. **Adapter** and **Decorator** — compose and protect external dependencies.
4. **Strategy**, **Observer**, and **Command** — model behavior and events.
5. **Repository** — compare the abstraction with the actual persistence needs of an application.

Visit `/patterns` to use the interactive Blazor explorer. The page demonstrates:

- `@page` routing and component composition
- `@bind` two-way binding for form inputs
- `@onclick` event handling
- dependency injection with `@inject`
- conditional rendering with `@if`
- component state changing without a full-page request

The explorer is a learning aid, not a claim that every application needs every
pattern. Prefer simple code until a pattern solves a real design problem.
