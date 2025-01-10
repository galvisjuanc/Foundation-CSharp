// See https://aka.ms/new-console-template for more information

using POO1WITHDOTNET.Models;

SuperHeroeRecord superHeroeRecord = new(1, "Superman", "Clark Kent");
SuperHeroeRecord superHeroeRecord2 = new(1, "Superman", "Clark Kent");

Console.WriteLine(superHeroeRecord == superHeroeRecord2);

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelUno;

var wolverine = new AntiHeroe();
wolverine.Id = 5;

public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta);