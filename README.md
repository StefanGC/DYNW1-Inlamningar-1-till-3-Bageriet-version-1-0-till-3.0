# [DYNW1] Inlamningar 1 till 3: Bageriet version 1.0 till 3.0

## Version 1.0

Kontinuerlig inlämningsuppgift för kursen Dynamiska Webbsystem 1

I denna uppgift ska du skapa din första riktiga webbapplikation i C#, kunden är i detta fallet en bagare som vill lägga upp sina tillgängliga produkter på en hemsida. Kunden vill ha kunna visa sina kontaktuppgifter och tillgängliga produkter. I framtiden ska hemsidan byggas ut med stöd för direktbeställningar från nätet - men nu vill bagaren ha en första sida klar så snart som möjligt!

### Kravspecifikation:

*   Lösningen ska bestå av en körbar ASP.NET applikation skriven i C# (netcoreapp2.2 eller netcoreapp3.0).
*   Du ska tillämpa designmönstret Model View Controller (MVC).
*   Man ska från en sida kunna se bageriets kontaktuppgifter.
*   Man ska på en annan sida kunna lista alla tillgängliga produkter från bageriet.
*   Dom tillgängliga produkterna ska vara sparade i en lista ( förslagsvis av typen _**List<Product>**_)

### Ytterligare önskemål:

För VG på uppgiften krävs det att lösningen ska vara byggd med goda objektorienterade principer, framförallt sett till vart listan med produkterna är definierad. Tänk på att vi kommer fortsätta jobba med denna uppgift i nästa inlämningsuppgift, _bageriet 2.0._ Så att få en bra struktur i denna uppgift är viktig för att för att underlätta även i nästa veckas uppgift.

### Rapport och inlämning

Inlämningen ska innehålla en rapport, denna rapport ska kort beskriva din förståelse över designmönstret MVC och hur du tillämpat det i din lösning.

När du är färdig med din uppgift så skall du bifoga repporten som ett pdf-dokument, som dessutom innehåller en länk till ditt gitrepo.


## Version 2.0

### Krav på rapporten
Rapporten ska innehålla...

- En länk till gitrepot med version 2 av projektet.
- En kort analys över kodstrukturen innan du börjar koda, s.k. nulägesrapport, hänvisa med fördel till använda designmönster (1-3 paragrafer).
- En kort beskrivning till bagaren om vad TDD är och hur du använt detta för att utföra hens önskade förändringar.
- En egen skriven kravspecifikation samt en beskrivning av status på varje givet krav när lösningen var färdig. 1 stycke per krav räcker, hur är kravet uppfyllt i den färdiga lösningen?
- En kort analys över förändringarna i kodstrukturen när du lämnar in, s.k. slutrapport, hänvisa med fördel till använda designmönster (1-2 paragrafer).
- Slutrapporten ska efterföljas av en lista över de enhetestester som finns i lösningen samt motiverar valet av dessa (1 paragraf per test)
 

### Krav på den tekniska lösningen:
- Lösningen ska bestå av en vidareutvecklat version av er lösning på Bageriet 1.0.
- Projektet ska innehålla minst 2 väl valda enhetstester som använts för att verifiera kraven du identifierat i förändringsarbetet.
- Du ska ha implementerat en lösning som använder Entity Framework.


## Version 3.0

### Kravlista
- En besökare ska kunna registera sig som en användare på hemsidan
- En besökare som registerat sig ska kunna logga in som en användare på hemsidan
- En inloggad användare ska kunna lämna kommentarer på en given typ av produkt/bakelse
- En inloggad användare ska kunna lämna ett betyg på en given typ av produkt/bakelse, betyget ska vara mellan 1 och 5
- Det genomsnittliga betyget på en produkt/bakelse ska visas för alla besökare på sidan.
- Kommentarer på produkter/bakelser ska visas för alla besökare på sidan.
 
### Vad ska jag lämna in?
Du ska lämna in en skriftlig rapport i PDF format samt en teknisk implementation av din lösning.

Den tekniska lösningen ska innehålla misnt ett nytt enhetstest som använts för något av de ovanstående kraven - använd med fördel ett test av asp.net ramverket.

### Krav på rapporten
Rapporten ska innehålla...

- En länk till gitrepot med version 3 av projektet.
- En kort analys över kodstrukturen innan du börjar koda, s.k. nulägesrapport, hänvisa med fördel till använda designmönster (1-2 paragrafer).
- En kopia av ovanstående kravspecifikation för arbetet med en beskrivning på status på varje givet krav när lösningen var färdig. 1 kort textstycke per krav räcker, beskriv hur kravet är uppfyllt i den färdiga lösningen?
- En kort analys över förändringarna i kodstrukturen när du lämnar in, s.k. slutrapport, hänvisa med fördel till använda designmönster och ramverk (1-2 paragrafer).
- Slutrapporten ska efterföljas av en lista över de enhetestester som finns i lösningen samt motiverar valet av dessa (1 paragraf per test)
 
### Krav på den tekniska lösningen:
- Lösningen ska bestå av en vidareutvecklat version av er lösning på Bageriet 2.0.
- Projektet ska innehålla minst ett enhetstest, men gärna flera.
