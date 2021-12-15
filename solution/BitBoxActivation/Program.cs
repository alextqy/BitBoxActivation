using Service;
using System;

namespace BitBoxActivation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tools.CorrectConsole("Enter the verification code:");
                var EncryptedCode = Console.ReadLine();
                Tools.CorrectConsole("Enter the number of people:");
                var NumberOfAccounts = Convert.ToInt32(Console.ReadLine());

                var DeCode = Tools.AES_Decrypt(EncryptedCode, 1); // 解密
                var DeCodeArr = Tools.Explode("_", DeCode);
                DeCodeArr[2] = (Tools.StrToInt(DeCodeArr[2]) + NumberOfAccounts).ToString(); // 计算总账号数
                var EnCode = Tools.Implode("_", DeCodeArr);
                Console.WriteLine(Tools.AES_Encrypt(EnCode, 2));
            }
            catch (Exception e)
            {
                Tools.WarningConsole(e.Message);
                return;
            }
        }
    }
}
