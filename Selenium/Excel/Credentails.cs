using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Selenium.Excel
{
   public  class Credentails
    {
        public  string userName = "";
        public  string pass = "";
        public Credentails()
        {
           
           
                ExcelOperations.PopulateInCollection(@"C:\Users\Amit\Desktop\Amit.xlsx");
               userName = ExcelOperations.ReadData(1, "userName");
                Console.WriteLine("userName"+userName);
               pass = ExcelOperations.ReadData(1, "password");
                Console.WriteLine("password"+pass);

                
            
           

        }//

        



    }
}
