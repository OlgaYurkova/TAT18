using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VKWD
{
    [TestClass]
    public class VKTest
    {
        [TestMethod]
        public void Registration()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://vk.com/");

            var userNameField = browser.FindElement(By.Id("index_email"));
           
            var userPasswordField = browser.FindElement(By.Id("index_pass"));
           
            var loginButton = browser.FindElement(By.Id("index_login_button"));

            userNameField.SendKeys("12345678");
            userPasswordField.SendKeys("12345678");

            loginButton.Click();
        }
    }
}
