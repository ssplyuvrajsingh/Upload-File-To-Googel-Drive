using System.Web;
using System.Web.Mvc;
using Upload_File_To_Googel_Drive.DIServices;

namespace Upload_File_To_Googel_Drive.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGoogleDrive _googleDrive;
        public HomeController(IGoogleDrive googleDrive)
        {
            _googleDrive = googleDrive;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            ViewBag.Success =  _googleDrive.UplaodFileOnDrive(file) == true ? "File Uploaded on Google Drive" : "Something went wrong please try again!";
            return View();
        }

        [Route("authorize")]
        public ActionResult Authorize()
        {
            return Json("Hurray!",JsonRequestBehavior.AllowGet);
        }
    }
}