using System.Web;
using System.Web.Optimization;

namespace BiffFestival
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
                   "~/Scripts/bootstrap.js"
                   ));

         bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
            "~/Content/Plugins/jquery.bxslider.js",
            "~/Content/Plugins/jquery.centralized.js",
            "~/Content/Plugins/jquery.nav.js",
            "~/Content/Plugins/jquery.parallax-1.1.3.js",
            "~/Content/Plugins/jquery.fixedonlater.js",
            "~/Content/Plugins/jquery.mixitup.js",
            "~/Content/Plugins/jquery.fixedonlater.js",
            "~/Content/Plugins/jquery.tweetCarousel.js"
         ));

         bundles.Add(new StyleBundle("~/Content/css").Include(
                   "~/Content/bootstrap.css",
                   "~/Content/Css/index.css",
                   "~/Content/Css/docs.css"
            ));
      }
   }
}
