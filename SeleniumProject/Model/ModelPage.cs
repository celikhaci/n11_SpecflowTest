using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumProject.Model
{
    public class ModelPage
    {
        IWebDriver driver;
        WebDriverWait wait;

        public ModelPage(IWebDriver driver)
        {
            this.driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public IWebElement FindElement(By by)
        {

            return driver.FindElement(by);
        }

        public void ClickElement(By by)
        {
            FindElement(by).Click();
        }

        public void SendKeys(By by, string value)
        {
            FindElement(by).SendKeys(value);
        }


    }
}

