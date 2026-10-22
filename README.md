# Transport API & WebApp

Aplikacja webowa wspierająca obsługę zleceń transportowych, rozwijana z wykorzystaniem **ASP.NET Core Web API**, **C#**, **Angular** oraz **SQL**.

Projekt powstaje jako praktyczny przykład projektowania i implementacji aplikacji webowej z podziałem na backend i frontend. Jego celem jest rozwijanie umiejętności w zakresie tworzenia REST API, integracji systemów, dostępu do danych oraz testowania oprogramowania.

## Spis treści

- [Opis projektu](#opis-projektu)
- [Funkcjonalności](#funkcjonalności)
- [Architektura](#architektura)
- [Technologie](#technologie)
- [Struktura repozytorium](#struktura-repozytorium)
- [Wymagania](#wymagania)
- [Uruchomienie projektu](#uruchomienie-projektu)
- [Testowanie](#testowanie)
- [Plany rozwoju](#plany-rozwoju)

## Opis projektu

Transport API & WebApp to projekt aplikacji przeznaczonej do obsługi procesów związanych z transportem. System składa się z backendowego REST API oraz aplikacji frontendowej, która komunikuje się z API.

Projekt pozwala rozwijać i prezentować praktyczne umiejętności w zakresie:

- projektowania endpointów REST API,
- implementacji logiki biznesowej w C#,
- walidacji danych wejściowych,
- obsługi operacji CRUD,
- uwierzytelniania i autoryzacji użytkowników,
- integracji frontendu z backendem,
- pracy z relacyjną bazą danych,
- pisania testów jednostkowych i integracyjnych.

## Funkcjonalności

### Backend — ASP.NET Core Web API

- Obsługa użytkowników.
- Uwierzytelnianie i autoryzacja z wykorzystaniem JWT.
- Zarządzanie zleceniami transportowymi.
- Operacje tworzenia, pobierania, aktualizacji i usuwania danych.
- Walidacja danych przekazywanych do API.
- Komunikacja z relacyjną bazą danych.
- Obsługa błędów i odpowiedzi HTTP.

### Frontend — Angular

- Interfejs użytkownika komunikujący się z backendem przez HTTP.
- Widoki do obsługi zleceń transportowych.
- Formularze tworzenia i edycji danych.
- Wyszukiwanie i filtrowanie rekordów.
- Obsługa odpowiedzi API i prezentowanie danych użytkownikowi.

### Testy

W repozytorium znajdują się osobne projekty przeznaczone do testowania backendu:

- **Testy jednostkowe** — weryfikacja wybranych elementów logiki aplikacji.
- **Testy integracyjne** — sprawdzanie współpracy komponentów aplikacji oraz działania API.

Zakres testów będzie rozwijany wraz z kolejnymi funkcjonalnościami.

## Architektura

Projekt został podzielony na niezależne części odpowiedzialne za poszczególne obszary aplikacji:

```text
Transport API & WebApp
│
├── AngularProject1
│   └── Aplikacja frontendowa
│
├── WebApplication1
│   └── ASP.NET Core Web API
│
├── WebApplication1.UnitTests
│   └── Testy jednostkowe
│
└── WebApplication1.IntegrationTests
    └── Testy integracyjne
```

Frontend komunikuje się z backendem za pomocą żądań HTTP. API odpowiada za realizację logiki aplikacji, autoryzację dostępu oraz współpracę z bazą danych.

## Technologie

| Obszar | Technologie |
|---|---|
| Backend | C#, .NET, ASP.NET Core Web API |
| Frontend | Angular, TypeScript, HTML, CSS |
| API | REST, HTTP, JSON |
| Bezpieczeństwo | JWT, uwierzytelnianie i autoryzacja |
| Baza danych | Firebird SQL |
| Dostęp do danych | LINQ to DB |
| Testowanie | Testy jednostkowe i integracyjne dla .NET |
| Narzędzia | Git, GitHub, Visual Studio, DBeaver |

## Wymagania

Do uruchomienia projektu potrzebne są:

- .NET SDK w wersji zgodnej z plikiem projektu.
- Node.js i npm w wersjach zgodnych z projektem Angular.
- Serwer bazy danych Firebird, jeśli korzystasz z tej bazy w lokalnej konfiguracji.
- Git.
- Visual Studio lub inne środowisko obsługujące .NET i Angular.

## Uruchomienie projektu

### 1. Pobranie repozytorium

```bash
git clone https://github.com/Remin300/Transport_Api_-_WebApp.git
cd Transport_Api_-_WebApp
```

### 2. Uruchomienie backendu

Przejdź do katalogu projektu API:

```bash
cd WebApplication1
dotnet restore
dotnet build
dotnet run
```

Adres uruchomionego API zależy od konfiguracji aplikacji. Można go sprawdzić w konsoli po uruchomieniu projektu lub w pliku `Properties/launchSettings.json`.

### 3. Uruchomienie frontendu

W nowym terminalu przejdź do katalogu Angular:

```bash
cd AngularProject1
npm install
ng serve
```

Następnie otwórz adres wyświetlony przez Angular CLI, domyślnie `http://localhost:4200`.

### 4. Konfiguracja połączenia z bazą danych

Przed uruchomieniem funkcjonalności wymagających bazy danych skonfiguruj odpowiednie parametry połączenia zgodnie z konfiguracją aplikacji.

Nie zapisuj haseł, tokenów ani innych danych poufnych bezpośrednio w repozytorium. Do lokalnego uruchamiania używaj odpowiedniej konfiguracji developerskiej lub zmiennych środowiskowych.


## Testowanie

Testy backendu znajdują się w osobnych projektach.

Aby zbudować rozwiązanie:

```bash
dotnet build
```

Aby uruchomić testy jednostkowe:

```bash
dotnet test WebApplication1.UnitTests
```

Aby uruchomić testy integracyjne:

```bash
dotnet test WebApplication1.IntegrationTests
```

Testy integracyjne mogą wymagać dodatkowej konfiguracji środowiska, bazy danych lub usług zewnętrznych.

## Plany rozwoju

Możliwe kierunki dalszego rozwoju projektu:

- Rozbudowa walidacji danych wejściowych.
- Ujednolicenie obsługi błędów API.
- Rozszerzenie pokrycia testami jednostkowymi i integracyjnymi.
- Usprawnienie obsługi logowania i autoryzacji.
- Dodanie paginacji i bardziej zaawansowanego filtrowania.
- Rozbudowa dokumentacji endpointów.
- Przygotowanie środowiska demonstracyjnego z przykładowymi danymi.
- Automatyzacja budowania i testowania za pomocą CI/CD.

## Status projektu

Projekt jest rozwijany. Lista funkcjonalności, dokumentacja uruchomienia oraz zakres testów będą aktualizowane w miarę postępów prac.

## Autor

**Remin300**

GitHub: [github.com/Remin300](https://github.com/Remin300)
