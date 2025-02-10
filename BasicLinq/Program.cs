// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine("Hello, World!");

var frutas = new string[] { "Manzana", "Pera", "Naranja", "Mango", "Mango de azucar", "Mango Tomy" };

var MangoList = frutas.Where(p => p.StartsWith("Mango")).ToList();

MangoList.ForEach(p => Console.WriteLine(p));