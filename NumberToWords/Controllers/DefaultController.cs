using BusinessContract;
using BusinessService;
using NumberToWords.Models;
using System.Web.Mvc;

namespace NumberToWords.Controllers
{
    public class DefaultController : Controller
    { 
        [HttpGet]
        // GET: Default
        public ActionResult Index()
        {
            NumberToWordsModel model = new NumberToWordsModel();                        
            
            return View("~/Views/Default/Index.cshtml", model);
        }
    }
}