using System;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;


class Scraper : Attribute
{
    private string url;
    public Scraper(string url)
    {
        this.url = url;
    }

    public void SetUrl(String url)
    {
        this.url = url;
        
    }
    public void ShowTitle()
    {
        using (IWebDriver driver = new ChromeDriver())
        {
            driver.Navigate().GoToUrl(url);
            Console.WriteLine(driver.Title);
        }
    }

    public void ShowjScript()
    {
        using (IWebDriver driver = new ChromeDriver())
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl(url);
            wait.Until(webDriver => webDriver.FindElement(By.CssSelector("h2>div")).Displayed);
            Console.WriteLine(driver.PageSource);
        }

    }

    public void example()
    {
        using (IWebDriver driver = new ChromeDriver())
        {
            driver.Url = "https://www.google.com/ncr";
            driver.FindElement(By.Name("q")).SendKeys("cheese" + Keys.Enter);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement firstResult = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("h3")));
            Console.WriteLine(firstResult.Text);
        }
    }

    public Product Sainsexample()
    {
        using (IWebDriver driver = new ChromeDriver())
        {
            driver.Url = this.url;
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Name = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"root\"]/div[2]/div[2]/div[2]/div/section[2]/ul/li[1]/div/div/div[2]/div[1]/div[1]/div[1]/div[1]/h2")));
            IWebElement Price = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"root\"]/div[2]/div[2]/div[2]/div/section[2]/ul/li[1]/div/div/div[2]/div[1]/div[2]/div[2]/div")));
            Product product = new Product(Name.Text, Price.Text, driver.Title);
            Console.WriteLine(Name.Text);
            Console.WriteLine(Price.Text);
            return product;
        }
        
    }
}

