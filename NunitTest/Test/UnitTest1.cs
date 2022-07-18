using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitTest
{
    public class Tests
    {
       IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        //[Test]
        [TestCase ("HI"), Order(2)]    
        public void Test1(string me)
        {

            var IsExits = Login.userTextBoxExits(driver);
            if (!IsExits)
                Assert.Fail("User TextBox not Found");
                }

        [Test, Order(1)]
        public void Test2()
        {
            Assert.IsFalse(Login.userTextBoxExits(driver));
        }
        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}