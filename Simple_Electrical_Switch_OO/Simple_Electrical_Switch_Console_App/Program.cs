using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple_Electrical_Switch_OO;

namespace Simple_Electrical_Switch_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch temp_switch = new Switch();
            Console.WriteLine("Please Enter Your Input");
            string input = Console.ReadLine();
            string lower_case_input = input.ToLower();
            if (Enum.IsDefined(typeof(Status), lower_case_input))
            {
                Status temp_status = (Status)Enum.Parse(typeof(Status), lower_case_input);
                temp_switch.Switch_status = temp_status;
            }
            else
            {
                throw new Exception("Invalid input... Please Check the input");
            }
            temp_switch.Set_Switch_Status();
            Console.WriteLine(temp_switch);
        }
    }
}
