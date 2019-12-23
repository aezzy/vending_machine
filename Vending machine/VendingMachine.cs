using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_machine
{
    public class VendingMachine
    {

        public int RunningTotal { get; set; }
        public int Change { get; set; }

        public int CostOfProduct { get; set; }


        Drinks drink = new Drinks();
        Candies candy = new Candies();
        Snacks snack = new Snacks();
        public VendingMachine()
        { 
        
        }


       
      


        public void DisplayMenu()
        {
            //bool isAlive = true;
            //string userInput = "";


            Console.WriteLine("---------Menu-------");
                Console.WriteLine("Select:\n1. Drinks\n2.Candies\n3.Snacks");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:



                    while (!drink.CheckTotal())
                    {
                        drink.DisplayProductSelection();
                            Console.WriteLine("Please enter the money");
                            drink.DepositCoin(Convert.ToInt32(Console.ReadLine()));


                            drink.ReturnChange();
                            Console.WriteLine("press enter to continue or press q to quit");


                    }

                    break;

                    case 2:



                    while (!candy.CheckTotal())
                    {
                        candy.DisplayProductSelection();
                            Console.WriteLine("Please enter the money");
                            candy.DepositCoin(Convert.ToInt32(Console.ReadLine()));
                            
                           
                            candy.ReturnChange();
                        Console.WriteLine("press enter to continue or press q to quit");

                    }


                    break;

                    case 3:



                    while (!snack.CheckTotal())
                    {
                        snack.DisplayProductSelection();
                    Console.WriteLine("Please enter the money");
                            candy.DepositCoin(Convert.ToInt32(Console.ReadLine()));

                            
                            snack.ReturnChange();
                            Console.WriteLine("press enter to continue or press q to quit");

                    }
                    break;

                    default:

                    //Change = drink.Change + candy.Change + snack.Change;

                    Console.WriteLine("your change:{ 0}kr", Change);





                    break;

                }

            }
        }
    }

