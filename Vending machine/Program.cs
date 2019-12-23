using System;

namespace Vending_machine
{
    class Program
    {
        /// <summary>
        /// money pool
        /// money input = 1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 200kr, 500kr,1000kr
        /// return change
        /// Buy products = money in the pool
        /// 3 types of products: drinks, snacks, food
        /// instruct the user how the product is used once bought
        /// 
        /// Money = int array
        /// Each product = each class
        /// Interface/abstract as base class
        /// Methods in Interface:
        /// Purchase
        /// Examine
        /// Use
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            VendingMachine vMachine = new VendingMachine();

            string userInput = "";
            bool isAlive = true;
            while(isAlive)
            { 
            vMachine.DisplayMenu();
                userInput = Console.ReadLine();
                if (userInput == "q" || userInput == "Q")
                {
                   
                    //Console.WriteLine("press enter to continue or press q to quit");

                    isAlive = false;

                    Console.ReadKey();
                }

            }








            //Drinks drink = new Drinks();
            //while (!drink.CheckTotal())
            //{
            //    Console.WriteLine("Please enter the money");
            //    drink.DepositCoin(Convert.ToInt32(Console.ReadLine()));
            //}


            //drink.DisplayProductSelection();
            //Console.WriteLine("enter the coin: 1kr,50kr,20,100kr,500kr,1000kr");
            //int coin = Convert.ToInt32(Console.ReadLine());
            //drink.DepositCoin(coin);

            Console.ReadLine();
            
        }
    }
}
