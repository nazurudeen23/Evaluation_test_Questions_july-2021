using System;

namespace PrintMethod
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
       public void print()
        {
            Console.WriteLine("person name is " + Name+" person age is " + Age);
        }
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("Leopold", 6);

            person1.print();


            Person person2 = new Person("David",16);
            

            Console.WriteLine("person2 Name = {0} Age = {1}", person2.Name, person2.Age);
            
        }
    }
}


/*
    Output:
    person1 Name = Leopold Age = 6
    person2 Name = Molly Age = 16
    person1 Name = Molly Age = 16
*/