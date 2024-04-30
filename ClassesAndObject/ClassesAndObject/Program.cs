using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObject //plus a constructors method
{
    //we will be dealing with all types of data. sometimes, when we want to work and represent different thing 
    //such as text , characters, numbers, decimals, double and float, boolean.
    //classes and objects allows us to create our own custom data types. By default like string, numbers and booleans.
    //we can also create ou own data type to represent something inside the programs.

    //When we want to create a data type in c#, it is called something called "class"
    //class is just a specification for the new data type.

    internal class Program
    {
        static void Main(string[] args) //contains main method where we can call class and method
        {
            //we create a book object (object is an instance of that class)
            Book book1 = new Book("Harry Potter", "JK ROwling",400); // this is by using constructors (constructors is very powerful)
            //book1 is a variable that store the Book class.
            //book1.title = "Harry Potter";
            //book1.author = "JK ROwling";
            //book1.pages = 400;

            Console.WriteLine(book1.title + "\n"+book1.author + "\n" + book1.pages);
            //Console.WriteLine(book1.author);
            //Console.WriteLine(book1.pages);

            Book book2 = new Book("Lord of the Ring", "Tolkein", 700); //if we pass parameter from constructor then the Book constructor shall have arguments/data
            //book1 is a variable that store the Book class.
            //book2.title = "Lord of the Ring";
            //book2.author = "Tolkein";
            //book2.pages = 700;

            Console.WriteLine(book2.title + "\n" + book2.author + "\n" + book2.pages);
            //Console.WriteLine(book2.author);
            //Console.WriteLine(book2.pages);

            Console.ReadLine();
        }
    }
}
