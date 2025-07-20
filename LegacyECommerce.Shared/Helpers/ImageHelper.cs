using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LegacyECommerce.Shared.Helpers
{
    public static class ImageHelper
    {
        public static string SaveCategoryImage(HttpPostedFileBase file)
        {
            var uploadName = Path.GetFileName(file.FileName);
            var downloadName = Guid.NewGuid().ToString() + Path.GetExtension(uploadName);
            var mapPath = HttpContext.Current.Server.MapPath("~/Content/Images/Categories");
            var savePath = Path.Combine(mapPath, downloadName);
            file.SaveAs(savePath);

            return downloadName;
        }
    }
}
