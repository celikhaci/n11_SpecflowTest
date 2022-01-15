using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumProject.StepDefination
{

    [Binding]
    class StepDefination
    {
        IWebDriver wedriver;


        [Given(@"Url ""(.*)"" adresine tıklanır\.")]
        public void GivenUrlAdresineTıklanır_(string url)
        {

            wedriver = new ChromeDriver(@"C:\WebDriver\bin");
            wedriver.Manage().Window.Maximize();
            wedriver.Navigate().GoToUrl(url);
            
        }

        [When(@"Kullanıcı giris yap butonuna tıklar on ""(.*)""")]
        public void WhenKullanıcıGirisYapButonunaTıklarOn(string value)
        {
            IWebElement webElement = wedriver.FindElement(By.CssSelector(value));
            webElement.Click();
        }




        [When(@"Kullanıcı adı girilir ""(.*)"" on ""(.*)""")]
        public void WhenKullanıcıAdıGirilirOn(string text, string identifier)
        {
            IWebElement webElement = wedriver.FindElement(By.Id(identifier));
            webElement.SendKeys(text);
        }

        [When(@"Şifre girilir ""(.*)"" on ""(.*)""")]
        public void WhenSifreGirilirOn(string text, string value)
        {
            IWebElement webElement = wedriver.FindElement(By.Id(value));
            webElement.SendKeys(text);
        }

        [When(@"Kullanıcı giriş yap butonuna tıklar on ""(.*)""")]
        public void ThenKullanıcıGirisYapButonunaTıklarOn(string value)
        {
            IWebElement webElement = wedriver.FindElement(By.Id(value));
            webElement.Click();

        }
        [Then(@"Site Kapanır")]
        public void ThenKullanıcıSiteyiKapatır()
        {
            wedriver.Close();
        }



    }
}
