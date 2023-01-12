using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagement
{
    internal class Program
    {
 public static void Main(string[] args)
        {
            Console.WriteLine("welcome to the address book");
            Address address = new Address();
            //address.Entry();
            //address.Edit();
            address.RemoveDetails();
        }
    }
}
