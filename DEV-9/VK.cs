using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace DEV_9
{
    class VK
    {
        static void Main()
        {
          Console.WriteLine("Enter login: ");
          string login = Console.ReadLine();
          Console.WriteLine("Enter password: ");
          string password = Console.ReadLine();

          LoginPage loginPage = new LoginPage();
          loginPage.loginInformation(login, password);
        }
    }
}
