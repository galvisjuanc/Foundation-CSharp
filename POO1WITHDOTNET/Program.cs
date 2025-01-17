// See https://aka.ms/new-console-template for more information

using POO1WITHDOTNET;
using POO1WITHDOTNET.Models;

SuperHeroeRecord superHeroeRecord = new(1, "Superman", "Clark Kent");
SuperHeroeRecord superHeroeRecord2 = new(1, "Superman", "Clark Kent");

Console.WriteLine(superHeroeRecord == superHeroeRecord2);

var imprimirinfo = new ImprimirInfo();

var poderVolar = new SuperPoder
{
    Nombre = "Volar",
    Descripcion = "Capacidad para volar y planear en el aire.",
    Nivel = NivelPoder.NivelUno
};

var superFuerza = new SuperPoder();
superFuerza.Nombre = "SuperFuerza";
superFuerza.Descripcion = "Extremadamente fuerte. Destroza absolutamente todo.";
superFuerza.Nivel = NivelPoder.NivelDos;

var regeneracion = new SuperPoder
{
    Nombre = "Regeneracion",
    Descripcion = "Recuperar el cuerpo",
    Nivel = NivelPoder.NivelTres
};

var superman = new SuperHeroe
{
    Id = 1,
    Nombre = "Superman",
    IdentidadSecreta = "Clark Kent",
    PuedeVolar = true
};

var wolverine = new AntiHeroe
{
    Id = 5,
    Nombre = "Wolverine",
    IdentidadSecreta = "Logan",
    PuedeVolar = false
};

imprimirinfo.ImprimirSuperHeroe(superman);
imprimirinfo.ImprimirSuperHeroe(wolverine);

List<SuperPoder> poderesWolverine = new()
{
    superFuerza,
    regeneracion
};
wolverine.SuperPoderes = poderesWolverine;
string resultSuperPoderes = wolverine.UsarPoderesSuper();
Console.WriteLine(resultSuperPoderes);

string accionAntiHeroe = wolverine.RealizarAccionDeAntiHeroe("Ataca la policia sin vergüenza alguna");
Console.WriteLine(accionAntiHeroe);

string resultGeneric = wolverine.salvarElMundo();
Console.WriteLine(resultGeneric);

string resultNonAbstract = wolverine.SalvarLaTierra();
Console.WriteLine(resultNonAbstract);

public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta);