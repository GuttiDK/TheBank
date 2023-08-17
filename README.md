# TheBank Projekt

## Forfatter
GuttiDK / Christian CH

## Beskrivelse
TheBank er et Console-projekt designet til at simulere en bank. Dette er den f�rste del af projektet, og flere funktioner vil blive tilf�jet i fremtidigen.


## Changelog - (Update Bank2)

### BankMethods.cs

**Tilf�jet:**
- Klasse `BankMethods` med private variabler: `_bankName`, `_idCounter` og `_accounts`.
- Metode `CreateAccount` til at oprette en ny bankkonto.
- Metode `GetAccounts` til at hente alle konti.
- Grundl�ggende bankdriftsmetoder: `Deposit` (Inds�t), `Withdraw` (H�v), `Balance`.
- Metode `GetBankName` til at hente bankens navn.
- Metoder `FindAccountName` og `FindAccountId` til at finde en konto baseret p� navn eller ID.

### Program.cs

**�ndret:**
- Implementeret en l�kkebaseret brugergr�nseflade for interaktion med bankoperationer.

**Tilf�jet:**
- Metode `Menu` til at vise en menu for brugeren.
- Metode `ListAccounts` til at vise en liste over alle konti.
- Input hj�lpemetoder: `InputString`, `InputInt`, og `InputDecimal`.
- Grundl�ggende fejlh�ndtering for ugyldigt input og under operationer.

### Bank.cs

**Tilf�jet:**
- Klasse `Bank` med egenskaberne `Account` (Konto) og `BankName` (BankNavn).

### Account.cs

**Tilf�jet:**
- Klasse `Account` med egenskaberne `Id`, `Name` (Navn) og `Balance`.
- Konstrukt�r til at oprette en ny konto med navn og ID.

## Metodebeskrivelser
- **CreateAccount**: Opretter en ny konto med en navn hvor den giver saldo 0 og giver et id.
- **GetAccounts**: Returnerer en liste af alle oprettede konti.
- **Deposit**: Inds�tter en given m�ngde penge p� en specificeret konto og returnerer den opdaterede saldo.
- **Withdraw**: Tr�kker en given m�ngde penge fra en specificeret konto og returnerer den opdaterede saldo.
- **Balance**: Returnerer saldoen for en given konto.
- **GetBankName**: Returnerer bankens navn som er en readonly.
- **FindAccountName**: Finder en konto ud fra et givent navn og returnerer den.
- **FindAccountId**: Finder en konto ud fra et givent id og returnerer den.

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
