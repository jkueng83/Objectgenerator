using Cage.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Objektgenerator.Classes
{
    class ObjectgeneratorTest
    {

        public T GetNewObject<T>() where T : new()
        {
            // T t = new T();
            return new T();
        }

        public List<T> GetNewObjects<T>(int amountOfObjekts) where T : new()
        {
            List <T> objects = new List<T>();

           
            for (int i = 0; i < amountOfObjekts; i++)
            {
                

               // objects.Add(new T());


                objects.Add(GetNewObject<T>());
            }

            return objects;

        }

        public T GetNewObjectAnimal<T>() where T : Animal , new()
        {
            // hier können nur Animal und alle Klassen die davon erben erzeugt werden. 
            return new T();
        }

        public List<T> GetAnimalsWithName<T>(object[] names) where T : Animal
        {
            List<T> animals = new List<T>();
            foreach (var name in names)
            {
                animals. Add( (T)Activator.CreateInstance(typeof(T), name));
            }

            return animals;
        }




    }
}
