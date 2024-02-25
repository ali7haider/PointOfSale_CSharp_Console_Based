using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PointOfSale.BL;
using PointOfSale.UI;
using PointOfSale.DL;


namespace PointOfSale
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "ids.txt";
            MUserDL.read_data(path);
            if (ProductDL.ReadFromFile())
            {
                Console.WriteLine("Read Data Succesfully");
            }
            while (true)
            {
                string op = MenuUI.menu();
                if (op == "1")
                {
                    MUser user = MUserUI.takeinputforsignin();
                    MUser U = MUser.checkuser(user);
                    if (U != null)
                    {
                        if (MUser.isAdmin(U))
                        {
                            while (true)
                            {
                                string opt = MenuUI.adminMenu();
                                if (opt == "1")
                                {
                                    Product P = ProductUI.addProduct();
                                    ProductDL.addproductToList(P);
                                    
                                }
                                else if(opt=="2")
                                {
                                    ProductUI.viewAllProduct();
                                }
                                else if (opt == "3")
                                {
                                    ProductUI.highestUnitPriceProduct();
                                }
                                else if (opt == "4")
                                {
                                    ProductUI.showSalestaxProduct();
                                }
                                else if (opt == "5")
                                {
                                    ProductUI.showThresholdProduct();
                                }
                                else if (opt == "6")
                                {
                                    break;
                                }
                            }

                        }
                        else
                        {
                            string name = U.getUserName();
                            Customer C = new Customer(U.getUserName());
                            CustomerDL.addCustomerToList(C);
                            while (true)
                            {
                                string opti = MenuUI.customerMenu();
                                if (opti == "1")
                                {
                                    ProductUI.viewAllProduct();
                                }
                                else if (opti == "2")
                                {
                                    CustomerUI.buyProduct();
                                }
                                else if (opti == "3")
                                {
                                    CustomerUI.printInVoice(C);
                                }
                                else if (opti == "4")
                                {
                                    CustomerDL.currentBuy.Clear();
                                    break;
                                }
                                
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Such User");
                        MenuUI.clearScreen();
                    }

                }
                else if (op == "2")
                {
                    MUser user = MUserUI.takeinputforsignup();
                    MUserDL.adduserstoList(user);
                    MUserDL.Storedata(user, path);
                }
                else if (op == "3")
                {
                    ProductDL.StoreInFile();
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                    MenuUI.clearScreen();
                }

            }
        }

        
        
    }
    }

