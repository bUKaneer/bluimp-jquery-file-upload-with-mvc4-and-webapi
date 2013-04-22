using System.Web.Optimization;

namespace BluImpJqueryFileUploadMVC4
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bluimp").Include(
                "~/Scripts/bluimp/vendor/jquery.ui.widget.js",
                "~/Scripts/bluimp/tmpl.js",
                "~/Scripts/bluimp/load-image.js",
                "~/Scripts/bluimp/canvas-to-blob.js",
                "~/Scripts/bluimp/jquery.iframe-transport.js",
                "~/Scripts/bluimp/jquery.fileupload.js",
                "~/Scripts/bluimp/jquery.fileupload-fp.js",
                "~/Scripts/bluimp/jquery.fileupload-ui.js",
                "~/Scripts/bluimp/main.js"));
        }
    }
}