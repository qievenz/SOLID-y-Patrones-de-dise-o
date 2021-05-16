using System;

namespace _07.Patron.Creacional.Factory.Ejercicio
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static class Factory
        {
            private static int _id = 1;
            public static Student Create(string name)
            {
                var newStudent = new Student(_id++, name);

                Console.WriteLine($"Se creó el usuario {newStudent.Name} con id: {newStudent.Id}.");
                
                return newStudent;
            }
        }
    }
}