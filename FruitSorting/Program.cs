using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSorting
{
    //This is the class which is Fruitkind
    class Fruitkind
        {
        public string kind;
        public string colour;
        public string age;

        //This method in the class of Fruitkind displays the values of the object
        public void Final()
        {
            Console.WriteLine("The type of fruit is {0}", kind);
            Console.WriteLine("The shape of the fruit is {0}", colour);
            Console.WriteLine("The age of the fruit is {0}", age);
        }

        // This method in the class of Fruitkind gets the users input for the kind, colour and age of the fruit
        public void Getfruit()
        {
            Console.WriteLine("Enter the type of fruit you have.");
            kind = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the colour of the fruit.");
            colour = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the age of the fruit.");
            age = Convert.ToString(Console.ReadLine());
        }
    }
    class Program
    {
        //This is the main method which starts the program
        static void Main(string[] args)
        {

            Fruitkind a = new Fruitkind();
            a.Getfruit();
            a.Final();

            Console.ReadLine();
        }
    }
}
