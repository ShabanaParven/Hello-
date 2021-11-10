using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityToManageEmpWageOfMulCompanies
{
    
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();

            Console.ReadKey();
        }
        
    }
}
