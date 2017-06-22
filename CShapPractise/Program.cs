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

            start:
            Console.WriteLine("What do you wish to do?");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Minus");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Mod");
            Console.WriteLine("6. Square a number");
            Console.WriteLine("7. Cube a number");
            Console.WriteLine("8. Find square root of a number");
            Console.WriteLine("Press any key for advanced features.");
            string userresponce3 = Console.ReadLine();
            if (userresponce3 == "1")
            {
                Console.WriteLine("Please enter the first number for the calculation");
                int y = Convert.ToInt32(Console.ReadLine());
                //acceptance of first number

                Console.WriteLine("Please write the second number for the calculation");
                int x = Convert.ToInt32(Console.ReadLine());
                //acceptance of second number
                Console.Write("The numbers added together are: ");
                int total = x + y;
                Console.Write(total);
                Console.ReadKey();


                //prints added numbers
            }
            else if (userresponce3 == "2")
            {
                Console.WriteLine("Please enter the first number for the calculation");
                int y = Convert.ToInt32(Console.ReadLine());
                //acceptance of first number

                Console.WriteLine("Please write the second number for the calculation");
                int x = Convert.ToInt32(Console.ReadLine());
                //acceptance of second number
                Console.Write("The numbers minused together are: ");
                int total2 = y - x;
                Console.Write(total2);
                Console.ReadKey();
                //prints subtracted numbers
            }
            else if (userresponce3 == "3")
            {
                Console.WriteLine("Please enter the first number for the calculation");
                int y = Convert.ToInt32(Console.ReadLine());
                //acceptance of first number

                Console.WriteLine("Please write the second number for the calculation");
                int x = Convert.ToInt32(Console.ReadLine());
                //acceptance of second number
                Console.Write("The numbers multiplied together are: ");
                int total3 = y * x;
                Console.Write(total3);
                Console.ReadKey();
                //prints multiplied numbers
            }
            else if (userresponce3 == "4")
            {
                Console.WriteLine("Please enter the first number for the calculation");
                int y = Convert.ToInt32(Console.ReadLine());
                //acceptance of first number

                Console.WriteLine("Please write the second number for the calculation");
                int x = Convert.ToInt32(Console.ReadLine());
                //acceptance of second number
                Console.Write("The numbers divided together are: ");
                int total4 = y / x;
                Console.Write(total4);
                Console.ReadKey();
                //prints numbers divided together
            }
            else if (userresponce3 == "5")
            {
                Console.WriteLine("Please enter the first number for the calculation");
                int y = Convert.ToInt32(Console.ReadLine());
                //acceptance of first number

                Console.WriteLine("Please write the second number for the calculation");
                int x = Convert.ToInt32(Console.ReadLine());
                //acceptance of second number
                Console.Write("The numbers modded together are: ");
                int total5 = y % x;
                Console.Write(total5);
                Console.ReadKey();
                //prints numbers modded together
            }
            else if (userresponce3 == "6")
            {
                Console.WriteLine("Please enter the number you want to square");
                float squarevalue = Convert.ToInt64(Console.ReadLine());
                float squaretotalvalue = squarevalue * squarevalue;
                Console.WriteLine(squaretotalvalue);
                Console.ReadKey();
                //prints square of a number
            }
            else if (userresponce3 == "7")
            {
                Console.WriteLine("Please enter the number you want to cube");
                float cubenumber = Convert.ToInt64(Console.ReadLine());
                float cubetotal = cubenumber * cubenumber * cubenumber;
                Console.WriteLine(cubetotal);
                Console.ReadKey();
                //prints cube of a number
            }
            else if (userresponce3 == "8")
            {
                Console.WriteLine("Please select number "); Double squareroot = Convert.ToInt64(Console.ReadLine());
                double totalsquareroot = Math.Sqrt(squareroot);
                Console.WriteLine("Your square root is " + totalsquareroot);
                Console.ReadKey();
                //the square root of a number
            }
            else
            {
                Console.WriteLine("Do you wish to do a different calculation?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                /// this is a section of code responsible for the validation of the program
                /// and the suggestion of doing a different calculation
                int useranswer = Convert.ToInt32(Console.ReadLine());

                if (useranswer == 1)
                {
                    Console.WriteLine("Please select one from below");
                    Console.WriteLine("Please answer with a number from one of the options.");
                    Console.WriteLine("1. Quadratic Equation");
                }
                else if (useranswer == 2)
                {
                    goto start;
                }
                Console.WriteLine("2. Gradient Value");
                Console.WriteLine("3. Circumference");
                Console.WriteLine("4. Area of a Circle");
                Console.WriteLine("5. Differentiation of sin(x)");
                Console.WriteLine("6. Momentum of an object");
                Console.WriteLine("7. Voltage");
                int useranswer2 = Convert.ToInt32(Console.ReadLine());
                if (useranswer2 == 1)
                {
                    Console.Write("Please enter your A:"); int A = Convert.ToInt32(Console.ReadLine());
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

                }
                else if (useranswer2 == 2)
                {
                    Console.Write("Please enter your first Y:"); Console.WriteLine(); float y2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter your second Y: "); Console.WriteLine();
                    float y22 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter your first X: "); Console.WriteLine(); float x2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter your secondary X:"); Console.WriteLine();
                    float x22 = Convert.ToInt32(Console.ReadLine());
                    Console.ReadKey();
                    //Gradient = Change in Y /  Change in X

                    float diffy = y2 - y22;
                    float diffx = x2 - x22;
                    float grad = diffy / diffx;

                    Console.WriteLine(grad);
                    Console.ReadLine();
                }
                else if (useranswer2 == 3)
                {
                    Console.WriteLine("Please enter your radius in meters"); float radius1 = Convert.ToInt32(Console.ReadLine());
                    //the formula for the circumference  = 2x3.141592654xr
                    float circum = Convert.ToInt32(2 * 3.141592654 * radius1);
                    Console.WriteLine("Your radius is " + circum + " m");
                    Console.ReadKey();
                }
                else if (useranswer2 == 4)
                {
                    Console.WriteLine("Please enter your radius in meters"); float radius2 = Convert.ToInt32(Console.ReadLine());
                    // the formula for the area of a circle = 3.141592654xr^2
                    float squaredradius = Convert.ToInt32(radius2 * radius2);
                    float area = Convert.ToInt32(3.141592654 * squaredradius);
                    Console.WriteLine("Your area is " + radius2 + " m^2"); Console.ReadLine();

                }
                else if (useranswer2 == 5)
                {
                    Console.WriteLine("Please define your constant "); float constant = Convert.ToInt64(Console.ReadLine());
                    ///this is the differentiation of sin(x)#
                    ///y = AsinX
                    ///dy/dx = AcosX
                    ///sin x = x - x^3/3! + x^5/5! - x^7/7! + x^9/9! - x^11/11!
                    ///

                    float constant3 = Convert.ToInt64(Math.Pow(constant, 3));
                    float constant5 = Convert.ToInt64(Math.Pow(constant, 5));
                    float constant7 = Convert.ToInt64(Math.Pow(constant, 7));
                    float constant9 = Convert.ToInt64(Math.Pow(constant, 9));
                    float constant11 = Convert.ToInt64(Math.Pow(constant, 11));
                    // float division =-constant;

                    int i, i2, i3, i4, i5, number, number22, number3, number4, number5, fact, fact2, facto3, fact4, fact5;
                    string three = Convert.ToString(3);
                    string five = Convert.ToString(5);
                    string seven = Convert.ToString(7);
                    string nine = Convert.ToString(9);
                    string eleven = Convert.ToString(11);
                    number = int.Parse(three);
                    number22 = int.Parse(five);
                    number3 = int.Parse(seven);
                    number4 = int.Parse(nine);
                    number5 = int.Parse(eleven);
                    fact = number; fact2 = number22;
                    facto3 = number3; fact4 = number4;
                    fact5 = number5;
                    for (i = number - 1; i >= 1; i--)
                    {
                        fact = fact * i;
                    }
                    float factorial1 = fact;
                    for (i2 = number22 - 1; i2 >= 1; i2--)
                    {
                        fact2 = fact2 * i2;
                    }
                    float factorial2 = fact2;
                    for (i3 = number3 - 1; i3 >= 1; i3--)
                    {
                        facto3 = facto3 * i3;
                    }
                    float factorial3 = facto3;
                    for (i4 = number - 1; i4 >= 1; i4--)
                    {
                        fact4 = fact4 * i4;
                    }
                    float factorial4 = fact4;
                    for (i5 = number5 - 1; i5 >= 1; i5--)
                    {
                        fact5 = fact5 * i5;
                    }
                    float factorial5 = fact5;

                    Console.Write("sin x = " + constant);
                    Console.Write("-" + constant + "^3/3!");
                    Console.Write("+" + constant + "^5/5!");
                    Console.Write("-" + constant + "^7/7!");
                    Console.Write("+" + constant + "^9/9!");
                    Console.Write("-" + constant + "^11/11!");
                    //prints out summary

                    Console.WriteLine("\n");
                    Console.Write("This is equal to sin x = x-" + constant3 + "/" + factorial1);
                    Console.Write("+" + constant5 + "/" + factorial2);
                    Console.Write("-" + constant7 + "/" + factorial3);
                    Console.Write("+" + constant9 + "/" + factorial4);
                    Console.Write("-" + constant11 + "/" + factorial5);
                    //prints out more advanced summary

                    Console.WriteLine("\n");
                    float fini = constant - constant3 / factorial1 + constant5 / factorial2 - constant7 / factorial3 + constant9 / factorial4 - constant11 / factorial5;
                    Console.WriteLine(fini - 0.05);
                    Console.Write("Sin(" + constant + ")=" + fini);
                    Console.Write(fini);
                    Console.ReadKey();
                    //prints out calculation
                }
                else if (useranswer == 6)
                {
                    Console.WriteLine("Please enter your mass");
                    float M = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Please enter your velocity");
                    float V = Convert.ToInt64(Console.ReadLine());
                    float P = M * V;
                    Console.WriteLine("Your momentum is" + P);
                    Console.ReadKey();
                    //prints out momentum of object
                }
                else if (useranswer == 7)
                {
                    Console.WriteLine("Please enter your current in amps");
                    float I = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Please enter your resistance in ohms");
                    float R = Convert.ToInt64(Console.ReadLine());
                    float V = I * R;
                    Console.WriteLine("Your voltage is " + V + "V");
                    Console.ReadKey();
                    //prints out voltage
                }
            }
            }
        }
    }

