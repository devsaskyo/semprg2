using System;

namespace InheritanceApparently
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void SayHello()
        {
            Console.WriteLine("Hello, I am " + Name + ".");
        }
    }
    class Student : Person
    {
        public int Grade { get; set; }
        public Student(string name, int grade) : base(name)
        {
            Grade = grade;
        }
        public override void SayHello()
        {
            Console.WriteLine("Hello, I am " + Name + " and I am in grade " + Grade + ".");
        }
    }

    class Program
    {
        static void Main()
        {
            Person person = new Person("Jan");
            person.SayHello();


            Student student = new Student("Petr", 3);
            student.SayHello();
        }
    }
}
