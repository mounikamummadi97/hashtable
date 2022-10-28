// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections;
namespace demo
{
    class program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("092", "tom");
            ht.Add("012", "jerry"); 
           //
           //
           ICollection key =ht.Keys;
            foreach(string k in key)
            {
                Console.WriteLine(k+":" + ht[k]);
            }
        }
    }
}
