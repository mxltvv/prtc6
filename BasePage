using OpenQA.Selenium;

namespace CSharpTACourse.Pages  
{  
    public class BasePage  
    {  
        protected IWebDriver Driver;  

        public BasePage(IWebDriver driver)  
        {  
            Driver = driver;  
        }  

        // Загальні методи (навігація, клік, введення тексту)  
        public void Click(By locator) => Driver.FindElement(locator).Click();  
        public void Type(By locator, string text) => Driver.FindElement(locator).SendKeys(text);  
    }  
}  
