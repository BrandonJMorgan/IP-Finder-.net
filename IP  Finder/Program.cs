using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace IP__Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            string user = "Brandon";
            int age = 21;
            Console.Title = "IP Finder made by " + user + "\t age is \t " + age;
            try
            {
                Console.WriteLine("Enter server name or domain name");
                string name = Console.ReadLine();
                IPHostEntry address = Dns.GetHostEntry(name);
                IPAddress[] ip = address.AddressList;
                string addrss = ip[0].ToString();
                Console.WriteLine("the IP address for the website you entered is\t " + addrss);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

