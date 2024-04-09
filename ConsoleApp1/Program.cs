using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        enum Menu
        {
            Breakfast = 1,
            Combos = 2,
            Chips = 3,
            Burgers = 4,
            Drinks = 5,
            Checkout = 6,
            Exit
        }
        enum PMenu
        {
            Bf1 = 1,
            Bf2 = 2,
            Bf3 = 3,
            back


        }
        enum Combos
        {
            combo1 = 1,
            combo2 = 2,
            combo3 = 3,
            combo4 = 4,
            back = 5

        }
        enum Chips
        {
            chips1 = 1,
            chips2 = 2,
            chips3 = 3,
            chips4 = 4,
            back
        }
        enum Burgers
        {
            Beef = 1,
            Chicken = 2,
            Back = 3
        }
        enum Drinks
        {
            Soft_Drinks = 1,
            Milkshake = 2,
            Juice = 3,
            Hot_Drinks = 4,
            Back = 5
        }
        static bool cDrinks = true;
        static bool cBurgers = true;
        static bool cMenu = true;
        static int combo1, combo2, combo3, combo4;
        static int chips1, chips2, chips3, chips4;
        static int total = 0;
        static ArrayList Order = new ArrayList();

        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                int option = DisplayMenu();
                Menu menu = (Menu)option;
                bool Pexit = false;
                switch (menu)
                {
                    case Menu.Breakfast:
                        Console.Clear();
                        do
                        {
                            int Poption = DisplayMenuP();
                            PMenu Pmenu = (PMenu)Poption;
                            switch (Pmenu)
                            {
                                case PMenu.Bf1:
                                    Console.Clear();
                                    total = total + 40;
                                    Console.WriteLine($"| Breakfast Special  added to order. Total: {total}|");
                                    Order.Add("Breakfast Special");


                                    break;
                                case PMenu.Bf2:
                                    Console.Clear();
                                    total = total + 20;
                                    Console.WriteLine($"| Hashbrow and egg added to order. Total: {total} |");
                                    Order.Add("Hashbrow and egg");


                                    break;
                                case PMenu.Bf3:
                                    Console.Clear();
                                    total = total + 60;
                                    Console.WriteLine($"| Sunday special added to order. Total: {total} |");
                                    Order.Add("Sunday Special");


                                    break;
                                case PMenu.back:
                                    Console.Clear();
                                    Pexit = true;
                                    break;
                            }

                        } while (Pexit == false);
                        break;

                    case Menu.Combos:
                        {
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("Combo Menu");
                                Console.WriteLine("1.Burger and chips + 500ml coke..........R50\n" +
                                                 "2. Russian and chips......................R30\n" +
                                                 "3. 4 Burgers and 2 chips..................R80\n" +
                                                 "4. 6 Burgers + 2l coke....................R150\n" +
                                                 "5. Back");
                                int option2 = Convert.ToInt32(Console.ReadLine());
                                switch ((Combos)option2)
                                {
                                    case (Combos.combo1):
                                        Console.Clear();
                                        combo1 = 50;
                                        total += combo1;
                                        Console.WriteLine($"| Burger and chips + 500ml coke added to order. Total:R{total} | ");
                                        Order.Add("Burger  and chips + 500nl coke ");
                                        break;
                                    case (Combos.combo2):
                                        Console.Clear();
                                        combo2 = 30;
                                        total += combo2;
                                        Console.WriteLine($"| Russian and chips. Total:R{total} |");
                                        Order.Add("Russian and chips");

                                        break;
                                    case (Combos.combo3):
                                        Console.Clear();
                                        combo3 = 80;
                                        total += combo3;
                                        Console.WriteLine($"| 4 Burgers and 2 chips. Total:R{total} |");
                                        Order.Add("4 Burgers and 2 chips");

                                        break;
                                    case (Combos.combo4):
                                        Console.Clear();
                                        combo4 = 150;
                                        total += combo4;
                                        Console.WriteLine($"|6 Burgers + 2l coke. Total:R{total} |");
                                        Order.Add("6 Burgers + 2l coke");

                                        break;
                                    case (Combos.back):
                                        Console.Clear();
                                        cMenu = false;

                                        break;
                                }
                            } while (cMenu);




                            break;
                        }
                    case Menu.Chips:
                        {
                            Console.Clear();
                            bool eChips = true;
                            do
                            {
                                Console.WriteLine("Chips");
                                Console.WriteLine("----------------------------------------------------------");
                                Console.WriteLine("1.Small chips.............R15 \n" +
                                                  "2.Medium chips............R30 \n" +
                                                  "3.Large chips.............R45 \n" +
                                                  "4.Cheesy chips............R50\n" +
                                                  "5.Back");
                                                  
                                option = Convert.ToInt32(Console.ReadLine());
                                switch ((Chips)option)
                                {
                                    case (Chips.chips1):
                                        Console.Clear();
                                        Console.WriteLine("Small chips:     R15");
                                        chips1 = 15;
                                        total += chips1;
                                        Console.WriteLine("Your total is: " + total);
                                        break;
                                    case (Chips.chips2):
                                        Console.Clear();
                                        Console.WriteLine("Medium chips:    R30");
                                        chips2 = 30;
                                        total += chips2;
                                        Console.WriteLine("Your total is: " + total);
                                        break;
                                    case (Chips.chips3):
                                        Console.Clear();
                                        Console.WriteLine("Large chips:     R45");
                                        chips3 = 45;
                                        total += chips3;
                                        Console.WriteLine("Your total is: " + total);
                                        break;
                                    case (Chips.chips4):
                                        Console.Clear();
                                        Console.WriteLine("Cheesy chips:    R50");
                                        chips4 = 50;
                                        total += chips4;
                                        Console.WriteLine("Your total is: " + total);
                                        break;
                                    case (Chips.back):
                                        Console.Clear();
                                        eChips = false;

                                        break;
                                }


                            } while (eChips);

                            break;
                        }
                    case Menu.Burgers:
                        {
                            Console.Clear();
                          
                            do
                            {
                                Console.WriteLine("Which burger would you like? \n 1.Beef \n 2.Chicken \n 3.Back \nEnter a number");
                                int choice = int.Parse(Console.ReadLine());
                                switch ((Burgers)choice)
                                {
                                    case Burgers.Beef:
                                        Console.Clear();
                                        BeefBurger();
                                        break;



                                    case Burgers.Chicken:
                                        Console.Clear();
                                        ChickenBurger();
                                        break;



                                    case Burgers.Back:
                                        Console.Clear();
                                        cBurgers = false;
                                        
                                        break;
                                }

                            } while (cBurgers);
                            break;
                        }
                    case Menu.Drinks:
                        {   Console.Clear();
                            
                            do
                            {
                                

                                Console.WriteLine("Which type of drink would you like? \n1.Soft drinks \n2.Milkshakes \n3.Juices \n4.Hot drinks \n5.Back ");
                                int op = int.Parse(Console.ReadLine());
                               
                                switch ((Drinks)op)
                                {
                                    case Drinks.Soft_Drinks:
                                        Console.Clear();
                                        SoftDrinks();
                                        break;



                                    case Drinks.Milkshake:
                                        Console.Clear();
                                        MilkShakes();
                                        break;



                                    case Drinks.Juice:
                                        Console.Clear();
                                        Juice();
                                        break;



                                    case Drinks.Hot_Drinks:
                                        Console.Clear();
                                        HotDrinks();
                                        break;



                                    case Drinks.Back:
                                        Console.Clear();
                                        cDrinks = false;    
                                        break;
                                }

                            } while (cDrinks);

                            break;
                        }
                    case Menu.Checkout:
                        {
                            Check();
                            Console.WriteLine(" Press any key  to return to main menu");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                }

            } while (exit == false);
            Console.ReadKey();
        }
        public static void Check()
        {   Console.Clear();
            Console.WriteLine("You orderd the following: ");
            for (int i = 0; i < Order.Count; i++)
            {
                Console.WriteLine("* " +Order[i]+ " ");
            }
            Console.WriteLine($"Total Price =  R{total}");
            Console.WriteLine("Thank you , your order will be ready soon");
            Order.Clear();  
            total = 0;

        }
        private static int DisplayMenu()
        {
            Console.WriteLine("Welcome to Zambezi Bar and Grill");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("What would you like to order:\n" +
                             $"Total:R{total}");
            Console.WriteLine("\n1.Breakfast \n2.Combos \n3.Chips \n4.Burgers \n5.Drinks \n6.Checkout ");
            int option = int.Parse(Console.ReadLine());



            return option;
        }
        private static int DisplayMenuP()
        {
            Console.WriteLine("BreakFast");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\n1.Breakfast Special ...............R40 \n2.Hashbrown and egg ...............R20 \n3.Sunday Special ..................R60 \n4.Back");
            int PPoption = int.Parse(Console.ReadLine());



            return PPoption;
        }
        public static void ChickenBurger()
        {
            bool e = true;
            do
            {
                Console.WriteLine("Which chicken burger would you like? \n " +
                    "1.Mexican chicken burger.......................R85 \n " +
                    "2.Siracha glazed chicken.......................R95 \n " +
                    "3.BBQ chicken supreme..........................R120\n" +
                    "0.Back");
                int ans = int.Parse(Console.ReadLine());
                switch (ans)
                {
                    case 1:
                        Console.Clear();
                        total += 85;
                        Console.WriteLine($"| Mexican chicken burger added to order. Total: R{total } |");
                        Order.Add("Mexican chicken burger");
                        break;
                    case 2:
                        Console.Clear();
                        total += 95;
                        Console.WriteLine($"| Siracha glazed chicken burger added to order. Total: R{total} |");
                        Order.Add("Siracha glazed chicken burger");
                        break;
                    case 3:
                        Console.Clear();
                        total += 120;
                        Console.WriteLine($"| BBQ chicken supreme burger aded to order. Total: R{total} |");
                        Order.Add("BBQ chicken supreme burger ");
                        break;
                    case 0:
                        Console.Clear();
                        e = false;

                        break;
                }
            } while (e);
            
           
            
        }
        public static void BeefBurger()
        { bool y = true;
            do
            {
                Console.WriteLine("Which beef burger would you like? \n " +
                    "1.Tripple patty burger............................R101 \n " +
                    "2. Sweet chilli ..................................R80\n " +
                    "3.Green chilli Deluxe.............................R95 \n" +
                    "0.Back");
                int ans = int.Parse(Console.ReadLine());

                switch (ans)
                {
                    case 1:
                        Console.Clear();
                        total += 101;
                        Console.WriteLine($"| Triple patty  burger added to order. Total: R{total} |");
                        Order.Add("Tripple patty burger");
                        
                        break;
                    case 2:
                        Console.Clear();
                        total += 80;
                        Console.WriteLine($"| Sweet chilli burger added to order. Total: R{total} |");
                        Order.Add("Sweet chilli burger ");
                        break;
                    case 3:
                        Console.Clear();
                        total += 95;
                        Console.WriteLine($"| BBQ chicken supreme burger added to order. Total: R{total} |");
                        Order.Add("Green chilli Deluxe supreme burger ");
                        break;
                    case 0:
                        Console.Clear();
                        y = false;  
                        break;
                }
            } while(y);
               
            
            
        }
        public static void SoftDrinks()
        {   bool r= true ;
            
            do
            {
                Console.WriteLine("Which kind of drink would you like? \n" +
                " 1.Coca-Cola..................................................................R32 \n " +
                "2.Sprite......................................................................R30 \n" +
                " 3.Fanta Orange...............................................................R24 \n " +
                "4.Creme Soda..................................................................R20 \n" +
                "5.Back");
                int ans = int.Parse(Console.ReadLine());
                switch (ans)
                {
                    case 1:
                        Console.Clear();
                        total = total + 32;
                        Console.WriteLine($"| Coca-cola  added to order. Total: R{total} |");
                        Order.Add("Coca- cola");
                        break;
                    case 2:
                        Console.Clear();
                        total = total + 30;
                        Console.WriteLine($"| Sprite added to order. Total: R{total} |");
                        Order.Add("Sprite");

                        break;



                    case 3:
                        Console.Clear();
                        total = total + 24;
                        Console.WriteLine($"| Fanta Orange added to order. Total: R{total} |");
                        Order.Add("Fanta Orange");
                        break;



                    case 4:
                        Console.Clear();
                        total = total + 20;
                        Console.WriteLine($"| Creme Soda added to order. Total: R{total} |");
                        Order.Add("Creme Soda");


                        break;
                    case 5:
                        Console.Clear();
                        r = false;

                        break;
                }
            } while (r);
            
        }
        public static void MilkShakes()
        {   bool  t = true;
            
            do
            {
                Console.WriteLine("Which kind of milkshake would you like? \n " +
                "1.Oreo milkshake..........................................R50 \n " +
                "2.Vanailla milkshake......................................R40 \n" +
                " 3.Chocolate milkshake....................................R40 \n " +
                "4.Banana Kajur milkshake..................................R67 \n" +
                "5.Back");
                int ans = int.Parse(Console.ReadLine());
                switch (ans)
                {
                    case 1:
                        Console.Clear();

                        total += 50;
                        Console.WriteLine($"|Oreo milkshake. Total: R{total} |");
                        Order.Add("Oreo milkshake ");

                        break;
                    case 2:
                        Console.Clear();

                        total += 40;
                        Console.WriteLine($"|Vanilla milkshake. Total: R{total} |");
                        Order.Add("Vanilla milkshake");
                        break;



                    case 3:
                        Console.Clear();
                        
                        total += 40;
                        Console.WriteLine($"|Chocolate milkshake. Total: R{total} |");
                        Order.Add("Chocolate milkshake");
                        break;



                    case 4:
                        Console.Clear();
                        
                        total += 67;
                        Console.WriteLine($"|Banana Kajur milkshake. Total: R{total} |");
                        Order.Add("Banana Kajur milkshake");
                        
                        break;
                    case 5:
                        Console.Clear();
                        t = false;   
                        break;
                }
            } while (t);
           
        }
        public static void Juice()
        {
            bool u = true;
            do
            {
                Console.WriteLine("Which kind of juice would you like? \n" +
                " 1.Orange juice.................................................R35 \n" +
                " 2.Mango juice..................................................R35 \n " +
                "3.Apple juice...................................................R40 \n " +
                "4.Black currant juice...........................................R45 \n" +
                "5.Back");
                int ans = int.Parse(Console.ReadLine());
                switch (ans)
                {
                    case 1:
                        Console.Clear();
                        total = total + 35;
                        Console.WriteLine($"| Orange juice added to order. Total: R{total} |");
                        Order.Add("Orange juice");


                        break;
                    case 2:
                        Console.Clear();
                        total = total + 35;
                        Console.WriteLine($"| Mango juice added to order.  Total: R{total} |");
                        Order.Add("Mango juice");
                        break;



                    case 3:
                        Console.Clear();
                        total = total + 40;
                        Console.WriteLine($"| Apple juice added to order. Total: R{total} |");
                        Order.Add("Apple juice");
                        break;



                    case 4:
                        Console.Clear();
                        total = total + 45;
                        Console.WriteLine($"| Black currant juice added to order . Total: R{total} |");
                        Order.Add("Black currant juice ");
                        break;



                    case 5:
                        Console.Clear();
                        u = false;
                        break;
                }
            } while (u);
       
         
        }
        public static void HotDrinks()
        {
            bool i = true;  
            do {
                Console.WriteLine("Which kind of hot drink would you like? \n " +
                "1.Hot chocolate.....................................................R24\n" +
                "2.Coffee............................................................R20 \n " +
                "3.Chai tea..........................................................R30 \n " +
                "4.Fresh ginger tea..................................................R20 \n" +
                "5.Back");
                int ans = int.Parse(Console.ReadLine());
                switch (ans)
                {
                    case 1:
                        Console.Clear();
                        total = total + 24;
                        Console.WriteLine($"| Hot chocolate added  to order . Total: R{total} |");

                        Order.Add("Hot chocolate");
                        break;
                    case 2:
                        Console.Clear();
                        total = total + 20;
                        Console.WriteLine($"| Coffee added to order . Total: R{total} |");
                        Order.Add("Coffee ");

                        break;



                    case 3:
                        Console.Clear();
                        total = total + 30;
                        Console.WriteLine($"| Chai tea added to order . Total: R{total} |");

                        Order.Add("Chai tea");
                        break;



                    case 4:
                        Console.Clear();
                        total = total + 20;
                        Console.WriteLine($"| Fresh ginger tea . Total: R{total} |");

                        Order.Add("Fresh ginger tea");
                        break;



                    case 5:
                        Console.Clear();
                        i = false;
                        break;
                }
            } while (i);
           
            
        }
    }
}
       
