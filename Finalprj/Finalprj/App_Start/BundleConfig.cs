using System.Web;
using System.Web.Optimization;

namespace Finalprj
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
                      
                      "~/Scripts/bootstrap-datetimepicker.min.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/chart.morris.js",
                      "~/Scripts/jquery-3.5.1.min.js",
                      "~/Scripts/jquery-ui.min.js",
                      "~/Scripts/moment.min.js",
                      "~/Scripts/popper.min.js",
                      "~/Scripts/script.js",
                      "~/Scripts/select2.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap-datetimepicker.min.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/feathericon.min.css",
                      "~/Content/select2.min.css",
                      "~/Content/style.css",
                      "~/Content/css/animate.css",
                      "~/Content/css/aos.css",
                      "~/Content/css/bootstrap-datepicker.css",
                      "~/Content/css/flation.css",
                      "~/Content/css/icomoon.css",
                      "~/Content/css/ionicons.min.css",
                      "~/Content/css/jquery.timepicker.css",
                      "~/Content/css/magnific-popup.css",
                      "~/Content/css/open-iconic-bootstrap.min.css",
                      "~/Content/css/owl.theme.default.min.css",
                      "~/Content/css/owl.carousel.min.css",
                      "~/Content/css/style.css"));
        }
    }
}
