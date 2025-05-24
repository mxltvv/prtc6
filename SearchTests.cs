using NUnit.Framework;  
using OpenQA.Selenium;  
using CSharpTACourse.Pages;  

namespace CSharpTACourse.Tests  
{  
    [TestFixture]  
    public class SearchTests : BaseTest  
    {  
        [Test]  
        public void SearchForCarolChristianPoell()  
        {  
            var mainPage = new MainPage(Driver);  
            mainPage.SearchForProduct("Carol Christian Poell");  
            Assert.IsFalse(Driver.PageSource.Contains("No results found"));  
        }  
    }  
}  
