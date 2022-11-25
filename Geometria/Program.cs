// See https://aka.ms/new-console-template for more information


//Nel progetto csharp-geometria creare le seguenti classi :
//Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
//Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di base e di altezza con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, occupatevi di configurare le sue proprietà di base e altezza (come abbiamo fatto con le nostre auto questa mattina nel programma principale) e stampate a video il perimetro e l’area.

using Geometria;

Console.WriteLine("inserisci la base del retangolo");
int baseRetangoloUtente = int.Parse(Console.ReadLine());   
Console.WriteLine("inserisci altezza del retangolo");
int altezzaRetangoloUtente = int.Parse(Console.ReadLine());

Rettangolo rettangoloUtente = new Rettangolo();
rettangoloUtente.altezzaRettangolo = altezzaRetangoloUtente;
rettangoloUtente.baseRettangolo = baseRetangoloUtente;

int ariaRettangoloUtente = rettangoloUtente.CalcolaArea();
int perimetroRettangoloUtente = rettangoloUtente.CalcolaPerimento();

//stampare a video i risultati
Console.WriteLine(@$"questo è l'area del retangolo creato dall'utente : {ariaRettangoloUtente} 
questo è invece il perimetro del retangolo creato dall'utente : {perimetroRettangoloUtente}
");




//Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:
//—— Rettangolo1 ——
//base: 20 cm
//altezza: 10 cm
//Perimetro: 60 cm
//Area: 200 cm2

Rettangolo rettangolo1 = new Rettangolo();
Rettangolo rettangolo2 = new Rettangolo();
Rettangolo rettangolo3 = new Rettangolo();
Rettangolo rettangolo4 = new Rettangolo();
Rettangolo rettangolo5 = new Rettangolo();

rettangolo1.baseRettangolo = 1;
rettangolo2.baseRettangolo = 2;
rettangolo3.baseRettangolo = 3;
rettangolo4.baseRettangolo = 4;
rettangolo5.baseRettangolo = 5;

rettangolo1.altezzaRettangolo = 1;
rettangolo2.altezzaRettangolo = 2;
rettangolo3.altezzaRettangolo = 3;
rettangolo4.altezzaRettangolo = 4;
rettangolo5.altezzaRettangolo = 5;

rettangolo1.StampaRetangolo("rettangolo1");
rettangolo2.StampaRetangolo("rettangolo2");
rettangolo3.StampaRetangolo("rettangolo3");
rettangolo4.StampaRetangolo("rettangolo4");
rettangolo5.StampaRetangolo("rettangolo5");








