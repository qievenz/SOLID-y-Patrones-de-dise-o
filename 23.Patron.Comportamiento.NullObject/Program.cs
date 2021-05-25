using System;
using _23.Patron.Comportamiento.NullObject.Ejemplo;

namespace _23.Patron.Comportamiento.NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            EjecutarEjemplo();
        }

        private static void EjecutarEjemplo()
        {
            var studentOrder = new Order(new StudentDiscount(), 50);
            studentOrder.GetDiscount();
            var friendOrder = new Order(new FriendDiscount(), 30);
            studentOrder.GetDiscount();

            var noDiscountOrder = new Order(new NullDiscount(), 100);
            noDiscountOrder.GetDiscount();
        }
    }
}
