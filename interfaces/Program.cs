using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean design;
            Console.WriteLine("Would you like to design your hat? (Y for yes or any other keys)");
            String ans = Console.ReadLine();
            if(ans.ToUpper() == "Y")
                design = true;
            else{
                design = false;
            }
            hat snapback = new hat(design);
            double hatPrice = snapback.calPrice();
            Console.WriteLine("The price of your hat is ${0}", hatPrice);
            
            
            Boolean deco;
            Console.WriteLine("Would you like an extra decoration for your cake? (Y for yes or any other keys)");
            String ans2 = Console.ReadLine();
            if(ans2.ToUpper() == "Y")
                deco = true;
            else{
                deco = false;
            }
            cake godiva = new cake(deco);
            double cakePrice = godiva.calPrice();
            Console.WriteLine("The price of your cake is ${0}", cakePrice);
            Console.WriteLine("Your total for today will be {0}", cakePrice + hatPrice);
        }
        interface Iprice
        {
            double calPrice();
        }
        public class hat : Iprice
        {
            public Boolean designed {get; private set;}
            public double productionCost {get; private set;}
            public hat(Boolean designed)
            {
                this.designed = designed;
                this.productionCost = 15;
            }

            public double calPrice()
            {
                if(designed == true)
                    return (productionCost + 5) * 1.15;
                return productionCost * 1.15;
            }

        }
        public class cake : Iprice
        {
            public double productionCost {get; private set;}
            public Boolean decorated {get; private set;}
            public cake(Boolean decorated)
            {
                this.decorated = decorated;
                this.productionCost = 20;
            }

            public double calPrice()
            {
                if(decorated == true)
                    return (productionCost + 7) * 1.15;
                return productionCost * 1.15;
            }
        }
    }
}
