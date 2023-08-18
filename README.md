# TheBank Projekt

## Forfatter
GuttiDK / Christian CH

## Beskrivelse
TheBank er et Console-projekt designet til at simulere en bank. Dette er den første del af projektet, og flere funktioner vil blive tilføjet i fremtidigen.


## Changelog - (Update Bank4)

## BankMethods.cs

- **Klasse `BankMethods`**
  - Initialisering af banken med et givent navn.
  - Administrerer den samlede bankbalance og individuelle konto-balancer.
  - Understøtter oprettelse af konti (Lønkonto, Opsparingskonto, Forbrugskonto).
  - Tillader indbetalinger og udbetalinger for specifikke konti.
  - Giver mulighed for at tjekke saldoen for specifikke konti og banken som helhed.

- **Metoder**
  - `CreateAccount`: Opretter en ny konto baseret på typen.
  - `GetAccounts`: Returnerer alle konti.
  - `ChargeInterest`: Anvender rente på alle konti baseret på deres type.
  - `Deposit`, `Withdraw`, `Balance`, `BankBalance`, `GetBankName`, `FindAccountName`, og `FindAccountId`: Hjælpefunktioner til forskellige operationer.

## Program.cs

- **Klasse `Program`**
  - Hoveddriverklassen for bankapplikationen.
  - Leverer et simpelt konsol-interface til at interagere med `BankMethods`.

- **Funktioner**
  - Menu-drevne operationer som kontooprettelse, indbetaling, udbetaling, saldocheck osv.
  - Fejlhåndtering for ugyldige input.

- **Hjælpefunktioner**
  - `Menu`: Viser hovedmenuen.
  - `MenuFix`: Opdaterer skærmbilledet.
  - `CreateAccountMenu`: Hjælper med at vælge kontotype.
  - `ListAccounts`: Viser alle konti og deres detaljer.
  - `ListAccountType`: Viser kontotyper for alle konti.
  - Input hjælpefunktioner som `InputString`, `InputInt` og `InputDecimal` for at tage brugerinput.

## Bank.cs

- **Klasse `Bank`**
  - Repræsenterer konceptet med en bank.
  - Holder en liste af konti, bankbalance og en tæller for kontonumre.

## Account.cs

- **Klasse `Account`**
  - Abstrakt klasse, der repræsenterer en generel bankkonto.
  - Afledte klasser: `Checking`, `Savings` og `Consumer` for specifikke kontotyper.
  - Hver afledt klasse har sin egen metode til at beregne rente.

## AccountType.cs

- **Enum `AccountType`**
  - Opregner kontotyperne: Lønkonto, Opsparingskonto, Forbrugskonto.

## Metodebeskrivelser
- **CreateAccount**: Opretter en ny konto med en navn hvor den giver saldo 0 og giver et id og giver en kontotype.
- **GetAccounts**: Returnerer en liste af alle oprettede konti.
- **Deposit**: Indsætter en given mængde penge på en specificeret konto og returnerer den opdaterede saldo.
- **Withdraw**: Trækker en given mængde penge fra en specificeret konto og returnerer den opdaterede saldo.
- **Balance**: Returnerer saldoen for en given konto.
- **GetBankName**: Returnerer bankens navn som er en readonly.
- **FindAccountName**: Finder en konto ud fra et givent navn og returnerer den.
- **FindAccountId**: Finder en konto ud fra et givent id og returnerer den.
- **ChargeInterest**: Anvender rente på alle konti baseret på deres type.
- **Menu**: Viser hovedmenuen.
- **MenuFix**: Opdaterer skærmbilledet.
- **CreateAccountMenu**: Hjælper med at vælge kontotype.
- **ListAccounts**: Viser alle konti og deres detaljer og bankens beholdning.
- **ListAccountType**: Viser kontotyper for alle konti.
- Input hjælpefunktioner som `InputString`, `InputInt` og `InputDecimal` for at tage brugerinput.


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
