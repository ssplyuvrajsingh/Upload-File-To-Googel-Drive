using Google.Apis.Drive.v3;
using System.Collections.Generic;
using System.Web;

namespace Upload_File_To_Googel_Drive.DIServices
{
    public interface IGoogleDrive
    {
        bool UplaodFileOnDrive(HttpPostedFileBase file);
        IEnumerable<Google.Apis.Drive.v3.Data.File> GetFiles();
        string DownloadGoogleFile(string fileId);
        void DeleteFile(string fileId);
    }
}
