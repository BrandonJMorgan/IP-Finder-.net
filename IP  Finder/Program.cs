using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; // allows for socket programming 

namespace IP__Finder // name of application
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green; // changes text color
            string user = "Brandon"; 
            int age = 21;
            Console.Title = "IP Finder made by " + user + "\t age is \t " + age; // display Var information 
            try // try and cath methods 
            {
                Console.WriteLine("Enter server name or domain name"); // tells user to enter domian name
                string name = Console.ReadLine(); // sets a variable to the value the user types in 
                IPHostEntry address = Dns.GetHostEntry(name); // takes the name of the domain and finds the address 
                IPAddress[] ip = address.AddressList; // turns the IP address into byte data 
                string addrss = ip[0].ToString(); // turns the byte into a string (readable text)
                Console.WriteLine("the IP address for the website you entered is\t " + addrss); // displays the IP address 
                Console.ReadLine(); // allows your to read the result before closing 
            }
            catch (Exception ex) // method to capture the exception and write it to the console if any thing was to go wrong 
            {
                Console.WriteLine(ex); //writes the error
            }
        }
    }
}

