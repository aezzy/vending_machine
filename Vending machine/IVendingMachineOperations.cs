using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_machine
{
    public interface IVendinMachineOperations
    {


        public int RunningTotal { get; set; }

        public int CostOfProduct { get; set; }

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
                case (200):
                    RunningTotal += 200;

                    break;
                case (300):
                    RunningTotal += 300;

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
        public void DisplayMenu()
        { }
        public void DisplayProductSelection()
        {

            Console.WriteLine("------");
            Console.WriteLine("Make selection:");
            Console.WriteLine("--------");
            MakeProductSelection(Convert.ToInt32(Console.ReadLine()));
        }

        public void MakeProductSelection(int selection)
        {
            bool selectionOK = false;
            while (!selectionOK)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine();
                        selectionOK = true;
                        break;
                    case 2:
                        Console.WriteLine();
                        selectionOK = true;
                        break;
                    case 3:
                        Console.WriteLine();
                        selectionOK = true;
                        break;
                    default:
                        Console.WriteLine("invalid");

                        selection = Convert.ToInt32(Console.ReadLine());
                        selectionOK = false;
                        break;
                }
            }

        }
        public void ReturnChange()
        {
            if (RunningTotal > CostOfProduct)
                Console.WriteLine("your change:{0}kr", RunningTotal - CostOfProduct);
        }




    }
}
