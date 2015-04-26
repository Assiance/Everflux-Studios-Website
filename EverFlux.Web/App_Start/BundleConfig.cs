using System.Web;
using System.Web.Optimization;

namespace EverFlux.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/Jqueryplugins").Include(
                       "~/Scripts/jquery.easing.1.3.min.js",
                       "~/Scripts/jquery.form.js",
                        "~/Scripts/jquery.validate.min.js",
                         "~/Scripts/bootstrap-hover-dropdown.min.js",
                          "~/Scripts/skrollr.min.js",
                           "~/Scripts/waypoints.min.js",
                           "~/Scripts/waypoints-sticky.min.js",
                           "~/Scripts/owl.carousel.min.js",
                           "~/Scripts/jquery.isotope.min.js",
                           "~/Scripts/jquery.easytabs.min.js",
                           "~/Scripts/google.maps.api.v3.js",
                            "~/Scripts/viewport-units-buggyfill.js",
                             "~/Scripts/scripts.js"
          
          ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/main.css",
                      "~/Content/green.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/owl.transitions.css",
                      "~/Content/animate.min.css"
                      ));
        }
    }
}
