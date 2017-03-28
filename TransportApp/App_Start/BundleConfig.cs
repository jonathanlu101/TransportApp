using System.Web;
using System.Web.Optimization;

namespace TransportApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new Bundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/angular/angular.js",
                        "~/Scripts/angular-ui-router/release/angular-ui-router.js",
                        "~/Scripts/angular-aria/angular-aria.js",
                        "~/Scripts/angular-animate/angular-animate.js",
                        "~/Scripts/angular-messages/angular-messages.js",
                        "~/Scripts/angular-material/angular-material.js",
                        "~/Scripts/angular-smart-table/dist/smart-table.js",
                        "~/Scripts/angular-local-storage/dist/angular-local-storage.js",
                        "~/Scripts/angular-bootstrap/ui-bootstrap-tpls.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js"
                        )
                        .IncludeDirectory("~/Scripts/app", "*.js", true));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-flatly.css",
                      "~/Scripts/angular-material/angular-material.css",
                      "~/Content/site.css"));
        }
    }
}
