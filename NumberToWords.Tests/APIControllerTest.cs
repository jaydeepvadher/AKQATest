using NumberToWords.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords.Tests
{
    [TestFixture]
    public class APIControllerTest : ITesting
    {        
        // If solution is deployed and hosted locally using publishing than http://akqaservice/ can be used to validate test 
        private const string ServiceBaseUrl = "http://akqaservice/";

        public void RunAllTests()
        {            
            CheckServiceUpAndRunning();
            CheckNumberToWordMethodResponse();
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void CheckServiceUpAndRunning()
        {
            var controller = new UtilityController();
            var result = controller.Get() as string;
            Assert.AreEqual("Service is up and running.", result);

        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void CheckNumberToWordMethodResponse()
        {
            var controller = new UtilityController();
            var result = controller.Get("123.78");

            Assert.AreEqual("One Hundred Twenty-Three Dollar and Seventy-Eight Cents Only", result);
        }
        
    }
}
