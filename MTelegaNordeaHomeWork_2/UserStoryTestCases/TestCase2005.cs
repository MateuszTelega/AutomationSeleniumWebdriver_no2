using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace MTelegaNordeaHomeWork_2.UserStoryTestCases
{
    public class TestCase2005 : BaseTest
    {
        #region Statics

        public const string testName = "Test Case 2005";

        #endregion

        #region Fields

        protected bool result = true;

        #endregion

        #region Constructors and Destructors

        public TestCase2005()
            : base(testName)
        {
        }

        #endregion

        #region Run

        public override void Run()
        {
            base.Run();

            try
            {
                #region Step1 - Choose Audi from the car list

                driver.FindElement(By.XPath("//*[@id='field_marka_chosen']/a/span")).Click();
                driver.FindElement(By.XPath("//*[@id='field_marka_chosen']/div/div/input")).SendKeys("Audi" + Keys.Enter);
                AddTestLogMessage("Step1 - Choose Audi from the car list - PASSED!");

                #endregion

                #region Step2 - Choose A8 as a model

                driver.FindElement(By.XPath("html/body")).SendKeys(Keys.PageDown);
                driver.FindElement(By.XPath("//*[@id='field_model_chosen']/a/span")).Click();
                driver.FindElement(By.XPath("//*[@id='field_model_chosen']/div/div/input")).SendKeys("A8" + Keys.Enter);
                AddTestLogMessage("Step2 - Choose A8 as a model - PASSED!");

                #endregion

                #region Step3 - Choose production year >= 2005

                driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[1]/div[3]/ul/li[5]/input[1]")).SendKeys("2005");
                AddTestLogMessage("Step3 - Choose production year >= 2005 - PASSED!");

                #endregion

                #region Step4 - Select diesel as a motor type

                driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[1]/div[3]/ul/li[9]/div/p/span")).Click();
                driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[1]/div[3]/ul/li[9]/div/div/ul/li[4]/label")).Click();
                AddTestLogMessage("Step4 - Select diesel as a motor type - PASSED!");

                #endregion

                #region Step5 - Select Gdańsk as a search location

                driver.FindElement(By.XPath("//*[@id='location_map_selector_1']")).Click();
                driver.FindElement(By.XPath("//*[@id='location_select_box_1-1']/div[1]/span[1]")).Click();
                driver.FindElement(By.XPath("//*[@id='location_select_box_1']/div[2]/a")).Click();
                AddTestLogMessage("Step5 - Select Gdańsk as a search location - PASSED!");

                #endregion

                #region Step6 - Choose air conditioning

                driver.FindElement(By.XPath("html/body")).SendKeys(Keys.PageDown);
                driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[1]/div[5]/ul/li[1]/label[14]")).Click();
                AddTestLogMessage("Step6 - Choose air conditioning - PASSED!");

                #endregion

                #region Step7 - Press search button

                driver.FindElement(By.XPath("html/body")).SendKeys(Keys.PageDown);
                driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[2]/input")).Click();
                AddTestLogMessage("Step7 - Press search button - PASSED!");

                #endregion
            }
            catch (StaleElementReferenceException)
            {
                AddTestLogMessage("Element not found in the cache - perhaps the page has changed since it was looked up. RETEST NEEDED!");
                result = false;
            }
            catch (Exception ex)
            {
                AddTestLogMessage("TEST ERROR: " + ex.Message);
                result = false;
            }

            if (result == true)
            {
                AddTestLogMessage("Test passed!");
            }
            else
            {
                AddTestLogMessage("Test failed!");
            }
        }

        #endregion

    }
}
