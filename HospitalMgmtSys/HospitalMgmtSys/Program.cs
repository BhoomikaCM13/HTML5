using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMgmtSys
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AdminPL adminPL = new AdminPL();
            adminPL.MainMenu();
            Console.Read();
        }
    }
}
