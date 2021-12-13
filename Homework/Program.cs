// See https://aka.ms/new-console-template for more information
using Homework.Christmas;
using Homework.Extension;

//ICloneable
var c1 = new ComplexNumber(1, -32);
var c2 = (ComplexNumber)c1.Clone();
Console.WriteLine(c2.Print());


//IComparable
//var r1 = new RationalFraction(1, 3);
//var r2 = new RationalFraction(2, 5);
//r1.CompareTo(r2); //к сожалению, Array.Sort() не получилось реализовать:((

//StringExtension
//string s = "яблоко банан апельсин мандарин";
//Console.WriteLine(s.OneByOneJoin("купить съесть убрать"));

// Christmas
//var garland = new Garland(5, 2, 2, true);
//var toy = new Toy(50, true, 1, false);

//var tree = new ChristmasTree("Елка", 200, 6, 2);
//var showcase = new Showcase("Витрина", 10, 4);

//showcase.Decorating(garland, toy);
//tree.Decorating(garland, toy);