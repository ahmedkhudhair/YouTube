using System.Web;
using System.Web.Optimization;

namespace YouTube
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.bundle.js" ,
                "~/Scripts/bootstrap.bundle.min.js",
                "~/Scripts/bootstrap.esm.js" ,
                "~/Scripts/bootstrap.esm.min.js" ,
                "~/Scripts/bootstrap.js" ,
                "~/Scripts/bootstrap.min.js" 
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
            "~/Content/bootstrap-css/bootstrap-grid.css",
            "~/Content/bootstrap-css/bootstrap-grid.min.css",
            "~/Content/bootstrap-css/bootstrap-grid.rtl.css",
            "~/Content/bootstrap-css/bootstrap-grid.rtl.min.css",
            "~/Content/bootstrap-css/bootstrap-reboot.css",
            "~/Content/bootstrap-css/bootstrap-reboot.min.css",
            "~/Content/bootstrap-css/bootstrap-reboot.rtl.css",
            "~/Content/bootstrap-css/bootstrap-reboot.rtl.min.css",
            "~/Content/bootstrap-css/bootstrap-utilities.css",
            "~/Content/bootstrap-css/bootstrap-utilities.min.css",
            "~/Content/bootstrap-css/bootstrap-utilities.rtl.css",
            "~/Content/bootstrap-css/bootstrap-utilities.rtl.min.css",
            "~/Content/bootstrap-css/bootstrap.css",
            "~/Content/bootstrap-css/bootstrap.min.css",
            "~/Content/bootstrap-css/bootstrap.rtl.css",
            "~/Content/bootstrap-css/bootstrap.rtl.min.css"));

        }
    }
}
