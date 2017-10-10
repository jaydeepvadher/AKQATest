using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NumberToWords.Tests
{
    [TestFixture]
    public class GlobalTest : Global
    {        
        [Test]
        public void ApplicationStart()
        {
            var sender = new object();
            var e = new EventArgs();
            try
            {
                Application_Start(sender, e); // this will error b/c not fully loaded yet.
            }
            catch (InvalidOperationException)
            {
                Thread.Sleep(2000); // give the app time to launch

                Application_Start(sender, e);
            }
            Assert.IsTrue(true);
        }

    }
}
