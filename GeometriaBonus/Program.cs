// See https://aka.ms/new-console-template for more information

// BONUS: Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni, ossia tanti “—” (due trattini) orizzontali quanto è grande la sua base e tanti ‘|’ verticali quanto e grande la sua altezza.

using GeometriaBonus; 

Rettangolo rettangolo1 = new Rettangolo();
Rettangolo rettangolo2 = new Rettangolo();
Rettangolo rettangolo3 = new Rettangolo();
Rettangolo rettangolo4 = new Rettangolo();
Rettangolo rettangolo5 = new Rettangolo();

rettangolo1.baseRettangolo = 10;
rettangolo2.baseRettangolo = 10;
rettangolo3.baseRettangolo = 10;
rettangolo4.baseRettangolo = 10;
rettangolo5.baseRettangolo = 10;

rettangolo1.altezzaRettangolo = 1;
rettangolo2.altezzaRettangolo = 2;
rettangolo3.altezzaRettangolo = 3;
rettangolo4.altezzaRettangolo = 4;
rettangolo5.altezzaRettangolo = 5;

rettangolo1.Disegna();
rettangolo2.Disegna();
rettangolo3.Disegna();
rettangolo4.Disegna();
rettangolo5.Disegna();