using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace webScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (IWebDriver driver = new ChromeDriver())
            {
                String url = "https://www.sainsburys.co.uk/gol-ui/SearchDisplayView?filters[keyword]=cherry%20bakewell";
                driver.Navigate().GoToUrl(url);
                var elements = driver.FindElement(By.XPath("//*"));
                
                Console.WriteLine(elements.GetAttribute("textContent"));
                /*
                var questions = driver.FindElements(By.ClassName("question-hyperlink"));

                foreach (var question in questions)
                {
                    // This will display every question header on StackOverflow homepage.
                    Console.WriteLine(question.Text);
                }
                */
            }
            Console.WriteLine("Hello World!");
        }
    }
}
