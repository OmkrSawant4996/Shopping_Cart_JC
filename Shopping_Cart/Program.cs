using System;
using System.Collections.Generic;

namespace Shopping_Cart
{

    internal class program
    {
        static void Main()
        {
            List<ProductDetails> productList = new List<ProductDetails>();



            bool user = true;
            while (user)

            {
                Console.WriteLine("Enter your choice.");
                Console.WriteLine(" 1.Add product \n 2.Remove product \n 3.Update program \n 4.View product \n 5.Exit ");
                Console.WriteLine("Please select from given number (1:5) : ");
                int UserNumber = int.Parse(Console.ReadLine());
                Console.Clear();


                if (UserNumber == 1)
                {
                    ProductDetails product1 = new ProductDetails();
                    Console.WriteLine("Your choice is Add product ");
                    Console.WriteLine("Enter product name: ");
                    string name = Console.ReadLine();
                    product1.ProductName = name;

                    Console.WriteLine("\nEnter product price : ");
                    double price = double.Parse(Console.ReadLine());
                    product1.ProductPrice = price;
                    productList.Add(product1);

                    Console.WriteLine("\n product is succesfully added.");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (UserNumber == 2)
                {
                    Console.WriteLine("Your choice is Remove product ");
                    Console.WriteLine("Enter product name: ");
                    string name = (Console.ReadLine());
                    if (name != null)
                    {
                        productList.RemoveAt(0);
                        Console.WriteLine("product removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("please enter a product");
                    }


                    Console.ReadLine();
                    Console.Clear();

                }
                else if (UserNumber == 3)
                {
                    //Console.WriteLine("Your choice is Update product");

                    //Console.WriteLine("Enter product name :");
                    //string name = Console.ReadLine();
                    //if (name == )
                    //{

                    //}

                    //Console.WriteLine("Please enter updated product name : ");
                    //Console.WriteLine("Please enter updated product price : ");

                }

                else if (UserNumber == 4)
                {
                    Console.WriteLine("Your choice is View");
                    Console.WriteLine("product name           product price ");
                    Console.WriteLine("------------------------------------");
                    foreach (var product in productList)
                    {
                        Console.WriteLine((product.ProductName + "                     " + product.ProductPrice));
                    }
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (UserNumber == 5)
                {
                    Console.WriteLine("Thank you for visit.");
                    Console.ReadLine();
                    user = false;
                    Console.Clear();
                }


            }

        }
    }

}

