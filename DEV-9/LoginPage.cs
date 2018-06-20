using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace DEV_9
{
    class LoginPage
    {
        IWebDriver driver = new ChromeDriver();   
             
        public void loginInformation(string login, string password)
      {
         driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

         driver.Navigate().GoToUrl("https://vk.com/");

         driver.FindElement(By.Id("index_email")).SendKeys(login); 
         driver.FindElement(By.Id("index_pass")).SendKeys(password + Keys.Enter);          
      }          
   }
}
