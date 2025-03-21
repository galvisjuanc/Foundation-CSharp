﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Animal> animales = new List<Animal>();
animales.Add(new Animal() { Nombre = "Hormiga", Color = "Rojo" });
animales.Add(new Animal() { Nombre = "Lobo", Color = "Gris" });
animales.Add(new Animal() { Nombre = "Elefante", Color = "Gris" });
animales.Add(new Animal() { Nombre = "Pantegra", Color = "Negro" });
animales.Add(new Animal() { Nombre = "Gato", Color = "Negro" });
animales.Add(new Animal() { Nombre = "Iguana", Color = "Verde" });
animales.Add(new Animal() { Nombre = "Sapo", Color = "Verde" });
animales.Add(new Animal() { Nombre = "Camaleon", Color = "Verde" });
animales.Add(new Animal() { Nombre = "Gallina", Color = "Blanco" });

// Escribe tu código aquí
// Retorna los datos de la colleción Animales agrupada por color 
var animalsGroup = animales.GroupBy(p => p.Color);

foreach (var group in animalsGroup)
{
    Console.WriteLine("");
    Console.WriteLine($"Grupo: {group.Key}");
    Console.WriteLine("{0,-60}{1,15}", "Name", "Color");
    foreach (var item in group)
    {
        Console.WriteLine("{0,-60}{1,15}", item.Nombre, item.Color);
    }
}

public class Animal
{
    public string Nombre { get; set; }
    public string Color { get; set; }
}