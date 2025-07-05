using System.Web;
using System.Web.Optimization;

namespace LegacyECommerce.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region 【 脚 本 文 件 捆 綁 】
            ///【 前 端 主 題 】
            bundles.Add(new ScriptBundle("~/bundles/frontend/js").Include(
                        "~/Scripts/Frontend/plugins.js",
                        "~/Scripts/Frontend/SmoothScroll.js",
                        "~/Scripts/Frontend/script.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/support/modernizr").Include(
                        "~/Scripts/Frontend/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/frontend/support/jquery").Include(
                      "~/Scripts/Frontend/jquery.min.js"));

            bundles.Add(new Bundle("~/bundles/frontend/support/bootstrap").Include(
                      "~/Scripts/Frontend/bootstrap.bundle.min.js"));

            bundles.Add(new Bundle("~/bundles/frontend/support/swiper").Include(
                      "~/Scripts/Frontend/swiper-bundle.min.js"));
            #endregion

            #region 【 樣 式 文 件 捆 綁 】
            ///【 前 端 主 題 】
            bundles.Add(new StyleBundle("~/bundles/frontend/css").Include(
                        "~/Content/Frontend/bootstrap.min.css",
                        "~/Content/Frontend/vendor.css",
                        "~/Content/Frontend/swiper-bundle.min.css",
                        "~/Content/Frontend/style.css",
                        "~/Content/Frontend/fonts.googleapis.com.css"));
            #endregion
        }
    }
}
