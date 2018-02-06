using System.Web;
using System.Web.Optimization;

namespace POS
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            //Template Level JavaScript
            bundles.Add(new ScriptBundle("~/bundles/Templatejs").Include(
                      "~/Scripts/Templatejs/jquery.min.js",
                      "~/Scripts/Templatejs/bootstrap.min.js",
                      "~/Scripts/Templatejs/waves.js",
                      "~/Scripts/Templatejs/admin.js"));
            //Template Level CSS
            bundles.Add(new StyleBundle("~/Content/TemplateCSS/css").Include(
                      "~/Content/TemplateCSS/all-themes.min.css",
                      "~/Content/TemplateCSS/bootstrap.min.css",
                      "~/Content/TemplateCSS/style.css",
                      "~/Content/TemplateCSS/waves.css"));
        }
    }
}
