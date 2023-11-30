using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Create instances of Person representing family members
        var paternalGrandfather = new Person("Paternal Huttu", 98);
        var paternalGrandmother = new Person("Paternal HolaAba", 91);

        var maternalGrandfather = new Person("Maternal Huttu", 96);
        var maternalGrandmother = new Person("Maternal Hanesh", 90);

        var father = new Person("Atta", 60);
        var mother = new Person("Aba", 55);

        father.AddSpouse(mother);
        mother.AddSpouse(father);

        var son = new Person("Samuel", 25);
        var daughter = new Person("Emily", 22);

        // Establishing family relationships
        paternalGrandfather.AddChild(father);
        paternalGrandmother.AddChild(father);

        maternalGrandfather.AddChild(mother);
        maternalGrandmother.AddChild(mother);

        father.AddChild(son);
        father.AddChild(daughter);

        mother.AddChild(son);
        mother.AddChild(daughter);

        // Adding siblings
        var uncle = new Person("Azzi", 45);
        father.AddSibling(uncle);

        var aunt = new Person("Abuzi", 38);
        mother.AddSibling(aunt);

        paternalGrandfather.AddChild(uncle);
        paternalGrandmother.AddChild(uncle);

        maternalGrandfather.AddChild(aunt);
        maternalGrandmother.AddChild(aunt);


        var meinBrother = new Person("Kamal", 30);
        father.AddChild(meinBrother);
        mother.AddChild(meinBrother);
        son.AddSibling(meinBrother);

        var meinCousein = new Person("Rustam", 31);
        uncle.AddChild(meinCousein);

        // Display family tree
        father.DisplayFamilyTree();
        mother.DisplayFamilyTree();
        uncle.DisplayFamilyTree();
    }
}