using Google.Apis.Drive.v3;
using System.Web;

namespace Upload_File_To_Googel_Drive.DIServices
{
    public interface IGoogleDrive
    {
        DriveService GetService();
        bool UplaodFileOnDrive(HttpPostedFileBase file);
    }
}
