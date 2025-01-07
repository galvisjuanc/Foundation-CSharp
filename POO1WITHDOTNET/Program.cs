// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

SuperHeroeRecord superHeroeRecord = new(1, "Superman", "Clark Kent");
SuperHeroeRecord superHeroeRecord2 = new(1, "Superman", "Clark Kent");

Console.WriteLine(superHeroeRecord == superHeroeRecord2);


public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta);
