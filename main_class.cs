using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace DelAnydesk
{
    class MainClass
    {
        static void Main(string[] args)
        {
        	string userName = Environment.UserName;
        	//Console.WriteLine(userName);
            string subPath_0 = @"C:/ProgramData/AnyDesk/";
            string subPath_1 = @"C:/Users/"+userName+"/AppData/Roaming/AnyDesk/";//C:\Users\user\AppData\Roaming\AnyDesk

            try
            {
            	System.Diagnostics.Process.Start("taskkill", "/F /IM anydesk.exe* /T");
                Directory.Delete(subPath_0, true);
                bool subDirectoryExists_2 = Directory.Exists(subPath_0);
                MessageBox.Show("Из ProgramData удален");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибки: {0}", e.Message);
                MessageBox.Show("Из ProgramData не удален");
            }
            try
            {  
                Directory.Delete(subPath_1, true);
                bool subDirectoryExists_1 = Directory.Exists(subPath_1);
                MessageBox.Show("Из Roaming удален");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибки: {0}", e.Message);
                MessageBox.Show("Из Roaming не удален");
            }
        }
	}
}



//C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe main_class.cs