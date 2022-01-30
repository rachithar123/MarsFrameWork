using MarsFramework.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
            
            [Test,Order (1)]
            public void AddShareSkillTest()
            {
                //Start Report
                test = extent.StartTest("AddShareSkillTest");

                ShareSkill ShareSkillobj = new ShareSkill();
                ShareSkillobj.EnterShareSkill();
                

                // Log'info'
                test.Log(LogStatus.Info, "Add Skill Listing");
                SaveScreenShotClass.SaveScreenshot(driver, "Rachitha_ScreenShots");

         

            }
            [Test, Order (2)]

            public void ViewListingsTest()
            {
                // Start Report
                test = extent.StartTest("ViewListingsTest");

                ManageListings ManageListObj = new ManageListings();
                ManageListObj.Listings();

                //Log 'info'
                test.Log(LogStatus.Info, " View Skill Listing");
                SaveScreenShotClass.SaveScreenshot(driver, "Rachitha_ScreenShots");

            }

              [Test,Order (3)]
             public void EditShareSkillTest()
             {
                test = extent.StartTest("EditListingsTest");

                 ManageListings ManageListObj = new ManageListings();
                 ManageListObj.UpdateListing();

              //Log 'info'
                 test.Log(LogStatus.Info, "Edit Skill Listing");
                 SaveScreenShotClass.SaveScreenshot(driver, "Rachitha_ScreenShots");

                

             }

            [Test,Order(4)]
            public void DeleteListingsTest()
            {
                //Start Report
                test = extent.StartTest("DeleteListingsTest");

                ManageListings ManageListObj = new ManageListings();
                ManageListObj.DeleteListings();

                //Log 'info'
                test.Log(LogStatus.Info, "Delete Skill Listing");
                SaveScreenShotClass.SaveScreenshot(driver, "Rachitha_ScreenShots");

             
            }
        }
    }
}