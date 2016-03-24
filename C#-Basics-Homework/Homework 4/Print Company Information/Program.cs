using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Company_Information
{
    class Program
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string mFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string mLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            int mAge = int.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            string mPhone = Console.ReadLine();

            Console.WriteLine("\nPrint user information:\n{0},\n{1},\n{2},\n{3},\n{4},\n{5},\n{6},\n{7}", companyName, companyAddress, phoneNumber, faxNumber, webSite, mFirstName, mLastName, mPhone);
        }
    }
}
