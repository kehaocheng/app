using System.Web;
using System.Web.Optimization;

namespace App.Web
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /*脚本*/
            //jquery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
            //easyui的js
            bundles.Add(new ScriptBundle("~/bundles/easyui").Include("~/Scripts/jquery.easyui.min.js"));
            //Home控制器的脚本
            bundles.Add(new ScriptBundle("~/bundles/home").Include("~/Scripts/Home/home.js"));





            /*样式*/
            //easyui的css
            bundles.Add(new StyleBundle("~/Content/themes/blue/css").Include("~/Content/themes/blue/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/gray/css").Include("~/Content/themes/gray/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/metro/css").Include("~/Content/themes/metro/easyui.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
        }
    }
}
