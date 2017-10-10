using BusinessContract;
using BusinessService;
using System.Web.Http;

namespace NumberToWords.Controllers
{
    public class UtilityController : ApiController
    {       
        /// <summary>
        /// Converts number or float value to words
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        [HttpGet]
        public string Get(string numbers)
        {
            INumberToWordsService nb = new NumberToWordsService();
            return nb.ConvertNumberToWords(numbers);            
        }


        /// <summary>
        /// Method to check service is up and running
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Get()
        {
            return "Service is up and running.";
        }
    }
}