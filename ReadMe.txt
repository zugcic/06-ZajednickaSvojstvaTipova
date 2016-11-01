ZajednickaSvojstvaTipova
========================

SystemObjekt
------------
Ilustrira kako se ponašaju implementacije metoda nasljeðenih 
izravno iz baznog System.Object tipa.


ToString
--------
Primjer gaženja (override) metode ToString


MetodaEquals
------------
Ilustrira razliku izmeðu statièke i nestatièke metode Equals.


MetodaEqualsZaReferentniTip
---------------------------
Primjer gaženja (override) metode Equals za referentni tip koji je
izveden izravno iz System.Object.
Klasa Osoba sadrži jedno polje referentnog tipa (string m_ime) i jedno
polje vrijednosnog tipa (int m_matièniBroj). Želimo definirati da su
dva objekta tipa Osoba jednaka ako imaju isto ime i isti matièni broj.
(Prekrili smo i metodu ToString da bismo dobili ljepši ispis).


MetodaEqualsZaIzvedeniReferentiTip
----------------------------------
Klasa Student je izvedena iz klase Osoba - njena metoda Equals mora
pozvati Equals bazne klase + napraviti usporedbu polja koja su specifièna
za izvedenu klasu.


MetodaEqualsZaVrijednosniTip
----------------------------
Primjer implementacije metode Equals za vrijednosni tip.


JednakostReferentnogTipa
------------------------
Primjer implementacije operatora == i != za referentni tip.


JednakostVrijednogTipa
----------------------
Primjer implementacije operatora == i != za vrijednosni tip.


GetHashCodeString
-----------------
Primjer što vraæa GetHashCode za sliène znakovne nizove.


GetHashCode
-----------
Primjer zašto je neophodno pregaziti metodu GetHashCode ako
se pregazi metoda Equals (i obrnuto).


Clone
-----
Primjer implementacije ICloneable suèelja.