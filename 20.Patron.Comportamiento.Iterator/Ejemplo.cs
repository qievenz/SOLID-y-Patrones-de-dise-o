using System;
using System.Collections.Generic;

namespace _20.Patron.Comportamiento.Iterator.Ejemplo
{
    public class Menu
    {
        public Menu(string name, string description, int price, bool isVegetarian)
        {
            Name = name;
            Description = description;
            Price = price;
            IsVegetarian = isVegetarian;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Price { get; private set; }
        public bool IsVegetarian { get; private set; }
    }

    public interface IIterator<T> //IEnumerator<T>
    {
        bool HasNext();
        T Next();
    }

    public class DinnerIterator : IIterator<Menu>
    {
        Menu[] items;
        int position = 0;

        public DinnerIterator(Menu[] items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            return position < items.Length && items[position] != null;
        }

        public Menu Next()
        {
            var menu = items[position];
            position++;
            return menu;
        }
    }

    public class BreakfastIterator : IIterator<Menu>
    {
        List<Menu> items;
        int position = 0;

        public BreakfastIterator(List<Menu> items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            return position < items.Count && items[position] != null;
        }

        public Menu Next()
        {
            var menu = items[position];
            position++;
            return menu;
        }
    }

    public class BreakfastMenuCollection
    {
        private List<Menu> _menuItems;

        public BreakfastMenuCollection()
        {
            _menuItems = new List<Menu>();
            AddItem("Desayuno 1", "Panqueques", 1200, false);
            AddItem("Desayuno 2", "Sandwich y cafe", 700, false);
            AddItem("Desayuno 3", "cafe cortado", 200, true);
        }

        public void AddItem(string name, string description, int price, bool isVegetarian)
        {
            var menuItem = new Menu(name, description, price, isVegetarian);
            _menuItems.Add(menuItem);
        }

        public IIterator<Menu> CreateIterator() => new BreakfastIterator(_menuItems);
    }

    public class DinnerMenuCollection
    {
        private Menu[] _menuItems;
        private int _maxItems = 3;
        private int _numberOfItems;

        public DinnerMenuCollection()
        {
            _menuItems = new Menu[_maxItems];

            AddItem("Vegatiariano simple", "Hipocalorico + Jugo", 500, true);
            AddItem("Caribean Sushi", "10 hot rolls, 15 kanikama", 800, false);
            AddItem("Pizza familiar", "Pizza 3 ingredientes a elección", 800, false);

        }

        public void AddItem(string name, string description, int price, bool isVegatarian)
        {
            Menu menuItem = new Menu(name, description, price, isVegatarian);

            if (_numberOfItems > _maxItems)
            {
                Console.WriteLine("El menu está full");
            }
            else
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }

        public IIterator<Menu> CreateIterator() => new DinnerIterator(_menuItems);
    }
}
