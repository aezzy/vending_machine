using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_machine
{
    class Snacks
    {



        public int RunningTotal { get; set; }

        public int CostOfProduct { get; set; }
        private int costOfProduct = 20;
        public int Change { get; set; }
        private int change;

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
            Console.WriteLine("---Snacks---");
            Console.WriteLine("Make selection\n1.Tuna sandwich 20kr\n2.Chicken sandwich 20kr\n3.Veg Pizza bar 20kr");
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
                        Console.WriteLine("Thank you for buying Tuna sandwich", CostOfProduct) ;
                        //ReturnChange();
                        selectionOK = true;
                        break;
                    case 2:
                        Console.WriteLine("Thank you for buying Chicken sandwich", CostOfProduct);
                        //ReturnChange();
                        selectionOK = true;
                        break;
                    case 3:
                        Console.WriteLine("Thank you for buying Pizza bar", CostOfProduct);
                        //ReturnChange();
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

