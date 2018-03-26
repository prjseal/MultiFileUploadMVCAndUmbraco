using System.Web;

namespace MFU.Web.Models
{
    public class UploadModel
    {
        public HttpPostedFileBase[] Files { get; set; }
    }
}