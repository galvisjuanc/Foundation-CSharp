var animales = new List<Animal>
{
    new Animal() { Name = "Hormiga", Color = "Rojo" },
    new Animal() { Name = "Lobo", Color = "Gris" },
    new Animal() { Name = "Elefante", Color = "Gris" },
    new Animal() { Name = "Pantegra", Color = "Negro" },
    new Animal() { Name = "Gato", Color = "Negro" },
    new Animal() { Name = "Iguana", Color = "Verde" },
    new Animal() { Name = "Orangutan", Color = "Verde" },
    new Animal() { Name = "Sardina", Color = "Azul" },
    new Animal() { Name = "Caiman", Color = "Amarillo" },
    new Animal() { Name = "Sapo", Color = "Verde" },
    new Animal() { Name = "Camaleon", Color = "Verde" },
    new Animal() { Name = "Gallina", Color = "Blanco" }
};

var animalesOrdenados = animales;

var vocales = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

var result = animales.Where(x => x.Color.ToLower().Equals("verde") && vocales.Contains(x.Name.ToLower()[0]))
    .ToList();

result.ForEach(x => Console.WriteLine(x.Name));

Console.WriteLine("--Segundo metodo--");
animales = (from animal in animales
    where animal.Color == "Verde" && "AEIOUaeiou".Contains(animal.Name[0])
    select animal).ToList();

foreach (var animal in animales)
{
    Console.WriteLine($"Name: {animal.Name}, Color: {animal.Color}");
}

Console.WriteLine("--Tercer metodo--");
IEnumerable<Animal> greenAnimalsWithVowelNameStart = animales.Where(animal => animal.Color == "Verde" && "AEIOUaeiou".Contains(animal.Name[0])).AsEnumerable();

if (greenAnimalsWithVowelNameStart.Any())
    foreach (var animal in greenAnimalsWithVowelNameStart)
        Console.WriteLine($"Name: {animal.Name}, Color: {animal.Color}");

Console.WriteLine("--Cuarto metodo--");
var listAnimalsOrderByName = animalesOrdenados.OrderBy(p => p.Name);
foreach (var animal in listAnimalsOrderByName)
{
    Console.WriteLine($"Name: {animal.Name}, Color: {animal.Color}");
}

public class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }
}