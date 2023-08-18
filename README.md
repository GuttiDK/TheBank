# TheBank Projekt

## Forfatter
GuttiDK / Christian CH

## Beskrivelse
TheBank er et Console-projekt designet til at simulere en bank. Dette er den f�rste del af projektet, og flere funktioner vil blive tilf�jet i fremtidigen.


## Changelog - (Update Bank4)

## BankMethods.cs

- **Klasse `BankMethods`**
  - Initialisering af banken med et givent navn.
  - Administrerer den samlede bankbalance og individuelle konto-balancer.
  - Underst�tter oprettelse af konti (L�nkonto, Opsparingskonto, Forbrugskonto).
  - Tillader indbetalinger og udbetalinger for specifikke konti.
  - Giver mulighed for at tjekke saldoen for specifikke konti og banken som helhed.

- **Metoder**
  - `CreateAccount`: Opretter en ny konto baseret p� typen.
  - `GetAccounts`: Returnerer alle konti.
  - `ChargeInterest`: Anvender rente p� alle konti baseret p� deres type.
  - `Deposit`, `Withdraw`, `Balance`, `BankBalance`, `GetBankName`, `FindAccountName`, og `FindAccountId`: Hj�lpefunktioner til forskellige operationer.

## Program.cs

- **Klasse `Program`**
  - Hoveddriverklassen for bankapplikationen.
  - Leverer et simpelt konsol-interface til at interagere med `BankMethods`.

- **Funktioner**
  - Menu-drevne operationer som kontooprettelse, indbetaling, udbetaling, saldocheck osv.
  - Fejlh�ndtering for ugyldige input.

- **Hj�lpefunktioner**
  - `Menu`: Viser hovedmenuen.
  - `MenuFix`: Opdaterer sk�rmbilledet.
  - `CreateAccountMenu`: Hj�lper med at v�lge kontotype.
  - `ListAccounts`: Viser alle konti og deres detaljer.
  - `ListAccountType`: Viser kontotyper for alle konti.
  - Input hj�lpefunktioner som `InputString`, `InputInt` og `InputDecimal` for at tage brugerinput.

## Bank.cs

- **Klasse `Bank`**
  - Repr�senterer konceptet med en bank.
  - Holder en liste af konti, bankbalance og en t�ller for kontonumre.

## Account.cs

- **Klasse `Account`**
  - Abstrakt klasse, der repr�senterer en generel bankkonto.
  - Afledte klasser: `Checking`, `Savings` og `Consumer` for specifikke kontotyper.
  - Hver afledt klasse har sin egen metode til at beregne rente.

## AccountType.cs

- **Enum `AccountType`**
  - Opregner kontotyperne: L�nkonto, Opsparingskonto, Forbrugskonto.

## Metodebeskrivelser
- **CreateAccount**: Opretter en ny konto med en navn hvor den giver saldo 0 og giver et id og giver en kontotype.
- **GetAccounts**: Returnerer en liste af alle oprettede konti.
- **Deposit**: Inds�tter en given m�ngde penge p� en specificeret konto og returnerer den opdaterede saldo.
- **Withdraw**: Tr�kker en given m�ngde penge fra en specificeret konto og returnerer den opdaterede saldo.
- **Balance**: Returnerer saldoen for en given konto.
- **GetBankName**: Returnerer bankens navn som er en readonly.
- **FindAccountName**: Finder en konto ud fra et givent navn og returnerer den.
- **FindAccountId**: Finder en konto ud fra et givent id og returnerer den.
- **ChargeInterest**: Anvender rente p� alle konti baseret p� deres type.
- **Menu**: Viser hovedmenuen.
- **MenuFix**: Opdaterer sk�rmbilledet.
- **CreateAccountMenu**: Hj�lper med at v�lge kontotype.
- **ListAccounts**: Viser alle konti og deres detaljer og bankens beholdning.
- **ListAccountType**: Viser kontotyper for alle konti.
- Input hj�lpefunktioner som `InputString`, `InputInt` og `InputDecimal` for at tage brugerinput.


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
