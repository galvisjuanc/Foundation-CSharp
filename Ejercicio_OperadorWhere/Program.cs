// See https://aka.ms/new-console-template for more information
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
// filtra todos los animales que sean de color verde que su nombre inicie con una vocal

List<char> vocales = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

List<Animal> result = animales.Where(x => x.Color.ToLower().Equals("verde") && vocales.Contains(x.Nombre.ToLower()[0]))
    .ToList();

if(result.Any())
    result.ForEach(x => Console.WriteLine(x.Nombre));

public class Animal
{
    public string Nombre { get; set; }
    public string Color { get; set; }
}