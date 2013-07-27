using System.Web.Optimization;

namespace Solirus.NUnitReport.Presentation.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleScripts(bundles);
            BundleStyles(bundles);
        }

        private static void BundleStyles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/nunitreportstyle").Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-responsive.css",
                "~/Content/bootstrap-fileupload.css",
                "~/Content/nunitreport.css"));
        }

        private static void BundleScripts(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/nunitreportscripts").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/bootstrap-fileupload.js",
                "~/Scripts/locales/nunitreport.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*",
                    "~/Scripts/jquery.unobtrusive*"));
        }
    }
}