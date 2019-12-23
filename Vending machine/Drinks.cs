using System;







using System.Collections.Generic;
using System.Text;

namespace Vending_machine
{
    class Drinks: IVendinMachineOperations 
    {
        public int RunningTotal { get; set; }
        public int CostOfProduct { get; set; }
        public int Change { get; set; }
        private int change;

       
        private int costOfProduct = 8;
        public Drinks()
        {
            RunningTotal = 0;
            CostOfProduct = costOfProduct;
        }
        public void DepositCoin(int money)
        {

            switch (money)
            {
                case (1):
                    Console.WriteLine("Put more money not enough");
                    RunningTotal += 1;

                    break;
                case (5):
                    Console.WriteLine("Put more money not enough");
                    RunningTotal += 5;

                    break;
                case (10):
                    RunningTotal += 10;

                    break;
                case (20):
                    RunningTotal += 20;

                    break;
                case (50):
                    RunningTotal += 50;

                    break;
                case (100):
                    RunningTotal += 100;

                    break;
                case (500):

                    RunningTotal += 500;

                    break;
                case (1000):
                    RunningTotal += 1000;

                    break;
                default:
                    Console.WriteLine("invalid entry, Put more money not enough");

                    break;
            }
        }
        public bool CheckTotal()
        {
            if (RunningTotal >= CostOfProduct)
                return true;
            else
                return false;
        }

        public void DisplayProductSelection()
        {

            Console.WriteLine("---Drinks---");
            Console.WriteLine("Make selection\n1.Cola 8kr\n2.Pepsi 8kr\n3.Energi Drink 8kr");
            Console.WriteLine("--------");
            MakeProductSelection(Convert.ToInt32(Console.ReadLine()));
        }

       private void MakeProductSelection(int selection)
        {
            bool selectionOK = false;
           

            while (!selectionOK)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("The price of Cola is {0}kr", CostOfProduct);
                        ReturnChange();
                        selectionOK = true;
                        break;
                    case 2:
                        Console.WriteLine("The price of Pepsi is {0}kr", CostOfProduct);
                        ReturnChange();
                        selectionOK = true;
                        break;
                    case 3:
                        Console.WriteLine("The price of Energi drink is {0}kr", CostOfProduct);
                        ReturnChange();
                        selectionOK = true;
                        break;
                    default:
                        Console.WriteLine("invalid");
                        Console.WriteLine("press enter to continue or press q to quit");
                        selection = Convert.ToInt32(Console.ReadLine());
                        selectionOK = false;
                        
                        break;
                }
            }
        }


        public void ReturnChange()
        {

            change = RunningTotal - CostOfProduct;
            Change = change;
            if (RunningTotal > CostOfProduct)
                
            Console.WriteLine("your change:{0}kr", Change);
           
        }



    }
}
