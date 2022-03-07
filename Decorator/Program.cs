using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Bakery store = new Bakery();
            Console.Write("BEFORE DECORATE: ");
            Cake simpleCake = new Cake();
            store.MakeCake(new Cake());
            // trang tri them cho banh 
            Console.Write("AFTER DECORATE CREAM: ");
            CreamCake myCake = new CreamCake(simpleCake);
            store.MakeCake(myCake);
            Console.Write("AFTER DECORATE CHOCOLATE: ");
            ChocolateCake finalCake = new ChocolateCake(myCake);
            store.MakeCake(finalCake);
        }
    }
    public abstract class Product
    {
        public abstract string Make();
    }
    public class Cake: Product
    {
        public override string Make()
        {
            return "Cake";
        }
    }
    public abstract class CakeDecorator : Product
    {
        protected Product _product;

        public CakeDecorator(Product product)
        {
            this._product = product;
        }

        public void SetComponent(Product product)
        {
            this._product = product;
        }
        public override string Make()
        {
            if (this._product != null)
            {
                return this._product.Make();
            }
            else
            {
                return "";
            }
        }
    }
    public class CreamCake : CakeDecorator
    {
        public CreamCake(Product product) : base(product)
        {
        }
        public override string Make()
        {
            return $"Cream {base.Make()}";
        }
    }
    public class ChocolateCake : CakeDecorator
    {
        public ChocolateCake(Product product) : base(product)
        {
        }

        public override string Make()
        {
            return $"Chocolate {base.Make()}";
        }
    }
    internal class Bakery
    {
        public Bakery()
        {
        }
        public void MakeCake(Product product)
        {
            Console.WriteLine("You have a " + product.Make());
        }
    }

    
}
