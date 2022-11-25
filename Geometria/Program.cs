﻿// See https://aka.ms/new-console-template for more information


//Nel progetto csharp-geometria creare le seguenti classi :
//Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
//Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di base e di altezza con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, occupatevi di configurare le sue proprietà di base e altezza (come abbiamo fatto con le nostre auto questa mattina nel programma principale) e stampate a video il perimetro e l’area.

using Geometria;

Console.WriteLine("inserisci la base del retangolo");
int baseRetangoloUtente = int.Parse(Console.ReadLine());   
Console.WriteLine("inserisci altezza del retangolo");
int altezzaRetangoloUtente = int.Parse(Console.ReadLine());

Retangolo retangoloUtente = new Retangolo();
retangoloUtente.altezzaRettangolo = altezzaRetangoloUtente;
retangoloUtente.baseRettangolo = baseRetangoloUtente;

int ariaRetangoloUtente = retangoloUtente.CalcolaArea();
int perimetroRetangoloUtente = retangoloUtente.CalcolaPerimento();

//stampare a video i risultati
Console.WriteLine(@$"questo è l'area del retangolo creato dall'utente : {ariaRetangoloUtente} 
questo è invece il perimetro del retangolo creato dall'utente : {perimetroRetangoloUtente}
");




//Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:
//—— Rettangolo1 ——
//base: 20 cm
//altezza: 10 cm
//Perimetro: 60 cm
//Area: 200 cm2

Retangolo retangolo1 = new Retangolo();
Retangolo retangolo2 = new Retangolo();
Retangolo retangolo3 = new Retangolo();
Retangolo retangolo4 = new Retangolo();
Retangolo retangolo5 = new Retangolo();

retangolo1.baseRettangolo = 1;
retangolo2.baseRettangolo = 2;
retangolo3.baseRettangolo = 3;
retangolo4.baseRettangolo = 4;
retangolo5.baseRettangolo = 5;

retangolo1.altezzaRettangolo = 1;
retangolo2.altezzaRettangolo = 2;
retangolo3.altezzaRettangolo = 3;
retangolo4.altezzaRettangolo = 4;
retangolo5.altezzaRettangolo = 5;

retangolo1.StampaRetangolo("retangolo1");
retangolo2.StampaRetangolo("retangolo2");
retangolo3.StampaRetangolo("retangolo3");
retangolo4.StampaRetangolo("retangolo4");
retangolo5.StampaRetangolo("retangolo5");








