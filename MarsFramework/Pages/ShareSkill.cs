using AutoItX3Lib;
using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;



namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);  //Constructor of ShareSkill
        }

        //Click on ShareSkill Button  
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Share Skill')]")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        [FindsBy( How = How.XPath,Using = "//input[@name='serviceType']")]
        
        private IWebElement HourlyBase { get; set; }
   
        [FindsBy( How = How.XPath, Using = "(//input[@name='serviceType'])[2]")]
        private IWebElement OneOff { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        [FindsBy( How = How.XPath,Using = "//div[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div/div/input")]
        private IWebElement Onsite { get; set; }

        [FindsBy (How = How.XPath,Using = "//div[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
      
        private IWebElement Online { get; set; }
        
        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        // Click on Start Time Dropdown
         [FindsBy(How =How.Name,Using = "StartTime")]
         private IWebElement StartTimeDropDown { get; set; }

        // Click on End Time DropDown
        [FindsBy(How =How.Name,Using = "EndTime")]
        private IWebElement EndTimeDropDown { get; set; }
        

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades']")]
        private IWebElement SkillExchangeOpt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement Credit { get; set; }
        //Enter Skill Exchange 
        [FindsBy(How = How.XPath, Using = "(//input[@value=''])[18]")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.Name, Using = "charge")]
        private IWebElement CreditAmount { get; set; }

        // Select to Upload file 
        [FindsBy(How =How.XPath, Using =("//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/div/input"))]
        private static IWebElement FileUpload { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class ='field']")]
        private IWebElement ActiveOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='isActive']")]
        private IWebElement Active { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]  
        private static IWebElement Hidden { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }
      

        //---------------------------------------------------Edit Fields ------------------------------------------------------------------------------------------------//

        // update Title TextBox
        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]                                       
        private IWebElement UpdateTitle { get; set; }

        // Update Description Text Box
        [FindsBy(How = How.XPath,Using = "//*[@id='service - listing - section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]
        private IWebElement UpdateDescription { get; set; } 

        // Update Category 
        [FindsBy(How = How.XPath,Using = "//*[@id='service - listing - section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select")]
        private IWebElement UpdateCategory { get; set; }

        // Update SubCategory
        [FindsBy(How = How.XPath,Using = "//*[@id='service - listing - section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select")]
        private IWebElement UpdateSubCategory { get; set; }

        // Update Location Type
        [FindsBy(How = How.XPath,Using = "//*[@id='service - listing - section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        private IWebElement UpdateLocation { get; set; }

        //Update SkillTrade
        [FindsBy(How = How.XPath,Using = "//*[@id='service - listing - section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
        private IWebElement UpdateSkillTrade { get; set; }

        // Update ShareSkill 
        [FindsBy(How = How.XPath,Using = "//*[@id='service - listing - section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement UpdateShareSkill { get; set; }
        //----------------------------------------------------------------------------------------------------------------//

        String selectDayOption, LocationType, ServiceType, SkillTrade, ActiveType, selectStartTime, selectEndTime;

        //--------------------------------------------------------------------------------------------------------//
        internal void EnterShareSkill()
        {
            // populate the Excel data

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            GlobalDefinitions.wait(2000);

            // Share-Skill button click
            ShareSkillButton.Click();

            // Enter Title
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            // Enter Descrption
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            //Select Category Drop-Down
            CategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));

            //Select SubCategory Drop-Down
            SubCategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));

            // Enter Tags
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);

            // Select  Service-Type 
                ServiceType = GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType");
            if (ServiceType.Equals("One-off service"))
            {
                OneOff.Click();
            }
            else
            {
                HourlyBase.Click();
            }

            // Select Location Type
                LocationType = GlobalDefinitions.ExcelLib.ReadData(2, "LocationType");
            if (LocationType.Equals("On-site"))
            {
                Onsite.Click();
            }
            else
            {
                Online.Click();
            }

            // Select Start Date
            
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"Startdate"));
            

            // Select End Date
          
           //EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));
           

            // Select the Day 
            selectDayOption = GlobalDefinitions.ExcelLib.ReadData(2, "Selectday");
            IWebElement selectDay = Days.FindElement(By.XPath("//div[@class = 'ui checkbox']/input[following-sibling::label[text()='" + selectDayOption + "']]"));
            selectDay.Click();

            // Enter Start Time
            IWebElement StartTime = StartTimeDropDown.FindElement(By.XPath(@"//div[@class = 'four wide field']/input[@name='StartTime' and @index='" + selectDay.GetAttribute("index") + "']"));
            selectStartTime = DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")).ToShortTimeString().Remove(4, 1);
            StartTime.SendKeys(selectStartTime);

            //Enter End Time
            IWebElement EndTime=EndTimeDropDown.FindElement(By.XPath(@"//div[@class = 'four wide field']/input[@name = 'EndTime'and @index='" + selectDay.GetAttribute("index") + "']"));
            selectEndTime = DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")).ToShortTimeString().Remove(4, 1);
            EndTime.SendKeys(selectEndTime);

            

            // Select Skill Trade
            SkillTrade = GlobalDefinitions.ExcelLib.ReadData(2,"SkillTrade");
           
            if (SkillTrade.Equals("Skill-exchange"))
            {
                if (SkillExchangeOpt.Selected!=true) 
                {
                    SkillExchangeOpt.Click();
                    SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
                    SkillExchangeOpt.SendKeys(Keys.Enter);
                }
                else
                {
                    SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
                    SkillExchangeOpt.SendKeys(Keys.Enter);
                }
                
            }
            if (SkillTrade.Equals("Credit"))
            {
                if (Credit.Selected!=true)
                {
                    Credit.Click();
                    CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"Credit"));
                }
                else
                {
                    CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));
                }
                
            }

            // Select Work-Sample

             FileUpload.Click();
             AutoItX3 autoIt = new AutoItX3();
             autoIt.WinActivate("Open");
             autoIt.Send(@"C:\MPV-Project\marsframework-master (1)\MarsFramework\New Text Document.txt");
             GlobalDefinitions.wait(1000);
             autoIt.Send("{ENTER}");
             
            


            // Select Active
             ActiveType = GlobalDefinitions.ExcelLib.ReadData(2, "Active");
            if (ActiveType.Equals("Active"))
            {
                   Active.Click();
                    Console.WriteLine("already select");
         
            }
            if(ActiveType.Equals("Hidden"))
            { 
                    Hidden.Click();
                    Console.WriteLine("just select");  
            }
           
            // Select Save button

            Save.Click();
            GlobalDefinitions.wait(2000);
        }

        internal void AddValidateShareSkill()
        {
            GlobalDefinitions.wait(2000);
            IWebElement MessageBox = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
            Assert.That(MessageBox.Text == "Service Listing Added successfully", "Actual Message an Expected Year Message do not match");

        }

        internal void EditShareSkill()
        {
            // populate the Excel data

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "EditShareSkill");

            GlobalDefinitions.wait(2000);

            // Select Title
            Title.Clear();
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            //Select Description
            Description.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            //Select Category Drop-Down
            CategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));

            //Select SubCategory Drop-Down
            SubCategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));

           
            // Select Location Type
            LocationType = GlobalDefinitions.ExcelLib.ReadData(2, "LocationType");
            if (LocationType.Equals("On-site"))
            {
                Onsite.Click();
            }
            else
            {
                Online.Click();
            }
           
            // Select Skill Trade
            SkillTrade = GlobalDefinitions.ExcelLib.ReadData(2, "SkillTrade");

            if (SkillTrade.Equals("Skill-exchange"))
            {
                if (SkillExchangeOpt.Selected != true)
                {
                    SkillExchangeOpt.Click();
                    SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
                    SkillExchangeOpt.SendKeys(Keys.Enter);
                }
                else
                {
                    SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
                    SkillExchangeOpt.SendKeys(Keys.Enter);
                }

            }
            if (SkillTrade.Equals("Credit"))
            {
                if (Credit.Selected != true)
                {
                    Credit.Click();
                    CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));
                }
                else
                {
                    CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));
                }

            }

            // Select Save button

            Save.Click();
            GlobalDefinitions.wait(2000);


        }

        internal void EditValidateShareSkill()
        {
            GlobalDefinitions.wait(2000);
            IWebElement MessageBox = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
            Assert.That(MessageBox.Text == "ExtentedSelenium has been deleted", "Actual Message an Expected Year Message do not match");

        }
    }
}
