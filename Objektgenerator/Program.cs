using Cage.Classes;
using Objektgenerator.Classes;
using System;
using System.Collections.Generic;

namespace Objektgenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe Objektgenerator");
            /*
             Aufgabe Objektgenerator
                Wir erstellen Klassen nach Wahl (z.B. Car, Beer, Monkey, ...) - wichtig der Konstruktor sollte Parameterlos sein - und erstellen eine Klasse ObjectGenerator welche folgende Methoden besitzt:
                public T GetNewObject<T>()
                public List<T> GetNewObjects<T>(int amountOfObjects)
                Die Methoden haben ein where Constraint (https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters) welcher "new()" definiert, das schränkt die zu erzeugenden Objekte auf solche ein, welche einen Parameterlosen Konstruktor besitzen.
                Zusatz: wer auch Objekte generisch erstellen können möchte mit Parametern im Konstruktor kann das diesem StackOverflow Artikel entnehmen.
             */

            

            ObjectgeneratorTest og = new ObjectgeneratorTest();

            var car = og.GetNewObject<Car>();

            var cars = og.GetNewObjects<Car>(7);

            var tiger = og.GetNewObject<Tiger>();
            var tigers = og.GetNewObjects<Tiger>(17);

            var monkeys = og.GetNewObjects<Monkey>(5);


            var monkey = og.GetNewObjectAnimal<Monkey>(); // Car geht nicht, da es nicht von Animal erbt. Tiger und Monkey sind möglich

            var tigersWithName = og.GetAnimalsWithName<Tiger>( new object[] { "Johannes", "Emma", "Helga", "Lukas"});

            Console.ReadLine();
                        
        }
    }
}
