# Állatörökbefogadást támogató ajánlórendszer 🐾

**Szolgáltatás-orientált programozás – féléves beadandó**

Készítette: Jenei Viola  
Neptunkód: GTDIOV  
Tokaj-Hegyalja Egyetem, 2026

## A projekt bemutatása

A féléves beadandómhoz egy állatörökbefogadást segítő Windows Forms alkalmazást készítettem.

A program célja, hogy a felhasználó a saját igényei és életmódja alapján találhasson számára megfelelő kutyát vagy macskát.

A keresés során megadható:
- A keresett állat típusa (kutya vagy macska)
- Lakhatási körülmények (lakás vagy kertes ház)
- Kívánt aktivitási szint
- Van-e már másik háziállat
- Település
- Maximális keresési távolság

A szerver a megadott feltételek alapján pontozza az állatokat, majd a legjobb találatokat jeleníti meg. A távolságot légvonalban számolja.

Az alkalmazás jelenleg 24 tesztállatot tartalmaz.

## Felhasznált technológiák

- C# – programozási nyelv
- Windows Forms – felhasználói felület
- ASP.NET Core Web API – szerver
- SQLite és Entity Framework Core – adatbázis
- REST API és JSON – kliens–szerver kommunikáció
- OpenStreetMap Nominatim – települések koordinátáinak lekérése
- Haversine-képlet – távolságszámítás

## A program indítása

A program futtatásához Visual Studio és a projektekhez szükséges .NET SDK szükséges. A települések kereséséhez internetkapcsolat is kell.

1. A GitHubon a **Code → Download ZIP** lehetőséggel töltsük le a projektet.
2. Csomagoljuk ki a ZIP-fájlt.
3. Nyissuk meg az `AllatOrokbefogadas.sln` fájlt Visual Studióban.
4. A Solution Explorerben a solutionre jobb gombbal kattintva válasszuk a **Configure Startup Projects** lehetőséget.
5. Állítsuk be, hogy az `AllatOrokbefogadas.API` és az `AllatKliens` projekt is elinduljon.
6. Indítsuk el a programot az **F5** billentyűvel.

Fontos, hogy a szerver is fusson, különben a kliens nem tudja lekérni a találatokat.

### Lehetséges indítási hiba

A GitHubról letöltött projekt első indításakor előfordulhat **MSB3821 hiba**, mert a Windows blokkolja valamelyik `.resx` fájlt.

Nálam is jelentkezett ez a probléma, amit a következő módon sikerült megoldani:

1. Az `AllatKliens` mappában megkerestem a `Form1.resx` fájlt.
2. Jobb klikk → **Tulajdonságok**.
3. Az **Általános** fülön bejelöltem a **Feloldás** lehetőséget.
4. Visual Studióban a **Build → Rebuild Solution** menüponttal újrafordítottam a projektet.

Ezután a program megfelelően elindult.

## Tesztelés

Az adatbázisban szereplő állatok több dél-dunántúli és környékbeli településhez tartoznak.

A keresést például az alábbi településekkel érdemes kipróbálni:

1. Mohács
2. Pécs
3. Baja
4. Szekszárd
5. Siklós
6. Bóly
7. Kaposvár
8. Bonyhád
9. Paks

Első keresésnél érdemes például **Mohácsot vagy Pécset** megadni, 100 km-es távolsággal.

A keresési feltételek módosításával megfigyelhető, hogyan változnak a találatok és a megfelelőségi pontszámok.

A programban szereplő állatok tesztadatok, nem valódi örökbefogadási hirdetések.

## A projekt felépítése

- `AllatKliens` – Windows Forms kliensalkalmazás
- `AllatOrokbefogadas.API` – szerveroldali alkalmazás, adatbázis és ajánlási algoritmus
- `kepek` – az alkalmazáshoz tartozó képek
- `AllatOrokbefogadas.sln` – Visual Studio solution

## Dokumentáció

A részletes dokumentáció a GitHubra feltöltött PDF-fájlban található.
