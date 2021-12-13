// See https://aka.ms/new-console-template for more information
using Homework.Christmas;
using Homework.Extension;

//ICloneable
//var c1 = new ComplexNumber(1, -32);
//var c2 = (ComplexNumber)c1.Clone();
//Console.WriteLine(c2.Print());


//IComparable
//var r1 = new RationalFraction(1, 3);
//var r2 = new RationalFraction(2, 5);
//r1.CompareTo(r2); //к сожалению, Array.Sort() не получилось реализовать:((

//StringExtension
//string s = "яблоко банан апельсин мандарин";
//Console.WriteLine(s.OneByOneJoin("купить съесть убрать"));

//Christmas
var g1 = new Garland(5, 2, 2, true);
var g2 = new Garland(5, 2, 3, true);
var g3 = new Garland(5, 2, 4, true);
var garlands = new Garland[] { g1, g2, g3 };
var t1 = new Toy(50, true, 1, false);
var t2 = new Toy(10, true, 1, false);
var t3 = new Toy(50, true, 2, false);
var toys = new Toy[] { t1, t2, t3 };

var tree = new ChristmasTree("Елка", 200, 6, 2);
var showcase = new Showcase("Витрина", 10, 4);

Decorate.Decorating(showcase, garlands, toys);
Decorate.Decorating(tree, garlands, toys);