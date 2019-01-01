using System;
using System.Globalization;

namespace DebugApplicationsAndImplementSecurity.ValidateApplicationInput
{
    public class ValidateInputs
    {
        public void Run()
        {
            Console.WriteLine("Example");
            Console.WriteLine("======================");
            Console.WriteLine("1. Data Annitation with Entity Framework ");
            Console.WriteLine("2. Parse, TryParse.");
            Console.WriteLine("======================");
            Console.WriteLine("Enter your Choice ::");

            var index = Convert.ToInt32(Console.ReadLine());
            var validateInputs = new ValidateInputs();
            switch (index)
            {
                case 1:
                    validateInputs.ValidateUserInputs();
                    break;

                case 2:
                    validateInputs.DisplayConversion();
                    break;

                case 3:
                    // MultiThreadingAndAsynchronous();
                    break;

                case 4:
                    // EventsAndCallBacks();
                    break;

                default:
                    break;
            }
        }


        public void ValidateUserInputs()
        {
            using (ShopContext ctx = new ShopContext())
            {
                Address a = new Address
                {
                    AddressLine1 = "Somewhere 1",
                    AddressLine2 = "At some floor",
                    City = "SomeCity",
                    ZipCode = "1111AA"
                };
                Customer c = new Customer()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    BillingAddress = a,
                    ShippingAddress = a,
                };
                ctx.Customers.Add(c);
                ctx.SaveChanges();
            }
        }

        public void DisplayConversion()
        {
            var english = new CultureInfo("En");
            var dutch = new CultureInfo("Nl");

            Console.WriteLine("Please Enter Prise Value");
            var rateValue = Console.ReadLine();

            //Console.WriteLine("Value " + int.Parse(rateValue, NumberStyles.Any, english));


            int values;
            if (int.TryParse(rateValue, NumberStyles.Any, english, out values))
            {
                Console.WriteLine("Value " + values);
            }
        }
    }
}
