using CreateAndUseTypes.ConsumeTypes;
using CreateAndUseTypes.CreaetTypes;
using CreateAndUseTypes.CreateAndImplementAClassHierarch;
using System;
using System.Collections.ObjectModel;

namespace CreateAndUseTypes
{
    public class ChapterTwoCreateAndUseType
    {
        public void CreateAndUseTypeIndex()
        {
            Console.WriteLine("Chapter One Index");
            Console.WriteLine("======================");
            Console.WriteLine("1. Create Types.");
            Console.WriteLine("2. Consume Types.");
            Console.WriteLine("3. Enforce Encapsulation.");
            Console.WriteLine("4. Create And Implement a Class Hierarchy.");
            Console.WriteLine("5. Find, Execute, And Create Types At Runtime by Using reflection.");
            Console.WriteLine("6. Manage The Object Life Cycle.");
            Console.WriteLine("7. Manupulate Strings.");
            Console.WriteLine("======================");
            Console.WriteLine("Enter your Choice ::");

            var index = Convert.ToInt32(Console.ReadLine());
            switch (index)
            {
                case 1:
                    //Name Parameter/ Optional Parameters
                    var calculator = new Calculator();
                    Console.WriteLine("Result\t" + calculator.Add(y: 9, x: 10).ToString());
                    Console.WriteLine("Result\t" + calculator.Add(10, y: 9).ToString());
                    Console.WriteLine("Result\t" + calculator.Add(10, 9).ToString());

                    Console.WriteLine("Result\t" + calculator.Mul(10, 9).ToString());
                    Console.WriteLine("Result\t" + calculator.Mul(x: 9, val: true).ToString());
                    Console.ReadLine();

                    //Indexers
                    var duck = new Deck();
                    duck.Cards = new Collection<Card>();
                    duck.Cards.Add(new Card(10));
                    duck.Cards.Add(new Card(11));
                    duck.Cards.Add(new Card());
                    duck.Cards.Add(new Card(13));
                    duck.Cards.Add(new Card());

                    Console.WriteLine(" Index 0: \t" + duck[0].Display());
                    Console.WriteLine(" Index 2: \t" + duck[2].Display());
                    Console.WriteLine(" Index 1: \t" + duck[1].Display());
                    Console.WriteLine(" Index 3: \t" + duck[3].Display());
                    Console.WriteLine(" Index 4: \t" + duck[4].Display());

                    Console.ReadLine();

                    // Sealed Class

                    var sealedClass = new SealedClass();
                    sealedClass.display();

                    break;

                case 2:
                    //Inputs
                    Console.WriteLine("Please enter Amount value in Double.");
                    var values = Convert.ToDecimal(Console.ReadLine());

                    var m = new Money(values);
                    decimal amount = m;
                    Console.WriteLine("Decimal Value :\t" + amount);
                    int truncatedAmount = (int)m;
                    Console.WriteLine("Trancate Amount Value :\t" + truncatedAmount);
                    Console.ReadLine();

                    break;

                case 3:
                    var aBaseClass = new ABaseClass();
                    aBaseClass.Display();
                    aBaseClass.DisplayWithVirtual();
                    aBaseClass = new BDerivedClass();
                    aBaseClass.Display();
                    aBaseClass.DisplayWithVirtual();
                    
                    Console.ReadLine();
                    break;

                case 4:
                    // EventsAndCallBacks();
                    break;

                default:
                    break;
            }
        }
    }
}