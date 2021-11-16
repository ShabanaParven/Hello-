using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogApp
{
    public class Addition
    {
        static NLog nLog = new NLog();
        public static int Add(int firstNumber, int secodNumber)
        {
            int sum = 0;
            try
            {
                if (firstNumber == 0 || secodNumber == 0)
                {
                    nLog.LogDebug("debug successfully");
                    nLog.LogError("First number or second number is zero");
                    nLog.LogInfo("Add method");
                    return 0;
                }
                sum = firstNumber + secodNumber;
                nLog.LogInfo("Additio method executed");
                nLog.LogDebug("Debug successfully");
                nLog.LogWarn("first number or second number is not equal to zero");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return sum;

        }
        
    }
}
