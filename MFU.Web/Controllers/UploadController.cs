using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using MFU.Web.Models;
using System.Text;

namespace MFU.Web.Controllers
{
    public class UploadController : SurfaceController
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(UploadModel model)
        {
            if (ModelState.IsValid)
            {
                StringBuilder fileNames = new StringBuilder();
                fileNames.Append("<ul>");
                foreach (HttpPostedFileBase file in model.Files)
                {
                    //You can do something with the files here like save them to disk or upload them into the Umbraco Media section
                    fileNames.Append("<li>");
                    fileNames.Append(file.FileName);
                    fileNames.Append("</li>");
                }
                fileNames.Append("</ul>");
                TempData["FileNames"] = fileNames.ToString();
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();
        }
    }
}