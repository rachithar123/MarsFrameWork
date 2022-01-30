using MarsFramework.Global;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
//using static NUnit.Core.NUnitFramework;
using NUnit.Framework;
using System;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]  
        
        private IWebElement view { get; set; }
       
        //Delete the listing
        [FindsBy(How = How.CssSelector, Using = ".ui>.remove")]
        private IWebElement delete { get; set; }
        

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        [FindsBy (How =How.XPath,Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement Yes { get; set; }

        [FindsBy (How = How.XPath,Using = "/html/body/div[2]/div/div[3]/button[1]")]
        private IWebElement No { get; set; }

        // get Title 
        [FindsBy( How = How.CssSelector,Using = ".four:nth-child(3)")]  
        private IWebElement  Title { get; set; }
        internal void Listings()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            GlobalDefinitions.wait(2000);
             manageListingsLink.Click();

            if (Title.Text == "Selenium")
            {
                view.Click();
                GlobalDefinitions.wait(10);
                manageListingsLink.Click();
            }

        }

        internal void UpdateListing()
        {
            GlobalDefinitions.wait(2000);
            manageListingsLink.Click();

            if (Title.Text == "Selenium")
            {   
                edit.Click();
                GlobalDefinitions.wait(2000);
                ShareSkill shareSkillObj = new ShareSkill();
                shareSkillObj.EditShareSkill();
                GlobalDefinitions.wait(5000);

            }
        }

        internal void DeleteListings()
        {
            
            GlobalDefinitions.wait(2000);

            manageListingsLink.Click();
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");

            if (Title.Text== "Selenium")
            {
                
                delete.Click();
                Console.WriteLine("going to delete");
                GlobalDefinitions.wait(10);
                
                     if (GlobalDefinitions.ExcelLib.ReadData(2, "DeleteAction").Equals("Yes"))
                     {
                         Yes.Click();  
                     }
                     else
                     {
                         No.Click();
                     }
            }
            else
            {
                Console.WriteLine(" Title is not matching");
            }
        }
        internal void ValidateDeleteListing()
        {
            GlobalDefinitions.wait(2000);
            IWebElement MessageBox = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
            Assert.That(MessageBox.Text == "Selenium has been deleted", "Actual Message an Expected Year Message do not match");
        }
        
    }
}
