// See https://aka.ms/new-console-template for more information

using POO1WITHDOTNET.Models;

SuperHeroeRecord superHeroeRecord = new(1, "Superman", "Clark Kent");
SuperHeroeRecord superHeroeRecord2 = new(1, "Superman", "Clark Kent");

Console.WriteLine(superHeroeRecord == superHeroeRecord2);

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelUno;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "SuperFuerza";
superFuerza.Descripcion = "Extremadamente fuerte";
superFuerza.Nivel = NivelPoder.NivelDos;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneracion";
regeneracion.Descripcion = "Habilidad para no sufrir daños permanentes";
regeneracion.Nivel = NivelPoder.NivelTres;

var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(superFuerza);
poderesWolverine.Add(regeneracion);
wolverine.SuperPoderes = poderesWolverine;
string resultSuperPoderes = wolverine.UsarPoderesSuper();
Console.WriteLine(resultSuperPoderes);

string accionAntiHeroe = wolverine.RealizarAccionDeAntiHeroe("Ataca la policia");
Console.WriteLine(accionAntiHeroe);

string resultGeneric = wolverine.salvarElMundo();
Console.WriteLine(resultGeneric);

string resultNonAbstract = wolverine.SalvarLaTierra();
Console.WriteLine(resultNonAbstract);

public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta);