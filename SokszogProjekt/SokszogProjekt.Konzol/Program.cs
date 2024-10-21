// See https://aka.ms/new-console-template for more information
using SokszogProjekt.Megosztas.Models;

Console.WriteLine("Hello, World!");

Negyzet negyzet = new Negyzet(2);
Teglalap teglalap = new Teglalap(2, 3);
Haromszog haromszog = new Haromszog(2, 3,4);

Console.WriteLine(negyzet.Terulet());
Console.WriteLine(negyzet.Kerulet());

Console.WriteLine(teglalap.Terulet());
Console.WriteLine(teglalap.Kerulet());

Console.WriteLine(haromszog.Terulet());
Console.WriteLine(haromszog.Kerulet());
