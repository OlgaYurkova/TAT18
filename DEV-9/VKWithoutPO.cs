using OpenQA.Selenium.Chrome;
using System;

namespace VKWithoutPageObject
{
    class VKWithoutPO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter login:");
            string login = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://vk.com/");

                var userNameField = driver.FindElementById("index_email");
                var userPasswordField = driver.FindElementById("index_pass");
                var loginButton = driver.FindElementByXPath("//button[@id='index_login_button']");
  
                userNameField.SendKeys(login);
                userPasswordField.SendKeys(password);

                loginButton.Click();
            }
        }
    }
}
