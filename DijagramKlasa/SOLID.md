**1.Princip pojedinaène odgovornosti**  
Sve klase osim klase 'Osoba' imaju pojedinaène odgovornosti, te sve klase osim klase 'Osoba'
zadovoljavaju princip pojedinaène odgovornosti, dok klasu 'Osoba' treba podijeliti na korespodentne klase
koje æe se baviti svaka jednom od stvari koje su vezane za ovu klasu.

**2.Otvoreno zatvoren princip**  
Zadovoljavanje ovog principa se ogleda u formiranju sistema za verifikaciju pravilnosti promjena kritiènih
dijelova programa, što bi u našem sluèaju predstavljala baza podatak, ili bilo koja klasa koja èuva skup informacija
od drugim klasama, pa je za svaku od klasa koja pravi izmjene u nekom dijelu programa, potrebno implementirati
sistem verifikacije pravilnosti promjena koje pravimo.

**3.Liskov princip zamjene**  
Liskov princip zamjene je zadovoljen jer ni u jednoj klasi nema poziva funkcije koje bismo mogli smatrati nelegalni,
odnosno takvim da njihovo pozivanje u odreðenom trenutku ne predstavlja vezu s mozgom korisnika.

**4.Princip inverzije ovisnosti**  
Klase sistema ne ovise od neke apstraktne nego od konkretne klase, a obzirom da sve naše klase ovise od klase 'Osoba'
koja sigurno neæe imati velikih ni èestih promjena u buduænosti, jer se u stvarnosti osoba i ono što èini osobu
ne mijenja, te je dovoljno da klasu 'Osoba' postavimo za apstraktnu klasu, èime æemo zadovoljiti 'Princip inverzije 
ovisnosti'.

**5.Princip izoliranja interfejsa**  
Iz klasa našeg programa je potrebno kreirati interfejs koji æe sadržavati metode koje standardni korisnik koristi 
'svakodnevno', kako ne bi ovisio od metoda koje ne koristi i promjena na njima. Npr. Iz klase 'Osoba' je dovoljno
kreirati interfejs za metode 'getIme() : string', 'setIme(Ime : string) : void', 'getPrezime() : string', 
'setPrezime(Prezime : string) : void', 'setDatumRodjenja(datumRodjenja : date) : void', 'setJMBG(JMBG : string) : void', 
'setBrojLicneKarte(brojLicneKarte : string) : void' i 'setAdresaStanovanja(adresaStanovanja : string) : void', 
jer standardni korisnik nema potrebu za metodama poput 'getJMBG() : string' ili 'setBrojLicne(Ime : string)'.