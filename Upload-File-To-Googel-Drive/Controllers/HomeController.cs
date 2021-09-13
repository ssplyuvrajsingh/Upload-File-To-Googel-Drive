using System.IO;
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
            return View(_googleDrive.GetFiles());
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            ViewBag.Success =  _googleDrive.UplaodFileOnDrive(file) == true ? "File Uploaded on Google Drive" : "Something went wrong please try again!";
            return View(_googleDrive.GetFiles());
        }

        [HttpPost]
        public ActionResult DeleteFile(string fileId)
        {
            _googleDrive.DeleteFile(fileId);
            return RedirectToAction("Index");
        }

        public void DownloadFile(string id)
        {
            string FilePath = _googleDrive.DownloadGoogleFile(id);


            Response.ContentType = "application/zip";
            Response.AddHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(FilePath));
            Response.WriteFile(System.Web.HttpContext.Current.Server.MapPath("~/GoogleDriveFiles/" + Path.GetFileName(FilePath)));
            Response.End();
            Response.Flush();
        }
    }
}