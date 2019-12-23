using System.Web;
using System.Web.Optimization;

namespace Helios2._0
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/moment.js",
                      "~/Scripts/bootstrap.js",
                        "~/Scripts/grid.locale-en.js",
                      "~/Scripts/jquery.jqGrid.js",
                      "~/Scripts/bootstrap-datepicker.min.js",
                      "~/Scripts/wickedpicker.min.js",
                      "~/Content/Vendor/bootstrap-datetimepicker/bootstrap-datetimepicker.js",
                      
                        "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/ui.jqgrid.css",
                "~/Content/layout-jqgrid.css",
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-datepicker.css",
                      "~/Content/wickedpicker.min.css",
                      "~/Content/Vendor/bootstrap-datetimepicker/bootstrap-datetimepicker.css",
                      "~/Content/site.css"));
        }
    }
}
