using System;
using static System.Console;

namespace _08.Patron.Creacional.Prototype.DeepCopy
{
    // interface IPrototype<T>
    // {
    //     T DeepCopy();
    // }

    [Serializable]
    public class Category //: IPrototype<Category>
    {
        public string Name { get; set; }
        public Category(string name) => Name = name;

        // public Category DeepCopy()
        // {
        //     return new Category(Name);
        // }
    }

    [Serializable]
    public class Product //: IPrototype<Product>
    {
        public string Name { get; set; }
        public Category Category { get; set; }

        public Product(string name, Category category)
        {
            Name = name;
            Category = category;
        }

        public override string ToString()
        {
            return $"Producto: {Name}, Categoría: {Category.Name}";
        }

        // public Product DeepCopy()
        // {
        //     return new Product(Name, Category.DeepCopy());
        // }
    }
    class Client
    {
        public void Main()
        {
            var notebook1 = new Product("MacBook Pro", new Category("Computers"));

            var dell = notebook1.DeepCopy();
            dell.Category.Name = "Notebooks";
            dell.Name = "Dell";
            WriteLine(notebook1);
            WriteLine(dell);
            ReadLine();
        }
    }
}
