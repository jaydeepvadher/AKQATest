using NumberToWords.Controllers;
using NUnit.Framework;
using BusinessContract;
using NSubstitute;
using System.Web.Mvc;
using System.Web.Http;

namespace NumberToWords.Tests
{
    [TestFixture]
    public class ControllerTests : ITesting
    {
        #region Declarations
        string name = string.Empty;
        string numbers = string.Empty;
        private INumberToWordsService _numberToWordsService;
        private const string ServiceBaseUrl = "http://localhost:64761/api/Utility";

        #endregion

        public void RunAllTests()
        {
            Setup();
            CheckView();
        }

        [SetUp]
        public void Setup()
        {
            _numberToWordsService = Substitute.For<INumberToWordsService>();
        }

        [Test]
        public void CheckView()
        {

            var controller = new DefaultController();
            var result = (ViewResult)controller.Index();
            Assert.AreEqual("~/Views/Default/Index.cshtml", result.ViewName);
        }
    }
}
