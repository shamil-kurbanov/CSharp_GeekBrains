using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<Person> Siblings { get; } = new List<Person>();
    public Person Spouse { get; set; }
    public List<Person> Children { get; } = new List<Person>();
    public List<Person> Parents { get; } = new List<Person>();

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void AddSibling(Person sibling)
    {
        if (sibling != this && !Siblings.Contains(sibling))
        {
            Siblings.Add(sibling);
            sibling.Siblings.Add(this);
        }
    }

    public void AddSpouse(Person spouse)
    {
        Spouse = spouse;
        spouse.Spouse = this;
    }

    public void AddChild(Person child)
    {
        Children.Add(child);
        child.Parents.Add(this);
    }

    public void DisplayFamilyTree()
    {
        Console.WriteLine($"Family Tree for {Name}:");

        DisplaySiblings();
        DisplaySpouse();
        DisplayChildren();
        DisplayParents();
    }

    private void DisplaySiblings()
    {
        if (Siblings.Count > 0)
        {
            Console.WriteLine("- Siblings:");
            foreach (var sibling in Siblings)
            {
                Console.WriteLine($"  - {sibling.Name}");
            }
        }
    }

    private void DisplaySpouse()
    {
        if (Spouse != null)
        {
            Console.WriteLine($"- Spouse: {Spouse.Name}");
        }
    }

    private void DisplayChildren()
    {
        if (Children.Count > 0)
        {
            Console.WriteLine("- Children:");
            foreach (var child in Children)
            {
                Console.WriteLine($"  - {child.Name}");
            }
        }
    }

    private void DisplayParents()
    {
        if (Parents.Count > 0)
        {
            Console.WriteLine("- Parents:");
            foreach (var parent in Parents)
            {
                Console.WriteLine($"  - {parent.Name}");
            }
        }
    }
}