// See https://aka.ms/new-console-template for more information

var animales = new List<Animal>();
animales.Add(new Animal() { Nombre = "Hormiga", Color = "Rojo" });
animales.Add(new Animal() { Nombre = "Lobo", Color = "Gris" });
animales.Add(new Animal() { Nombre = "Elefante", Color = "Gris" });
animales.Add(new Animal() { Nombre = "Pantegra", Color = "Negro" });
animales.Add(new Animal() { Nombre = "Gato", Color = "Negro" });
animales.Add(new Animal() { Nombre = "Iguana", Color = "Verde" });
animales.Add(new Animal() { Nombre = "Orangutan", Color = "Verde" });
animales.Add(new Animal() { Nombre = "Sardina", Color = "Azul" });
animales.Add(new Animal() { Nombre = "Caiman", Color = "Amarillo" });
animales.Add(new Animal() { Nombre = "Sapo", Color = "Verde" });
animales.Add(new Animal() { Nombre = "Camaleon", Color = "Verde" });
animales.Add(new Animal() { Nombre = "Gallina", Color = "Blanco" });

List<char> vocales = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

List<Animal> result = animales.Where(x => x.Color.ToLower().Equals("verde") && vocales.Contains(x.Nombre.ToLower()[0]))
    .ToList();

if(result.Any())
    result.ForEach(x => Console.WriteLine(x.Nombre));

Console.WriteLine("--Segundo metodo--");

animales = (from animal in animales
    where animal.Color == "Verde" && "AEIOUaeiou".Contains(animal.Nombre[0])
    select animal).ToList();

foreach (var animal in animales)
{
    Console.WriteLine($"Nombre: {animal.Nombre}, Color: {animal.Color}");
}

Console.WriteLine("--Tercer metodo--");
IEnumerable<Animal> greenAnimalsWithVowelNameStart = animales.Where(animal => animal.Color == "Verde" && "AEIOUaeiou".Contains(animal.Nombre[0])).AsEnumerable();

if (greenAnimalsWithVowelNameStart.Any())
    foreach (var animal in greenAnimalsWithVowelNameStart)
        Console.WriteLine($"Nombre: {animal.Nombre}, Color: {animal.Color}");

public class Animal
{
    public string Nombre { get; set; }
    public string Color { get; set; }
}