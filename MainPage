using OpenQA.Selenium;

namespace CSharpTACourse.Pages  
{  
    public class MainPage : BasePage  
    {  
        public MainPage(IWebDriver driver) : base(driver) { }  

        // Локатори  
        public By SearchInput => By.Name("q");  
        public By FilterButton => By.CssSelector("button.collection-filters__submit");  

        // Методи  
        public void SearchForProduct(string query)  
        {  
            Type(SearchInput, query);  
            Click(FilterButton);  
        }  
    }  
}  
