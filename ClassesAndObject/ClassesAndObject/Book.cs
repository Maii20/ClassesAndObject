using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObject
{
    internal class Book
    {
        //we store the data type here 
        //this are class attibutes
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)  //this book method should accept 1 parameter (if we want to pass the arguments)
            //this is the constructor of this class
            /*constructors is basically the special method inside of our class and it is going to get called when we
            create an object of this class*/
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages; 
        }


      

    }
}
