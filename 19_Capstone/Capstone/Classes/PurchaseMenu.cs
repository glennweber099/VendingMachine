﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class PurchaseMenu
    {
        public void purchaseMenu()
        {
            bool menu = true;
            while (menu == true)
            {
                Console.WriteLine($"\t\t\t\tPurchase Menu \n\t\t\t\t1) Feed Money \n\t\t\t\t2) Select Product \n\t\t\t\t3) Finish \n\t\t\t\t {Money.balance:c}");
                string input = Console.ReadLine().ToLower().Trim();
                if (input.Length == 0)
                {
                    Console.Clear();
                    continue;

                }
                if (input.Length > 1)
                {
                    Console.Clear();
                    continue;

                }
                if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine($"\t\t\t\t1) $1 \n\t\t\t\t2) $2 \n\t\t\t\t3) $5 \n\t\t\t\t4) $10");
                    string inputm = Console.ReadLine().ToLower().Trim();
                    if (inputm == "1")
                    {
                        Money.AddMoney(1.00M);
                        Console.Clear();
                        continue;
                    }
                    if (inputm == "2")
                    {
                        Money.AddMoney(2.00M);
                        Console.Clear();
                        continue;
                    }
                    if (inputm == "3")
                    {
                        Money.AddMoney(5.00M);
                        Console.Clear();
                        continue;
                    }
                    if (inputm == "4")
                    {
                        Money.AddMoney(10.00M);
                        Console.Clear();
                        continue;
                    }
                }
                if (input == "2")
                {
                    Console.WriteLine("Please enter a valid product code: ");
                    string inputl = Console.ReadLine().Trim().ToUpper();
                    string actualName = VendingMachine.productName[inputl];
                    decimal actualPrice = VendingMachine.productPrice[inputl];

                    if ((Money.balance > 0) && (Money.balance > VendingMachine.productPrice[inputl]))
                    {
                        if (Inventory.checkProductCode(inputl))
                        {
                            if (Inventory.checkInventory(inputl))
                            {
                                Inventory.dispenseProduct(inputl);
                                Console.WriteLine($"{actualName}\n");
                                Money.SubtractMoney(actualPrice);
                                Inventory.updateInventory(inputl);
                                Money.UpdatePreviousBalance(actualPrice);

                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("SOLD OUT");
                            }
                            continue;
                        }
                        Console.WriteLine("Invalid Product Code");
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Please put more money in and try again");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                }
                if (input == "3")
                {
                    Console.WriteLine($"{Money.GiveChange(Money.balance)}");
                    Console.WriteLine("Please press [ENTER] to return to the menu");
                    Console.ReadLine();
                    Console.Clear();
                    menu = false;
                    break;

                }
            }
        }

    }
}