# Állatörökbefogadást támogató ajánlórendszer 🐾

Szolgáltatás-orientált programozás – féléves beadandó

**Készítette:** Jenei Viola  
**Neptunkód:** GTDIOV

## A projekt bemutatása

Az alkalmazás célja, hogy segítsen megtalálni a felhasználó életmódjához és igényeihez leginkább illő örökbefogadható állatokat.

A felhasználó megadhatja:
- Kutyát vagy macskát keres
- Lakásban vagy kertes házban él
- Milyen aktivitású állatot szeretne
- Van-e már másik háziállata
- Melyik településen él
- Legfeljebb milyen távolságra keres állatot

A szerver a megadott feltételek alapján 0–100 közötti megfelelőségi pontszámot számít, majd sorrendbe állítja a találatokat.

Az alkalmazás jelenleg 24 tesztállat adataival működik.

## Felhasznált technológiák

- C# és Windows Forms – felhasználói felület
- ASP.NET Core Web API – szerver
- SQLite és Entity Framework Core – adatbázis
- REST API és JSON – kliens–szerver kommunikáció
- OpenStreetMap Nominatim – települések koordinátái
- Haversine-képlet – légvonalbeli távolságszámítás

## A program indítása

**Szükséges:** Visual Studio, a projektek által igényelt .NET SDK és internetkapcsolat a települések koordinátáinak lekéréséhez.

1. A GitHubról töltse le a projektet a **Code → Download ZIP** lehetőséggel.
2. Csomagolja ki a letöltött ZIP-fájlt.
3. Nyissa meg az `AllatOrokbefogadas.sln` fájlt Visual Studióban.
4. A Solution Explorerben kattintson jobb gombbal a solutionre, majd válassza a **Configure Startup Projects** lehetőséget.
5. Állítsa be, hogy az `AllatOrokbefogadas.API` és az `AllatKliens` projekt is elinduljon.
6. Indítsa el az alkalmazást az **F5** billentyűvel.

A szervernek futnia kell ahhoz, hogy a kliens meg tudja jeleníteni az ajánlásokat.

## A projekt felépítése

- `AllatKliens` – Windows Forms kliensalkalmazás
- `AllatOrokbefogadas.API` – szerver, adatbázis és ajánlási rendszer
- `kepek` – az alkalmazáshoz tartozó képek
- `AllatOrokbefogadas.sln` – Visual Studio solution

## Dokumentáció

A projekt részletes bemutatása a repositoryban található PDF-dokumentációban olvasható.
