# KRAVSPECIFIKATION SOSU POWER 9000
Kravspecifikation opdeles i sybsystems:

Subsystem 01: Opgavehåndtering

Subsystem 02: Medarbejderhåndtering

## Subsystem 01: Opgavehåndtering
**Aktører:**
* **SOSU-medarbejdere**: Løser opgaver hos beboerne.
---
01. SOSU-medarbejderen skal kunne se sin opgaveoversigt for dagens dato.
0. Opgaveoversigten skal sorteres i kronologisk rækkefølge.
0. I opgaveoversigten skal opgaverne have følgende information:
    * Nummer
    * Tid
    * Adresse
    * Navn
    * Fuldført
0. SOSU-medarbejderen skal kunne vælge en opgave fra opgaveoversigten.
0. SOSU-medarbejderen skal kunne se følgende data om beboeren, når en opgave fra opgaveroversigten er valgt:   
   * Navn
   * Adresse
   * Sygdom
   * Medicin
   * Skavanker
   * Yderlige noter
0. SOSU-medarbejderen skal kunne se hvilke delopgaver der er, når en opgave fra opgaveroversigten er valgt.
0. SOSU-medarbejderen skal kunne markere delopgaver som fuldført.
0. SOSU-medarbejderen skal kunne tilføje noter til opgaven.
0. SOSU-medarbejderen skal kunne markere hvilket medicin er givet.
0. SOSU-medarbejderen skal kunne tilføje noter omkring medicin til opgaven.
0. SOSU-medarbejderen skal kunne afslutte en valgt opgave.
0. SOSU-medarbejderen skal retuneres til opgaveoversigten efter at have markeret en opgave som afsluttet.

## Subsystem 02: Medarbejderhåndtering
**Aktører:**
* **Taskplanner**: Håndtere opgaver til SOSU-medarbejdere.
* **Administrator**: Håndtere SOSU-medarbejdere og beboere med info.
---
01. Administrator skal kunne tilføje SOSU-medarbejdere.
0. Administrator skal kunne fjerne SOSU-medarbejdere.
0. Administrator skal kunne tilføje beboere med info:
    * Navn
    * Adresse
    * Sygdom
    * Medicin
    * Skavanker
    * Yderlige noter
0. Administrator skal kunne fjerne beboere.
0. Taskplanneren skal kunne oprette og tildele opgaver til SOSU-medarbejderene:
    * Delopgaver
    * Medicin oplysninger
    * Noter til overordnet opgave
    * Noter til medicin

# IKKE_FUNKTIONELLE KRAV
Systemet skal overholde følgende ikke-funktionelle krav:

01. Databasen skal hostes på en Microsoft SQL Express Server 2019 på din lokale maskine.
02. Backend skal udvikles i C# med Visual Studio 2022.
03. Backend skal være en ASP.NET Core application med .NET 8 som runtime.
04. Backend skal hostes på en IIS Express på din lokale maskine til udvikling.
05. Backend skal til produktion kunne deployes på en Windows Server 2019 maskine på en IIS med .NET 8 som runtime.