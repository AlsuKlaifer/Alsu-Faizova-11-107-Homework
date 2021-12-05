// See https://aka.ms/new-console-template for more information
using Homework.Christmas;

var garland = new Garland(5, 2, 2, true);
var toy = new Toy(50, true, 1, false);

var tree = new ChristmasTree("Елка", 200, 6, 2);
var showcase = new Showcase("Витрина", 10, 4);

showcase.Decorating(garland, toy);
tree.Decorating(garland, toy);