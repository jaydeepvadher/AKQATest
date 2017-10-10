using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberToWords.Controllers;
using NUnit.Framework;
using BusinessContract;
using NSubstitute;
using System.Web.Mvc;
using System.Web.Http;
using NumberToWords.Models;

namespace NumberToWords.Tests
{
    [TestFixture]
    public class ModelTest
    {
        [Test]
        public void Property_StoresCorrectly()
        {
            var sut = new NumberToWordsModel();
            sut.inputName = "hello";
            Assert.AreEqual("hello", sut.inputName, "Oops...");

            sut.inputNumber = 20.32;
            Assert.AreEqual(20.32, sut.inputNumber, "Oops...");
        }

       
    }
}
