using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace MTelegaNordeaHomeWork_2.UserStoryTestCases
{
    public abstract class BaseTest
    {
        #region Statics

        private const string Url = "http://ogloszenia.trojmiasto.pl/motoryzacja-sprzedam/";

        #endregion

        #region Fields

        protected IWebDriver driver;

        #endregion

        #region Constructors and Destructors
        
        protected BaseTest(string testName)
        {
            Prepare(testName);
        }
        
        #endregion
        
        #region Prepare

        private void Prepare(string testName)
        {
            AddTestLogMessage("\nStarting Test: " + testName);
            AddTestLogMessage("[PREPARE]");
            driver = new FirefoxDriver();
            driver.Url = Url;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            AddTestLogMessage("Prepare successfully finished!");
        }

        #endregion

        #region Run

        public virtual void Run()
        {
            AddTestLogMessage("[RUN]");
        }
                
        #endregion

        #region Clean

        public void Clean()
        {
            AddTestLogMessage("[CLEAN]");
            AddTestLogMessage("Test is finished. Press any key...");
            Console.ReadKey();
            driver.Close();
        }

        #endregion

        #region Logging method

        protected void AddTestLogMessage(string message)
        {
            Console.WriteLine(DateTime.Now.ToString() + ": " + message);
        }

        #endregion

    }
}
