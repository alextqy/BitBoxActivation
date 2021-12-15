using Service;
using System;

namespace ActivationDetection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tools.CorrectConsole("Enter the verification code:");
                var Code = Console.ReadLine();
                Tools.CorrectConsole("Enter the CodeType:");
                var CodeType = Convert.ToInt32(Console.ReadLine());
                Tools.CorrectConsole(Tools.AES_Decrypt(Code, CodeType));
            }
            catch (Exception e)
            {
                Tools.WarningConsole(e.Message);
                return;
            }
        }
    }
}
