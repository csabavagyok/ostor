# ostor
Elements of the OSTOR system
Hungarian National Ambulance Service
National On-line Scheduling and Planning System (OSTOR)
=======================================================
Az OSTOR rendszer elemei
Országos Mentőszolgálat
Országos Szolgálattervezési On-line Rendszer (OSTOR)
=======================================================
"Jelenléti napló" app /pre-alpha/
  Windows Forms alkalmazás. A jelenléti naplóhoz hasonló formában bekéri a teljesített órákat, kiszámolja a napi végzett óraszámokat, valamint összesíti is őket. Használható a munkaóra elszámolás mezőinek kitöltéséhez, a jelenléti napló utó-ellenőrzéséhez.
---------------------------------
"Jelenléti konzol" app /beta/
  Konzol alkalmazás. A hónap adatai és a jelenléti naplóba írt szolgálati adatok alapján összesíti a szabadság, betegség órákat, a teljesített óraszámot, műszakpótlékokat, túlórákat. Használható a munkaóra elszámolás mezőinek kitöltéséhez, a jelenléti napló utó-ellenőrzéséhez.
---------------------------------
"Munkaóra számoló" app /final/ v1.1
  Windows Forms alkalmazás. Az év-hónap adatai alapján automatikusan kijelzi a havi kötelező óraszámot, esetleges kollektív ünnepeket. A dolgozó megadásával automatikusan közli a munkaviszony alapján, hogy a dolgozónak a hónapban mennyi munkaórát kell teljesítenie. A szolgálatok adatainak (melyik, db) megadásával és a "lekocsizott" túlóra adatok megadásával automatikusan teljesített órát, műszakpótlékokat számol. Megadható hó eleji és végi átvitt/áthozott óra is. Megadható tanfolyami 12 óra is. Megadható túlórában elszámolt mozgóőrség is. Megadható a kiadott szabadság, betegállomány is. Számolj! gombra valamennyi, a munkaóra elszámolás kitöltéséhez szükséges mező száma kijelződik. A Törlés gomb az éven és hónapon kívül az összes adatot nullázza.
---------------------------------
"Munkaóra elszámolás" app /final/
  A kitöltött munkaóra elszámolás ellenőrzésére szolgál. Listából választható a szerződés szerinti óraszám. Megadható a teljesített óra (jelenléti napló alapján). Megadható a beteg és szabadság napok is. A beteg és szabadság napok időértéke a szerződés szerinti óraszámnál választott alapján automatikusan kalkulálódik. Megadható tanfolyami 12 óra. Megadható a 200%-ban elszámolt óra mértéke is. A Számolj! gomb megnyomásával kijelzi a túlóra alapot és a túlórát. A Nulláz gomb minden értéket alaphelyzetbe állít.
---------------------------------
"Excel fájlíró" app /planned/
  Részegység lenne. A cél, hogy a Munkaóra számoló app a gomb megnyomása után az értékeket automatikusan az adott havi munkaóra elszámolás adott (dolgozói) mezőibe beillessze. Esetleg korábbi hónapok esetén onnan kiolvassa. Továbbá a műszaki jelentés app részét is képezné.
---------------------------------
"Műszaki jelentés" app /planned/
  Fontos része lenne az excel fájlíró. Autók létrehozása. Az eddigi tankolási adatok automatikus betöltése. Új tankolási adatok mentése. Motorolaj utántöltés információk olvasása és mentése.
=================================
