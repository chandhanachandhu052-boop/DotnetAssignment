using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Threading;
using System.Xml.Linq;

namespace ConsoleAppControlStatementAssig2
{
    internal class ControlStatements
    {
        static void Main(string[] args)
        {
            //write a c# program to read the age of a candidate and determine wheather it is eligible
            //for casting his/her vote

            ////printing and taking input from the user
            //Console.Write("Enter the age:");
            //int Age = int.Parse(Console.ReadLine());


            ////checking the condition
            //if (Age >= 18)
            //{
            //    Console.WriteLine("candidate is eligible for vote");
            //}
            //else
            //{
            //    Console.WriteLine("candidate is not eligible for vote");
            //}
            //Console.ReadKey();

            //OR

            //byte age = 0;
            //Console.WriteLine("===Voter Eligibilty Choice===");
            //Console.WriteLine("Min voting age is 18 years");
            //Console.WriteLine("-----------------------------");

            ////Keep asking unil valid byte input is received

            //while (true)
            //{
            //    Console.Write("Enter your age(0-255)");
            //    String input = Console.ReadLine();

            //    //Try to parse the input as byte
            //Checks whether input is a valid number

            //Checks whether it fits in byte range(0–255)

            //If valid → stores value in age
            //    if (byte. TryParse(input,out age))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid plz eneter a number betwwen 0  and 55");
            //    }

            //    //Check eligibilty
            //    if (age >= 18)
            //    {
            //        Console.WriteLine("candidate is eligible for vote");
            //    }
            //    else
            //    {
            //        Console.WriteLine("candidate is not eligible for vote");
            //    }
            //    Console.ReadKey();

            //}

            //2.Write a C# program to accept a coordinate point in an XY coordinate system and determine in which quadrant the
            //coordinate point lies.

          

            int x, y;

            //validation for x
            while (true)
            {
                Console.Write("Enter the value of x:");

                //Reads input as string, Checks if it is a valid integer, If valid → stores value in x

               
                if (int.TryParse(Console.ReadLine(), out x))
                    break;

                else
                    Console.WriteLine("Invalid input! Please enter an integer value for x.");
            }
            //validation for y
            while (true)
            {
                Console.Write("Enter the value of y:");


                if (int.TryParse(Console.ReadLine(), out y))
                    break;

                else
                    Console.WriteLine("Invalid input! Please enter an integer value for x.");
            }

            //checking in which qudrant x and y present

            if (x > 0 && y > 0)
            {
                Console.WriteLine("The entered x and y is on the first quatrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The entered x and y is on the second quatrant ");

            }
            else if (x < 0 && y < 0)
            {

                Console.WriteLine("The entered x and y is on the third quatrant ");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The entered x and y is on the fourth quatrant ");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("The entered x and y is on the orgin ");

            }
            Console.ReadKey();







            //3.Write a C# program to read roll no, name and marks of
            //three subjects and calculate the total, percentage and   division


            //displaying in the console and waiting for user input like roll no,name,marks of 3 sub
            //Console.Write("Enter the roll number:");
            //int num = int.Parse(Console.ReadLine());

            //Console.Write("Enter the name:");
            //String name = Console.ReadLine();

            //Console.Write("Enter the marks of first subject:");
            //int mark1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the marks of second subject:");
            //int mark2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the marks of third subject:");
            //int mark3 = int.Parse(Console.ReadLine());

            int num;
            string name;
            int mark1, mark2, mark3;

            // Roll number validation
            while (true)
            {
                Console.Write("Enter the roll number: ");
                if (int.TryParse(Console.ReadLine(), out num) && num > 0)
                    break;
                else
                    Console.WriteLine("Invalid input! Roll number must be a positive integer.");
            }

            // Name input
            Console.Write("Enter the name: ");
            name = Console.ReadLine();

            // Marks validation (for each subject)
            while (true)
            {
                Console.Write("Enter the marks of first subject (0-100): ");
                if (int.TryParse(Console.ReadLine(), out mark1) && mark1 >= 0 && mark1 <= 100)
                    break;
                else
                    Console.WriteLine("Invalid input! Marks must be between 0 and 100.");
            }

            while (true)
            {
                Console.Write("Enter the marks of second subject (0-100): ");
                if (int.TryParse(Console.ReadLine(), out mark2) && mark2 >= 0 && mark2 <= 100)
                    break;
                else
                    Console.WriteLine("Invalid input! Marks must be between 0 and 100.");
            }

            while (true)
            {
                Console.Write("Enter the marks of third subject (0-100): ");
                if (int.TryParse(Console.ReadLine(), out mark3) && mark3 >= 0 && mark3 <= 100)
                    break;
                else
                    Console.WriteLine("Invalid input! Marks must be between 0 and 100.");
            }

            ////calculating the total marks and displaying the total marks
            //int total = mark1 + mark2 + mark3;
            //Console.WriteLine( total);

            ////calculating the percentage and displaying the total marks
            //int percentage = (total / 300) * 100;
            //Console.WriteLine(percentage);
            ////giving condition for marks with grade
            //if (total <= 50)
            //{
            //    Console.Write("Grade is E");
            //}else if (total > 60 && total <= 70)
            //{
            //    Console.Write("Grade is D");

            //}else if (total > 70 && total <= 80)
            //{
            //    Console.Write("Grade is C");
            //}
            //else if (total > 80 && total <= 90)
            //{
            //    Console.Write("Grade is B");
            //}else if(total > 80 && total <= 90)
            //{
            //    Console.Write("Grade is A");
            //}
            ////pause the program
            //  Console.ReadKey();

            //3.Write a C# program to find the eligibility of admission for
            //a professional course based on the following criteria:
            //Marks in Maths >= 65
            //Marks in Phy >= 55
            //Marks in Chem >= 50
            //Total in all three subject >= 180
            //or
            //Total in Math and Subjects >= 140

            //displaying in console and wating for user input mark of maths,phy and chem
            //Console.Write("Enter the mark for maths:");
            //int mathMark = int.Parse(Console.ReadLine());

            //Console.Write("Enter the mark for phy:");
            //int phyMark = int.Parse(Console.ReadLine());

            //Console.Write("Enter the mark for chem:");
            //int chemMark = int.Parse(Console.ReadLine());

            ////calculating total marks of 3 subject
            //int totalMark = mathMark + phyMark + chemMark;
            //Console.WriteLine("total marks:"+totalMark);
            ////calculating maeks in maths and phy
            //int totalMathsPhy = mathMark + phyMark; ;
            //Console.WriteLine("total marks ofmaths and physics:"+totalMathsPhy);
            ////providing the conditin
            //if (mathMark >= 65 && phyMark >= 55 && chemMark >= 50 && (totalMark >= 180 || totalMathsPhy >= 140))
            //{
            //    Console.Write("Eligible for admission");

            //}
            //else 
            //{
            //    Console.Write(" Not Eligible for admission");
            //}

            //Console.ReadKey();

            //5.Write a program in C# which is a Menu-Driven Program  to compute the area of the various geometrical shape

            int choice;
            do
            {
                Console.WriteLine("\n--- AREA MENU ---");
                Console.WriteLine("1. Area of Circle");
                Console.WriteLine("2. Area of Rectangle");
                Console.WriteLine("3. Area of Triangle");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter radius: ");
                    double r = double.Parse(Console.ReadLine());
                    double area = 3.14 * r * r; ;
                    Console.WriteLine("Area of Circle = " + area);
                }
                else if (choice == 2)
                {
                    Console.Write("Enter length: ");
                    double l = double.Parse(Console.ReadLine());
                    Console.Write("Enter breadth: ");
                    double b = double.Parse(Console.ReadLine());
                    double area = l * b;
                    Console.WriteLine("Area of Rectangle = " + area);
                }
                else if (choice == 3)
                {
                    Console.Write("Enter base: ");
                    double baseT = double.Parse(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double h = double.Parse(Console.ReadLine());
                    double area = 0.5 * baseT * h;
                    Console.WriteLine("Area of Triangle = " + area);
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Exiting program...");
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }

            } while (choice != 4);


            // 4.Write a program in C# to calculate and print the
            // Electricity bill of a given customer. The customer id.,
            //name and unit consumed by the user should be taken
            //from the keyboard and display the total amount to pay
            //to the customer.The charge are as follow

            double bill, rate;

            Console.Write("Enter the Customerid:");
            int customerId = int.Parse(Console.ReadLine());
            Console.Write("Enter the name of customer:");
            int customerName = int.Parse(Console.ReadLine());
            Console.Write("Enter the unit consumed:");
            int unit = int.Parse(Console.ReadLine());

            bill = unit * rate;


            if (unit <= 199)
            {
                rate = 1.20;
            }
            else if (unit > 200 && unit < 400)
            {
                rate = 1.50;
            }
            else if (unit >= 400 && unit < 600)
            {

                rate = 1.80;
            }
            else if (unit > 600)
            {
                rate = 1.80;
            }

        }
    }
}
