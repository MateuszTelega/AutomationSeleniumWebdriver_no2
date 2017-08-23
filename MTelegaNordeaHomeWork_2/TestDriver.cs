// *********************************************************
// Author:  Mateusz Telega
// Date:    2017-08-22
// Project: Nordea Homework - Test Case Automation for given User Story
// Used Technologies:
// - Selenium Webdriver 2.53.0
// Tested Stable Environment:
// - Windows 7
// - Visual Studio Community 2015
// - Firefox 46.0
// - Mozilla geckodriver 0.6.2
// *********************************************************

namespace MTelegaNordeaHomeWork_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using UserStoryTestCases;

    public class TestDriver
    {
        public static void Main(string[] args)
        {
            TestCase2005 tc1 = new TestCase2005();
            tc1.Run();
            tc1.Clean();

            TestCase2006 tc2 = new TestCase2006();
            tc2.Run();
            tc2.Clean();
        }
    }
}