using System;
using System.Collections.Generic;
using System.Linq;

namespace CreateAndUseTypes.CreaetTypes
{
    #region "Paramters"
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Mul(int x, int y = 0, bool val = true)
        {
            if (val)
            {
                return x * y;
            }

            return x + y;
        }
    }
    #endregion

    #region "Index"
    public class Card
    {
        private int _id;
        public Card(int id = 1)
        {
            _id = id;
        }

        public string Display()
        {
            return "Card \t" + _id;
        }
    }

    public class Deck
    {
        public ICollection<Card> Cards { get; set; }

        public Card this[int index]
        {
            get { return Cards.ElementAt(index); }
        }
    }
    #endregion

    #region "Sealed Class"
    public class base1
    {
        public virtual void display()
        {
            Console.WriteLine("This is Base Class");
        }
    }

    public class DerivedClass : base1
    {
        public sealed override void display()
        {
            Console.WriteLine("This is Derived Class");
        }
    }

    public class SealedClass : DerivedClass
    {
        //public  override void display()
        //{
        //    Console.WriteLine("This is Derived Class");
        //}

    }
    #endregion
}
