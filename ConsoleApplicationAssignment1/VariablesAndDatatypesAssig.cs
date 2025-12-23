using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace ConsoleApplicationAssignment1
{
    internal class VariablesAndDatatypesAssig
    {
        static void Main(string[] args)
        {

            //Write a C# Sharp program that takes userid and 
            //password as input (type string). After 3 wrong attempts,
            //user will be rejected.
          
          

            //string correctUserId = "chandhu";
            //string correctPassword = "12345";
            //int attempts = 0;

            //while (attempts <= 3)
            //{
            //    Console.Write("Enter User ID : ");
            //    string userId = Console.ReadLine();

            //    Console.Write("Enter Password : ");
            //    string password = Console.ReadLine();

            //    if (userId == correctUserId && password == correctPassword)
            //    {
            //        Console.WriteLine("Login Successfully");
            //        return;
            //    }
            //    else
            //    {
            //        attempts++;
            //        Console.WriteLine("Wrong credentials!");
            //    }
            //}

            //Console.WriteLine("User rejected. Maximum attempts reached.");
            //Console.ReadKey();





            //2.Write a C# Sharp program that takes distance and time 
            //as input and displays the speed in kilometers per hour
            //and miles per hour.

            ////it is used to display in console
            //Console.Write("Enter the distance :  ");
            ////expecting  the input from useer and stored in a variable ,Readline gives string its converted to doouble
            //double distance = double.Parse(Console.ReadLine());

            ////it is used to display in console
            //Console.Write("Enter the time : ");

            //// coverting to double , readline expecting an input and returns a string so it is coverted
            //double time = double.Parse(Console.ReadLine());

            ////speed is calculated and stored in variabl speedKilometers
            //double speedKilometers = distance / time;
            //double speedPerHour = speedKilometers * 0.621371;

            ////displaying
            //Console.WriteLine("speed in kilometershours :" + speedKilometers);
            //Console.WriteLine("speed in milesperhours : " + speedPerHour);
            ////used for pausing
            //Console.ReadKey();

            ////3.Write a C# Sharp program that takes a number and a 
            ////width also a number, as input and then displays a
            ////triangle of that width, using that number

            //it is used to display in console
            Console.Write("Enter the number : ");
            //expecting the input from useer
            int num = int.Parse(Console.ReadLine());
            //it is used to display in console
            Console.Write("Enter the width : ");
            int wid = int.Parse(Console.ReadLine());
            //outer loop for row count
            for (int i = 1; i <= wid; i++)
            {
                // inner loop for no:of times to print
                for (int j = 1; j <= i; j++)
                {
                    //provided inside the innerloop bcz Prints the number on the same line.
                    Console.Write(num);
                }
                //provided outside the loop to move to next line
                Console.WriteLine();
            }


            //to pause
            Console.ReadKey();


            //4.Write a C# program to display cerain values of the function x==y2+2y+1(using integer for y,ranging
            //ImportedFromTypeLibAttribute -5 to +5)

            //int x;
            //for(int y = -5; y <= 5; y++)
            //{
            //    x = (y * y) + (2 * y) + 1;
            //    Console.WriteLine("y" + y + ",x=" + x);
            //    Console.ReadKey();
            //}
        }



    }
}
