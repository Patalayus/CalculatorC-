using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace CShapPractise
{
    class Program
    {
        enum enps_x86U { J, V, λ, ms1 };
        public void secondary()
        {
            Console.WriteLine("This is the secondary subroutine");
            Console.ReadKey();
            Console.WriteLine("You have called the secondary subroutine");
             //this section will be able to add two numbers together and then times the total by the numbers
            Console.WriteLine("Please enter the first number");
            double enps_x23 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            double enps_x24 = Convert.ToInt32(Console.ReadLine());
            double enps_x23ADDenps_x24 = enps_x23 + enps_x24;
            double enps_x23MULTenps_24 = enps_x23 * enps_x24;
            Console.WriteLine("Your total is " + enps_x23MULTenps_24);
            // this subroutine adds two numbers and multiplies the two numbers
        }
        static void Main(string[] args)
        {
            en3x_1:
            Console.WriteLine("What do you wish to do?");
            Console.WriteLine("1. Add,");
            Console.WriteLine("2. Minus,");
            Console.WriteLine("3. Multiply,");
            Console.WriteLine("4. Divide,");
            Console.WriteLine("5. Mod,");
            Console.WriteLine("6. Square a number,");
            Console.WriteLine("7. Cube a number,");
            Console.WriteLine("8. Find square root of a number,");
            Console.WriteLine("9. Add percentage to something,");
            Console.WriteLine("10. Work out a percentage of something,");
            Console.WriteLine("11. Times or divide a number by 10,100 or 1000,");
            Console.WriteLine("12. Output all odd or even numbers.");

            //option menu 1
            Console.WriteLine("\nPress any key for advanced features.");

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
            else if (userresponce3 == "9")
            {
                //works to add percentage to a number
                Console.WriteLine("You have chosen to add a percentage of something to a number");
                Console.WriteLine("Please specify the number you will be using"); float number1 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Please choose the percentage you are adding.");
                Console.WriteLine("\n1. 25%\n2. 50%\n3. 75%"); float percentageadded = Convert.ToInt64(Console.ReadLine());

                if (percentageadded == 1)
                {
                    Console.WriteLine("25% added to " + number1 + " is " + number1 * 1.25);
                    Console.ReadKey();
                }
                else if (percentageadded == 2)
                {
                    Console.WriteLine("50% added to " + number1 + " is " + number1 * 1.50);
                    Console.ReadKey();
                }
                else if (percentageadded == 3)
                {
                    Console.WriteLine("75% added to " + number1 + " is " + number1 * 1.75);
                    Console.ReadKey();
                }
            }
            if (userresponce3 == "10")
            {
                //works to calculate percentage of a number
                Console.WriteLine("You have selected to work out the percentage of something");
                Console.WriteLine("Please list the number you want to work out the percentage from"); float number2 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Please select the percentage you want to use\n1. 25%\n2. 50%\n3. 75%"); float percentage2 = Convert.ToInt64(Console.ReadLine());

                if (percentage2 == 1)
                {
                    Console.WriteLine("25% of " + number2 + " is " + number2 * 0.25);
                    Console.ReadKey();
                }
                else if (percentage2 == 2)
                {
                    Console.WriteLine("50% of " + number2 + " is " + number2 * 0.50);
                    Console.ReadKey();
                }
                else if (percentage2 == 3)
                {
                    Console.WriteLine("75% of " + number2 + " is " + number2 * 0.75);
                    Console.ReadKey();
                }

            }
            if (userresponce3 == "11")
            {
                //times, divide by 10, 100 or 1000
                Console.WriteLine("You have chosen to times or divide a number by 10,100 or 1000.");
                Console.WriteLine("Please specify which value you would like:");
                Console.WriteLine("1. 10");
                Console.WriteLine("2. 100");
                Console.WriteLine("3. 1000");

                int numberchoice = Convert.ToInt32(Console.ReadLine());

                if (numberchoice == 1)
                {
                    Console.WriteLine("You have chosen the number 10");
                    Console.WriteLine("Do you wish to times or divide your number by 10?");
                    Console.WriteLine("1. Times my number");
                    Console.WriteLine("2. Divide my number");
                    int numberchoice1 = Convert.ToInt32(Console.ReadLine());

                    if (numberchoice1 == 1)
                    {
                        Console.WriteLine("Please enter the number you wish to times by 10");
                        float numbertimes10 = Convert.ToInt32(Console.ReadLine());
                        float numbertimes10total = numbertimes10 * 10;
                        Console.WriteLine(numbertimes10 + " times by ten is " + numbertimes10total);
                        Console.ReadLine();
                        //times a number by 10
                    }
                    if (numberchoice1 == 2)
                    {
                        Console.WriteLine("Please enter the number you wish to divide by 10");
                        float numberdivide10 = Convert.ToInt32(Console.ReadLine());
                        float numberdivide10total = numberdivide10 / 10;
                        Console.WriteLine(numberdivide10 + " divided by ten is " + numberdivide10total);
                        Console.ReadLine();
                        //divide a number by 10
                    }
                }
                if (numberchoice == 2)
                {
                    Console.WriteLine("You have chosen the number 100");
                    Console.WriteLine("Do you wish to times or divide your number by 100?");
                    Console.WriteLine("1. Times my number");
                    Console.WriteLine("2. Divide my number");
                    int numberchoice1 = Convert.ToInt32(Console.ReadLine());

                    if (numberchoice1 == 1)
                    {
                        Console.WriteLine("Please enter the number you wish to times by 100");
                        float numbertimes100 = Convert.ToInt32(Console.ReadLine());
                        float numbertimes100total = numbertimes100 * 100;
                        Console.WriteLine(numbertimes100 + " times by one hundred is " + numbertimes100total);
                        Console.ReadLine();
                        //divide a number by 100
                    }
                    if (numberchoice1 == 2)
                    {
                        Console.WriteLine("Please enter the number you wish to divide by 100");
                        float numberdivide100 = Convert.ToInt32(Console.ReadLine());
                        float numberdivide100total = numberdivide100 / 100;
                        Console.WriteLine(numberdivide100 + " divide by one hundred is " + numberdivide100total);
                        Console.ReadLine();
                        //divide a number by 100
                    }
                }
                if (numberchoice == 3)
                {
                    //user options
                    Console.WriteLine("You have chosen the number 1000");
                    Console.WriteLine("Do you wish to times or divide your number by 1000?");
                    Console.WriteLine("1. Times my number");
                    Console.WriteLine("2. Divide my number");
                    int numberchoice1 = Convert.ToInt32(Console.ReadLine());

                    if (numberchoice1 == 1)
                    {
                        Console.WriteLine("Please enter the number you want to times by 1000");
                        float numbertimes1000 = Convert.ToInt32(Console.ReadLine());
                        float numbertimes1000total = numbertimes1000 * 1000;
                        Console.WriteLine(numbertimes1000 + " times by one thousand is " + numbertimes1000total);
                        Console.ReadLine();
                        //times a number by 1000
                    }
                    if (numberchoice1 == 2)
                    {
                        Console.WriteLine("Please enter the number you want to divide by 1000");
                        float numberdivide1000 = Convert.ToInt32(Console.ReadLine());
                        float numberdivide1000total = numberdivide1000 / 1000;
                        Console.WriteLine(numberdivide1000 + " divide by one thousand is " + numberdivide1000total);
                        Console.ReadLine();
                        //divide a number by 1000
                    }
                }
            }
            else if (userresponce3 == "12")
            {
                Console.WriteLine("You have chosen to output all odd or even numbers.");
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1. Even Number");
                Console.WriteLine("2. Odd Numbers");
                int enps_x354 = Convert.ToInt32(Console.ReadLine());
                if (enps_x354 == 1)
                {
                    //prints even numbers
                    Console.WriteLine("You have chosen to output all even numbers");
                    int even_x324 = 2;
                    int time_x324 = 1;
                    while (true)
                    {
                        Console.WriteLine("Value " + time_x324 + " of even numbers is " + even_x324);
                        even_x324 += 2;
                        time_x324 += 1;
                        Thread.Sleep(500);
                    }
                }
                else if (enps_x354 == 2)
                {
                    //prints odd numbers
                    Console.WriteLine("You have chosen to output all odd numbers");
                    double odd_x355 = 3;
                    double time_x355 = 1;
                    while (true)
                    {
                        Console.WriteLine("Value " + time_x355 + " of odd numbers is " + odd_x355);
                        odd_x355 += 2;
                        time_x355 += 1;
                        Thread.Sleep(500);
                    }
                }
            }
            else
            {
                Console.WriteLine("Do you wish to do a different calculation?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                /// this is a section of code responsible for the validation of the program
                /// and the suggestion of doing a different calculation
                int useranswer2 = Convert.ToInt32(Console.ReadLine());
                if (useranswer2 == 1)
                {

                    Console.WriteLine("Please select one from below");
                    Console.WriteLine("Please answer with a number from one of the options.");
                    Console.WriteLine("1. Quadratic Equation");
                    Console.WriteLine("2. Gradient Value");
                    Console.WriteLine("3. Circumference");
                    Console.WriteLine("4. Area of a Circle");
                    Console.WriteLine("5. Differentiation of sin(x)");
                    Console.WriteLine("6. Momentum of an object");
                    Console.WriteLine("7. Voltage");
                    Console.WriteLine("8. Volume of a Cylinder.");
                    Console.WriteLine("9. Young's Modulus");
                    Console.WriteLine("10. Work out the energy of a moving object");
                    Console.WriteLine("11. Work out the Power in watts of a circuit");
                    Console.WriteLine("12. Work out the change in gravitational potential energy of an object");
                    Console.WriteLine("13. Work out the velocity of a wave given the frequency and wavelength");
                    Console.WriteLine("14. SUVAT");
                    Console.WriteLine("15. Work out efficiency of an object.");
                    Console.WriteLine("16. Work out the current of a circuit in amps.");
                    Console.WriteLine("17. Work out the speed of an object");
                    Console.WriteLine("18. Work out the work done of an object");
                    //option menu 2

                    float useranswer3 = Convert.ToInt32(Console.ReadLine());
                    if (useranswer3 == 1)
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
                    else if (useranswer3 == 2)
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
                    else if (useranswer3 == 3)
                    {
                        Console.WriteLine("Please enter your radius in meters"); float radius1 = Convert.ToInt32(Console.ReadLine());
                        //the formula for the circumference  = 2x3.141592654xr
                        float circum = Convert.ToInt32(2 * 3.141592654 * radius1);
                        Console.WriteLine("Your radius is " + circum + " m");
                        Console.ReadKey();
                    }
                    else if (useranswer3 == 4)
                    {
                        Console.WriteLine("Please enter your radius in meters"); float radius2 = Convert.ToInt32(Console.ReadLine());
                        // the formula for the area of a circle = 3.141592654xr^2
                        float squaredradius = Convert.ToInt32(radius2 * radius2);
                        float area = Convert.ToInt32(3.141592654 * squaredradius);
                        Console.WriteLine("Your area is " + radius2 + " m^2"); Console.ReadLine();
                    }
                    else if (useranswer3 == 5)
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
                        Console.WriteLine(fini);
                        Console.Write("Sin(" + constant + ")=" + fini);
                        Console.Write(fini);
                        Console.ReadKey();
                        //prints out calculation
                    }
                    else if (useranswer3 == 6)
                    {
                        Console.WriteLine("Please enter your mass");
                        float M = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Please enter your velocity");
                        float V = Convert.ToInt64(Console.ReadLine());
                        float P = M * V;
                        Console.WriteLine("Your momentum is " + P);
                        Console.ReadKey();
                        //prints out momentum of object
                    }
                    else if (useranswer3 == 7)
                    {
                        Console.WriteLine("Please enter your current in amps");
                        float I = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Please enter your resistance in ohms");
                        float R = Convert.ToInt64(Console.ReadLine());
                        float V = I * R;
                        enps_x86U enp = enps_x86U.V;
                        Console.WriteLine("Your voltage is " + V + enp);
                        Console.ReadKey();
                        //prints out voltage
                    }
                    else if (useranswer3 == 8)
                    {
                        Console.WriteLine("You have chosen to work out the volume of a cylinder.");
                        Console.WriteLine("Do you have an area or a radius?");
                        Console.WriteLine("1. Area of a Circle");
                        Console.WriteLine("2. Radius of a Circle");
                        int CorR = Convert.ToInt32(Console.ReadLine());
                        //checks user for area or radius
                        if (CorR == 1)
                        {
                            Console.WriteLine("You have chosen an area. Please write your area.");
                            float areaofacircle = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Please write your length.");
                            float lengthofacircle = Convert.ToInt64(Console.ReadLine());
                            float qwer = areaofacircle * lengthofacircle;
                            Console.WriteLine("Your cylinder's volume is " + qwer + "m^3");
                            Console.ReadKey();
                            //works out volume from area
                        }
                        else if (CorR == 2)
                        {
                            Console.WriteLine("You have chosen a radius. Please write your radius.");
                            float radiusofacircle = Convert.ToInt64(Console.ReadLine());
                            float radtimesrad = radiusofacircle * radiusofacircle;
                            float areaofacircle2 = Convert.ToInt32(3.141592654 * radtimesrad);
                            Console.WriteLine("Your area is " + areaofacircle2);
                            Console.WriteLine("Please write your length");
                            float circlelength = Convert.ToInt64(Console.ReadLine());
                            float total_ = areaofacircle2 * circlelength;
                            Console.WriteLine("Your volume is " + total_ + "m^3");
                            Console.ReadKey();
                            //works out volume from radius
                        }
                    }
                    else if (useranswer3 == 9)
                    ///F = KX = Hooke's
                    ///F = MG
                    ///Strain = X / L
                    ///Stress = F / A
                    ///Work Done = F x D on a stretched object
                    ///E = Stress / Strain = F/A//X/L = FL/XA = WK/Vol
                    {

                        Console.WriteLine("You have chosen to work out the Young's Modulus of a material.");
                        Console.Write("Please give your force on the object in newtons: ");
                        double enps_1 = Convert.ToInt32(Console.ReadLine());
                        ///F
                        Console.Write("\nPlease give your crossectional area of the object: ");
                        double enps_2 = Convert.ToInt32(Console.ReadLine());
                        ///A
                        Console.Write("\nPlease give the extension on the object: ");
                        double enps_3 = Convert.ToInt32(Console.ReadLine());
                        ///X
                        Console.Write("\nPlease give the initial length of the object: ");
                        double enps_4 = Convert.ToInt32(Console.ReadLine());
                        ///L
                        double enps_1DIVenps_2 = enps_1 / enps_2;
                        double enps_3DIVenps_4 = enps_3 / enps_4;
                        ///Initial calculations

                        double enps_1DIVenps_2DIVX2enps_3DIVenps_4 = enps_1DIVenps_2 / enps_3DIVenps_4;
                        Console.Write("The Young's Modulus of your object is " + enps_1DIVenps_2DIVX2enps_3DIVenps_4);
                        Console.ReadKey();
                        //Final Calculation = Total print
                    }
                    else if (useranswer3 == 10)
                    {
                        Console.WriteLine("You have chosen to work out the energy of a moving object.");
                        //E=1/2*M(V^2)
                        // energy in joules
                        // mass in grams
                        // velocity in m/s
                        Console.Write("Please state the mass of your object in grams: ");
                        double en1ps_x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please confirm your velocity in m/s: ");
                        double en2ps_x = Convert.ToInt32(Console.ReadLine());
                        double en2ps_x62 = en2ps_x * en2ps_x;
                        double en1ps_x_05 = en1ps_x * 0.5;
                        double en1ps_x_05MULTen2ps_x62 = en1ps_x_05 * en2ps_x62;
                        Console.WriteLine("The energy of your moving object is " + en1ps_x_05MULTen2ps_x62 + "J");
                        Console.ReadKey();
                    }
                    else if (useranswer3 == 11)
                    {
                        Console.WriteLine("You have chosen to work out the power of a circuit.");
                        Console.WriteLine("Please state your voltage.");
                        double enpsx_0 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please state your current.");
                        double enpsx_01 = Convert.ToInt32(Console.ReadLine());
                        //P=VxI
                        double enpsx_0MULTenpsx_01 = enpsx_0 * enpsx_01;
                        Console.WriteLine("Your power in watts is " + enpsx_0MULTenpsx_01 + "W");
                        Console.ReadKey();
                    }
                    else if (useranswer3 == 12)
                    {
                        //Ep=m*g*h
                        Console.WriteLine("You have chosen to work out the change in gravitational energy of an object");
                        Console.WriteLine("Please give your mass in kilograms:");
                        double enps_mx = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please give your gravitational field strength (earths is 9.81) in m/s^2:");
                        double enps_gx = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please give your change in height in meters:");
                        double enps_hx = Convert.ToDouble(Console.ReadLine());
                        //values obtained
                        double enps_mxMULTenps_gxMULTenps_hx = enps_mx * enps_gx * enps_hx;
                        Console.WriteLine("Your total is " + enps_mxMULTenps_gxMULTenps_hx + "J");
                        Console.ReadKey();
                    }
                    else if (useranswer3 == 13)
                    {
                        //V=fλ
                        Console.WriteLine("You have chosen to work out the velocity of a wave");
                        Console.WriteLine("Please give the frequency of the wave (give answer in Hz)");
                        double enps_xf = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please give the wavelength of the wave (give answer in m)");
                        double enps_xλ = Convert.ToDouble(Console.ReadLine());
                        double enps_xfMULTenps_xλ = enps_xf * enps_xλ;
                        //units given for each answer (velocity of wave in m/s^-1)
                        Console.WriteLine("Your total is " + enps_xfMULTenps_xλ + "m/s^-1");
                        Console.ReadKey();
                    }
                    else if (useranswer3 == 14)
                    {
                        /// v=u+at
                        /// s=u*t+1/2*at^2
                        /// s=1/2*(u+v)*t
                        /// v^2=u^2+2*as
                        /// s=vt-1/2*at^2
                        Console.WriteLine("You have chosen to work out the displacement of an object. Please choose a SUVAT method.");
                        Console.WriteLine("1. v=u+at\n2. s=u*t+1/2*at^2\n3. s=1/2*(u+v)*t\n4. v^2=u^2+2*as\n5. s=vt-1/2*at^2");
                        int enps_xANS = Convert.ToInt32(Console.ReadLine());
                        if (enps_xANS == 1)
                        {
                            Console.WriteLine("You have chosen v=u+at");
                            Console.WriteLine("Please enter your initial velocity");
                            double enps_64v = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your acceleration");
                            double enps_64a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your time");
                            double enps_64t = Convert.ToDouble(Console.ReadLine());
                            double enps_TOT64 = enps_64v + enps_64a * enps_64t;
                            Console.WriteLine("Your total is " + enps_TOT64);
                            Console.ReadKey();
                        }
                        else if (enps_xANS == 2)
                        {
                            Console.WriteLine("You have chosen s=u*t+1/2*at^2");
                            Console.WriteLine("Please enter your initial velocity");
                            double enps_32v = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your time");
                            double enps_32t = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your acceleration");
                            double enps_32a = Convert.ToDouble(Console.ReadLine());
                            // s=u*t+1/2*at^2
                            double enps_uMULTt = enps_32v * enps_32t;
                            double enps_tA2 = enps_32t * enps_32t;
                            double enps_TOT32 = enps_uMULTt + 0.5 * enps_32a * enps_tA2;
                            Console.WriteLine("Your total is " + enps_TOT32);
                            Console.ReadKey();
                        }
                        else if (enps_xANS == 3)
                        {
                            Console.WriteLine("You have chosen s=1/2*(u+v)*t");
                            Console.WriteLine("Please enter your initial velocity");
                            double enps_x86INI = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your final velocity");
                            double enps_x86VEL = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your time");
                            double enps_x86TIM = Convert.ToDouble(Console.ReadLine());
                            double enps_x86uADDv = enps_x86INI + enps_x86VEL;
                            double enps_x86TOT = 0.5 * enps_x86uADDv;
                            double enps_x86TOTvP2 = enps_x86uADDv * enps_x86TIM;
                            Console.WriteLine("Your total is " + enps_x86TOTvP2);
                            Console.ReadKey();
                            //s=1/2*(u+v)*t
                        }
                        else if (enps_xANS == 4)
                        {
                            Console.WriteLine("You have chosen v^2=u^2+2*as");
                            Console.WriteLine("Please enter your initial velocity");
                            double enps_x128v = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your acceleration");
                            double enps_x128a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your displacement");
                            double enps_x128s = Convert.ToDouble(Console.ReadLine());
                            //v^2=u^2+2*as
                            double enps_x128vMULTenps_x128v = enps_x128v * enps_x128v;
                            double enps_x128aMULTenps_x128s = enps_x128a * enps_x128s;
                            double enps_x120TOT = enps_x128vMULTenps_x128v + 2 * enps_x128aMULTenps_x128s;
                            Console.WriteLine("Your total is " + enps_x120TOT + "^2");
                            Console.ReadLine();
                        }
                        else if (enps_xANS == 5)
                        {
                            Console.WriteLine("You have chosen s=vt-1/2*at^2");
                            Console.WriteLine("Please enter your final velocity");
                            double enps_x255v = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your time");
                            double enps_x255t = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your acceleration");
                            double enps_x255a = Convert.ToDouble(Console.ReadLine());
                            //s=vt-1/2*at^2
                            double enps_vMULTt = enps_x255v * enps_x255t;
                            double enps_tMULTt = enps_x255t * enps_x255t;
                            double enps_x255TOT = enps_vMULTt - 0.5 * enps_x255a * enps_tMULTt;
                            Console.WriteLine("Your total is " + enps_x255TOT);
                            Console.ReadLine();
                        }
                    }
                    else if (useranswer3 == 15)
                    {
                        Console.WriteLine("You have chosen to work out the efficiency of an object\nPlease give theoretical useful energy out in joules.");
                        double enps_EO_ = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please give your theoretical total for energy output in joules.");
                        double enps_TE_ = Convert.ToDouble(Console.ReadLine());
                        double enps_ET_ = enps_EO_ / enps_TE_;
                        double enps_ET2_ = enps_ET_ * 100;
                        Console.WriteLine("Your efficiency is " + enps_ET2_ + "%");
                        Console.ReadKey();
                    }
                    else if (useranswer3 == 16) {
                        Console.WriteLine("You have chosen to work out the current in a circuit\nPlease give your charge in coulombs");
                        double enps_x645C = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please give your time in seconds");
                        double enps_x645T = Convert.ToInt64(Console.ReadLine());
                        double enps_x645AL = enps_x645C / enps_x645T;
                        Console.WriteLine("Your total is " + enps_x645AL + "A");
                        Console.ReadKey();
                    }
                    else if(useranswer3 == 17){
                        Console.WriteLine("You have chosen to work out the speed of an object");
                        Console.WriteLine("Please specify which equation you want to use\n1.S=D/T\n2.T=D/S\n3.D=SxT");
                        double enps_SDT1 = Convert.ToDouble(Console.ReadLine());
                        if(enps_SDT1 == 1){
                            Console.WriteLine("You have chosen to work out the speed of a object");
                            Console.WriteLine("Please declare your distance");
                            double enps_D1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please declare your time");
                            double enps_T1 = Convert.ToDouble(Console.ReadLine());
                            double enps_S1 = enps_D1 / enps_T1;
                            Console.WriteLine("Your speed is "+enps_S1);
                            Console.ReadKey();
                        }
                        if (enps_SDT1 == 2){
                            Console.WriteLine("You have chosen to work out the time for an object to cover a distance");
                            Console.WriteLine("Please declare your distance");
                            double enps_D2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please declare your time");
                            double enps_S1 = Convert.ToDouble(Console.ReadLine());
                            double enps_T2 = enps_D2 / enps_S1;
                            Console.WriteLine("Your time is "+enps_T2);
                            Console.ReadKey();
                        }
                        if (enps_SDT1 == 3) {
                            Console.WriteLine("You have chosen to work out the distance an object will travel");
                            Console.WriteLine("Please declare your speed");
                            double enps_S3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please declare your time");
                            double enps_T3 = Convert.ToDouble(Console.ReadLine());
                            double enps_D3 = enps_S3 * enps_T3;
                            Console.WriteLine("Your total distance is " + enps_D3);
                            Console.ReadKey();
                        }   
                    }
                    else if (useranswer3 == 18)
                    {
                        Console.WriteLine("You have chosen to work out the work done of an object");
                        Console.WriteLine("Please give your force applied to the object in newtons.");
                        double enps_xf1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please give your distance of which the object moved. Note that this distance is in the same direction of the force. Give distance in metres");
                        double enps_xd1 = Convert.ToDouble(Console.ReadLine());
                        double enps_xf1MULTxd1 = enps_xf1 * enps_xd1;
                        Console.WriteLine("Your total work done is "+enps_xf1MULTxd1+"J");
                        Console.ReadKey();
                    }
                    else if (useranswer3 == 2)
                    {
                        goto en3x_1;
                    }
                }
            }
                }
            }
        }
    





