# TheBank Projekt

## Forfatter
GuttiDK / Christian CH

## Beskrivelse
TheBank er et Console-projekt designet til at simulere en bank. Dette er den f�rste del af projektet, og flere funktioner vil blive tilf�jet i fremtidigen.


## Changelog

### BankMethods.cs
- **Added:** Klasse ved navn `BankMethods`.
- **Added:** Private variabler: `_bankName`, `_idCounter`, og `_accounts`.
- **Added:** Constructor til at initialisere bankens navn og en liste af konti.
- **Added:** Metode `CreateAccount` til at oprette en ny konto med id, navn og balance.
- **Added:** Metode `GetAccounts` til at returnere listen af konti.
- **Added:** Metode `Deposit` til at inds�tte penge p� en given konto og returnere dens nye balance.
- **Added:** Metode `Withdraw` til at h�ve penge fra en given konto og returnere dens nye balance.
- **Added:** Metode `Balance` til at returnere balancen for en given konto.

### Program.cs
- **Added:** Klasse `Program` med `Main` metode.
- **Implemented:** En instans af `BankMethods` med navnet "Bank of America".
- **Added:** Oprettelse af en ny konto ved navn "John Doe".
- **Added:** En r�kke konsoludskrifter til demonstration af bankens funktionalitet.

### Bank.cs 
- **Added:** Klasse `Bank`.
- **Added:** Properties `Account` og `BankName`.

### Account.cs 
- **Added:** Klasse `Account`.
- **Added:** Properties: `Id`, `Name`, og `Balance`.
- **Added:** Constructor der tager et valgfrit navn som parameter og initialiserer balancen til 0.

## Metodebeskrivelser
- **CreateAccount**: Opretter en ny konto med en given id og navn, og initialiserer balancen til 0.
- **GetAccounts**: Returnerer en liste af alle oprettede konti.
- **Deposit**: Inds�tter en given m�ngde penge p� en specificeret konto og returnerer den opdaterede balance.
- **Withdraw**: Tr�kker en given m�ngde penge fra en specificeret konto og returnerer den opdaterede balance.
- **Balance**: Returnerer saldoen for en given konto.

## Bugs & Known Bugs and Bug Reporting
Vi arbejder konstant p� at forbedre denne applikation. Hvis du st�der p� nogen bugs eller fejl, bedes du rapportere dem til os.

## Contact Info
**Telefon nr:** +45 28 78 34 14  
**Mail:** [GuttiDK@gmail.com](mailto:GuttiDK@gmail.com)

## Installation

1. Klon dette repository til din lokale maskine.
2. �bn solutionen i Visual Studio.
3. Byg og k�r programmet.

## Licens

Dette projekt er licenseret under MIT licensen. Se `LICENSE` filen for yderligere detaljer.
