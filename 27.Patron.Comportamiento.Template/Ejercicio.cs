using System;
using System.Collections.Generic;
namespace Coding.Exercise
{
    public abstract class Order
    {
        public abstract string SelectProduct();

        public abstract string Pay();

        public abstract string Delivery();

        public List<string> ProcessOrder()
        {
            var result = new List<string>();
            result.Add(SelectProduct());
            result.Add(Pay());
            result.Add(Delivery());

            return result;
        }

    }

    public class OnlineProduct : Order
    {
        public override string Delivery()
        {
            return "producto despachado a cliente";
        }

        public override string Pay()
        {
            return "producto pagado por paypal";
        }

        public override string SelectProduct()
        {
            return "producto seleccionado en tienda virtual";
        }
    }

    public class StoreProduct : Order
    {
        public override string Delivery()
        {
            return "producto despachado a cliente";
        }

        public override string Pay()
        {
            return "producto pagado por pos";
        }

        public override string SelectProduct()
        {
            return "producto seleccionado en tienda";
        }
    }
}
