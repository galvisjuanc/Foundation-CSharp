// See https://aka.ms/new-console-template for more information

using POO1WITHDOTNET.Models;

SuperHeroeRecord superHeroeRecord = new(1, "Superman", "Clark Kent");
SuperHeroeRecord superHeroeRecord2 = new(1, "Superman", "Clark Kent");

Console.WriteLine(superHeroeRecord == superHeroeRecord2);

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelUno;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneracion";
regeneracion.Descripcion = "Habilidad para no sufrir daños permanentes";
regeneracion.Nivel = NivelPoder.NivelTres;

var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;




public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta);