using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CShapPractise
{
    class Program
    {
        public void secondary()
        {
            Console.WriteLine("This is the secondary subroutine");
            Console.ReadKey();
        }

        static void Main(string[] args)
            
        {  
            Console.WriteLine("Please enter the first number for the calculation");
            int y = Convert.ToInt32(Console.ReadLine());
                    //acceptance of first number

            Console.WriteLine("Please write the second number for the calculation");
            int x = Convert.ToInt32(Console.ReadLine());
                    //acceptance of second number

            Console.WriteLine("What do you wish to do to these numbers?");
                Console.WriteLine("1. Add Them");
                    Console.WriteLine("2. Minus Them");
                        Console.WriteLine("3. Multiply Them");
                            Console.WriteLine("4. Divide Them");
                                 Console.WriteLine("5. Mod Them");
                                 

                         string userresponce3 = Console.ReadLine();

            if (userresponce3 == "1")
            {
                Console.Write("The numbers added together are: ");
                int total = x + y;
                Console.Write(total);
                Console.ReadKey();
                

                //prints added numbers
            }
            else if (userresponce3 == "2")
            {
                Console.Write("The numbers minused together are: ");
                int total2 = y - x;
                Console.Write(total2);
                Console.ReadKey();
                //prints subtracted numbers
            }
            else if (userresponce3 == "3")
            {
                Console.Write("The numbers multiplied together are: ");
                int total3 = y * x;
                Console.Write(total3);
                Console.ReadKey();
                //prints multiplied numbers
            }
            else if (userresponce3 == "4")
            {
                Console.Write("The numbers divided together are: ");
                int total4 = y / x;
                Console.Write(total4);
                Console.ReadKey();
                //prints numbers divided together
            }
            else if (userresponce3 == "5")
            {
                Console.Write("The numbers modded together are: ");
                int total5 = y % x;
                Console.Write(total5);
                Console.ReadKey();
                //prints numbers modded together
            }
            else{
                Console.WriteLine("Do you wish to do a different calculation?");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("1. Yes");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("2. No");
                /// this is a section of code responsible for the validation of the program
                /// and the suggestion of doing a different calculation
                int useranswer = Convert.ToInt32(Console.ReadLine());
                if(useranswer == 1){Console.WriteLine("Please select one from below");
                Console.WriteLine("Please answer with a number from one of the options.");
                Console.WriteLine("1. Quadratic Equation");}
                Console.ReadLine();
                if (useranswer == 1) { Console.Write("Please enter your A:"); int A = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter your B:"); int B = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter your C:"); int C = Convert.ToInt32(Console.ReadLine());
                    //The quadratic formula is used to calculate a positive and negative 'x'
                    // -B +-_/B^2-4(AxC)/2xA.
                    float AtimesC = A * C;
                    float fourtimesAC = 4 * AtimesC;
                    float twotimesA = 2 * A;
                    float BtimesB = B * B;
                    float squareroot = BtimesB - fourtimesAC;
                    float totalsquareroot = Convert.ToInt32(Math.Sqrt(squareroot));
                    float top = -B + totalsquareroot;
                    float bottom = top / twotimesA;


                    //int totalquadratic = Convert.ToInt32(-B + Math.Sqrt((B * B) - 4 * (A * C))/2*A);
                    //Console.WriteLine("Your positive x is: "+ totalquadratic);

                    Console.Write("Your positive x is: " + bottom);
                    float top2 = -B - totalsquareroot;
                    float bottom2 = top2 / twotimesA;
                    Console.WriteLine();
                    Console.Write("Your negative x is: " + bottom2);
                    Console.ReadKey();
                } else if (useranswer==2) { Console.WriteLine();Console.ReadLine(); }
            }
            }
        }
    }

