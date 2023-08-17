# TheBank Projekt

## Forfatter
GuttiDK / Christian CH

## Beskrivelse
TheBank er et Console-projekt designet til at simulere en bank. Dette er den første del af projektet, og flere funktioner vil blive tilføjet i fremtidigen.


## Changelog - (Update Bank2)

### BankMethods.cs

**Tilføjet:**
- Klasse `BankMethods` med private variabler: `_bankName`, `_idCounter` og `_accounts`.
- Metode `CreateAccount` til at oprette en ny bankkonto.
- Metode `GetAccounts` til at hente alle konti.
- Grundlæggende bankdriftsmetoder: `Deposit` (Indsæt), `Withdraw` (Hæv), `Balance`.
- Metode `GetBankName` til at hente bankens navn.
- Metoder `FindAccountName` og `FindAccountId` til at finde en konto baseret på navn eller ID.

### Program.cs

**Ændret:**
- Implementeret en løkkebaseret brugergrænseflade for interaktion med bankoperationer.

**Tilføjet:**
- Metode `Menu` til at vise en menu for brugeren.
- Metode `ListAccounts` til at vise en liste over alle konti.
- Input hjælpemetoder: `InputString`, `InputInt`, og `InputDecimal`.
- Grundlæggende fejlhåndtering for ugyldigt input og under operationer.

### Bank.cs

**Tilføjet:**
- Klasse `Bank` med egenskaberne `Account` (Konto) og `BankName` (BankNavn).

### Account.cs

**Tilføjet:**
- Klasse `Account` med egenskaberne `Id`, `Name` (Navn) og `Balance`.
- Konstruktør til at oprette en ny konto med navn og ID.

## Metodebeskrivelser
- **CreateAccount**: Opretter en ny konto med en navn hvor den giver saldo 0 og giver et id.
- **GetAccounts**: Returnerer en liste af alle oprettede konti.
- **Deposit**: Indsætter en given mængde penge på en specificeret konto og returnerer den opdaterede saldo.
- **Withdraw**: Trækker en given mængde penge fra en specificeret konto og returnerer den opdaterede saldo.
- **Balance**: Returnerer saldoen for en given konto.
- **GetBankName**: Returnerer bankens navn som er en readonly.
- **FindAccountName**: Finder en konto ud fra et givent navn og returnerer den.
- **FindAccountId**: Finder en konto ud fra et givent id og returnerer den.

## Bugs & Known Bugs and Bug Reporting
Vi arbejder konstant på at forbedre denne applikation. Hvis du støder på nogen bugs eller fejl, bedes du rapportere dem til os.

## Contact Info
**Telefon nr:** +45 28 78 34 14  
**Mail:** [GuttiDK@gmail.com](mailto:GuttiDK@gmail.com)

## Installation

1. Klon dette repository til din lokale maskine.
2. Åbn solutionen i Visual Studio.
3. Byg og kør programmet.

## Licens

Dette projekt er licenseret under MIT licensen. Se `LICENSE` filen for yderligere detaljer.
