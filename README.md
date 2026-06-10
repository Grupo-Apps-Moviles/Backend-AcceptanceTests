# WayPass — Backend Acceptance Tests

Proyecto de pruebas BDD (Behavior-Driven Development) para el backend de **WayPass**, aplicación de transporte colectivo.

## Stack

- **.NET 8** + **xUnit**
- **Reqnroll** (sucesor de SpecFlow) para Gherkin
- **RestSharp** para llamadas HTTP al API
- **FluentAssertions** para aserciones legibles

## Estructura

```
WayPass.AcceptanceTests/
├── Features/   # Archivos .feature en Gherkin (escenarios BDD)
├── Steps/      # Step Definitions (C#) que implementan los .feature
└── Support/    # Hooks, configuración base y helpers HTTP
```

## Cobertura — Sprint 2

| Archivo .feature | User Stories cubiertas |
|---|---|
| `PassengerAuthentication.feature` | US26, US27, US28 |
| `PassengerProfile.feature` | US29 |
| `RouteSearch.feature` | US41, US42, US43, US44 |
| `StopFiltering.feature` | US24 |
| `FavoriteCollections.feature` | US45, US46, US47, US48 |
| `CollectionRouteManagement.feature` | US49, US50, US51, US52 |
| `TripReservation.feature` | US53 |

## Cómo ejecutar

```bash
dotnet test
```

Los tests apuntan por defecto a `https://backendmoviles-hqu5.onrender.com`. Para apuntar a otro entorno:

```bash
WAYPASS_API_BASE=http://localhost:5000 dotnet test
```