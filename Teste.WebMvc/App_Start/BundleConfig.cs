using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Teste.WebMvc.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.ui.core.js",
                        "~/Scripts/jquery.ui.position.js",
                        "~/Scripts/jquery.ui.widget.js",
                        "~/Scripts/jquery.ui.autocomplete.js",
                        "~/Scripts/jquery-ui.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Scripts/jquery-ui-{version}.js"));
            
        }
    }
}