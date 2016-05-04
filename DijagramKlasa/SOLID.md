**1.Princip pojedina�ne odgovornosti**  
Sve klase osim klase 'Osoba' imaju pojedina�ne odgovornosti, te sve klase osim klase 'Osoba'
zadovoljavaju princip pojedina�ne odgovornosti, dok klasu 'Osoba' treba podijeliti na korespodentne klase
koje �e se baviti svaka jednom od stvari koje su vezane za ovu klasu.

**2.Otvoreno zatvoren princip**  
Zadovoljavanje ovog principa se ogleda u formiranju sistema za verifikaciju pravilnosti promjena kriti�nih
dijelova programa, �to bi u na�em slu�aju predstavljala baza podatak, ili bilo koja klasa koja �uva skup informacija
od drugim klasama, pa je za svaku od klasa koja pravi izmjene u nekom dijelu programa, potrebno implementirati
sistem verifikacije pravilnosti promjena koje pravimo.

**3.Liskov princip zamjene**  
Liskov princip zamjene je zadovoljen jer ni u jednoj klasi nema poziva funkcije koje bismo mogli smatrati nelegalni,
odnosno takvim da njihovo pozivanje u odre�enom trenutku ne predstavlja vezu s mozgom korisnika.

**4.Princip inverzije ovisnosti**  
Klase sistema ne ovise od neke apstraktne nego od konkretne klase, a obzirom da sve na�e klase ovise od klase 'Osoba'
koja sigurno ne�e imati velikih ni �estih promjena u budu�nosti, jer se u stvarnosti osoba i ono �to �ini osobu
ne mijenja, te je dovoljno da klasu 'Osoba' postavimo za apstraktnu klasu, �ime �emo zadovoljiti 'Princip inverzije 
ovisnosti'.

**5.Princip izoliranja interfejsa**  
Iz klasa na�eg programa je potrebno kreirati interfejs koji �e sadr�avati metode koje standardni korisnik koristi 
'svakodnevno', kako ne bi ovisio od metoda koje ne koristi i promjena na njima. Npr. Iz klase 'Osoba' je dovoljno
kreirati interfejs za metode 'getIme() : string', 'setIme(Ime : string) : void', 'getPrezime() : string', 
'setPrezime(Prezime : string) : void', 'setDatumRodjenja(datumRodjenja : date) : void', 'setJMBG(JMBG : string) : void', 
'setBrojLicneKarte(brojLicneKarte : string) : void' i 'setAdresaStanovanja(adresaStanovanja : string) : void', 
jer standardni korisnik nema potrebu za metodama poput 'getJMBG() : string' ili 'setBrojLicne(Ime : string)'.