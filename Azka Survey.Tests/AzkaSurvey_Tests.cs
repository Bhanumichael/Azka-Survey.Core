global using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Azka_Survey.Tests
{
    [TestClass]
    public class AzkaSurvey_Tests:BaseTest
    {
        [TestMethod]
        public void VerifyThatUserCanFillTheLoginDetailsInForm()
        {
            uiHelpers.NavigateToUrl();
            loginPage.Entername("pruthvi");
            loginPage.Enterpassword("rMmGPja");
            loginPage.ClickForLogin();

        }
    }
}