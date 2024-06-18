# Playlist

- Introduction
  - Hello
  - Name
  - Project
    - The case
- Setup GitHub version control & GitHub Issues
- Inception, Elaboration, and construction
- Entities and DB with Entity Framework
- Data access
  - IRepository
  - Implementation of Repository
  - Brug i controllers
  - Dependency Injection (DI) in Program.cs (`builder.Services.AddScoped<IRepository<Address>, Repository<Address>>();`)
    - AddScoped:
      - Lifetime - Scoped (Dies when the HTTP request is completed)
      - Scope - The service is created once per client request (connection).
    - AddSingleton:
      - Lifetime - Singleton (Dies when the application shuts down)
      - Scope - The service is created once and shared throughout the application's lifetime. Used for configuration.
    - Transient:
      - Scope - Each request, and it's created each time it's requested.
      - Lifetime - Dies when the request is completed
-

# TODO

- [ ] Objektorienteret programmering, med fokus på principperne arv, polymorfi og design mønstre.
- [x] Systemudviklingsmetoder og projektstyring ved de anvendte metodikker, samt den konkrete anvendelse af GitHub projects.
- [ ] UI/UX herunder overvejelser om disse, de valgte teknologier, samt
      implementeringen af kommunikationen med backend.
- [ ] Backend arkitekturen, herunder hvordan Separation of Concerns er anvendt.
- [ ] API’et, herunder strukturen og anvendelsen.
- [ ] DataAccess biblioteket, herunder strukturen og anvendelsen.

# Issues/problemer

- Det har været svært at finde god dokumentation for EF og MAUI.
- Jeg brugte lang tid på at få filtreret det data jeg fik fra API-kaldet (Det retunerede med $"1" {"id": ... }) og det kunne vi ikke bruge til noget.
