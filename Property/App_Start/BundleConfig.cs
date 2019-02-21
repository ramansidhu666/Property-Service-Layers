using System.Web;
using System.Web.Optimization;
namespace Property
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            /* Scripts for Web-Site */
            bundles.Add(new ScriptBundle("~/bundles/assets/jquery").Include(
                "~/assets-frontend/js/jquery-1.12.4.min.js",
                "~/assets-frontend/js/plugins.js",               
                "~/assets-frontend/js/custom.js"
                
                ));
          
            /* Style for Web-Site */
            bundles.Add(new StyleBundle("~/styles/web-themes/base/css").Include(                       
                       
                        "~/assets-frontend/css/plugins.css",
                        "~/assets-frontend/css/style.css"));


            
          
            //bundles.Add(new ScriptBundle("~/bundles/bower_components/jquery").Include(
            //    "~/bower_components/jquery/dist/jquery.min.js"
            //    ));
            //bundles.Add(new ScriptBundle("~/bundles/bower_components/main/js").Include(
            //        "~/bower_components/jquery-ui/jquery-ui.min.js",
            //        "~/bower_components/slimScroll/jquery.slimscroll.min.js",
            //        "~/bower_components/angular/angular.min.js",
            //        "~/bower_components/angular-sanitize/angular-sanitize.min.js",
            //        "~/bower_components/angular-animate/angular-animate.min.js",
            //        "~/bower_components/angular-ui-router/release/angular-ui-router.min.js",
            //        "~/bower_components/angular-bootstrap/ui-bootstrap-tpls.min.js",
            //        "~/bower_components/bootstrap/dist/js/bootstrap.min.js",
            //        "~/bower_components/jquery-flot/jquery.flot.js",
            //        "~/bower_components/jquery-flot/jquery.flot.resize.js",
            //        "~/bower_components/jquery-flot/jquery.flot.pie.js",
            //        "~/bower_components/flot.curvedlines/curvedLines.js",
            //        "~/bower_components/jquery.flot.spline/index.js",
            //        "~/bower_components/angular-flot/angular-flot.js",
            //        "~/bower_components/metisMenu/dist/metisMenu.min.js",
            //        "~/bower_components/sweetalert/lib/sweet-alert.js",
            //        "~/bower_components/iCheck/icheck.min.js",
            //        "~/bower_components/sparkline/index.js",
            //        "~/bower_components/angles/angles.js",
            //        "~/bower_components/sweetalert/lib/sweet-alert.min.js",
            //        "~/bower_components/angular-notify/dist/angular-notify.min.js",
            //        "~/bower_components/angles/angles.js",
            //        "~/bower_components/angular-ui-utils/ui-utils.js",
            //        "~/bower_components/angular-ui-map/ui-map.js",
            //        "~/bower_components/lodash/dist/lodash.min.js",
            //        "~/bower_components/moment/min/moment.min.js",
            //        "~/bower_components/moment/min/moment-with-locales.min.js",
            //        "~/bower_components/moment-timezone/builds/moment-timezone-with-data.min.js",
            //        "~/bower_components/chosen/chosen.jquery.min.js",
            //        "~/bower_components/fullcalendar/dist/fullcalendar.min.js",
            //        "~/bower_components/angular-ui-calendar/src/calendar.js",
            //        "~/bower_components/ng-grid/ng-grid-2.0.14.min.js",
            //        "~/bower_components/angular-ui-tree/dist/angular-ui-tree.min.js",
            //        "~/bower_components/bootstrap-tour/build/js/bootstrap-tour.min.js",
            //        "~/bower_components/angular-bootstrap-tour/dist/angular-bootstrap-tour.min.js",
            //        "~/bower_components/angular-xeditable/dist/js/xeditable.min.js",
            //        "~/bower_components/ui-select/dist/select.min.js",
            //        "~/bower_components/bootstrap-touchspin/dist/jquery.bootstrap-touchspin.min.js",
            //        "~/bower_components/angular-ui-sortable/sortable.min.js",
            //        "~/bower_components/clockpicker/dist/bootstrap-clockpicker.min.js",
            //        "~/bower_components/eonasdan-bootstrap-datetimepicker/build/js/bootstrap-datetimepicker.min.js",
            //        "~/bower_components/bootstrap-daterangepicker-master/daterangepicker.js",
            //        "~/bower_components/ladda/dist/spin.min.js",
            //        "~/bower_components/angular-spinner/angular-spinner.js",
            //        "~/bower_components/angular-theme-spinner/dist/angular-theme-spinner.min.js",
            //        "~/bower_components/ladda/dist/ladda.min.js",
            //        "~/bower_components/ladda/dist/ladda.jquery.min.js",
            //        "~/bower_components/angular-ladda/dist/angular-ladda.min.js",
            //        "~/bower_components/angular-cookies/angular-cookies.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/scripts/app_base/js").Include(
            //            "~/scripts/Property.js",
            //            "~/scripts/app.js",
            //            "~/scripts/config.js"           
            //            ));

            //bundles.Add(new ScriptBundle("~/bundles/scripts/app/js").Include(
            //        "~/scripts/filters/props.js",
            //        "~/scripts/directives/directives.js",
            //        "~/scripts/directives/touchSpin.js",
            //        "~/scripts/factories/sweet-alert.js"
            //        ));

            //bundles.Add(new ScriptBundle("~/bundles/scripts/controller/js").Include(
            //        "~/scripts/controllers/main.js",
            //        "~/scripts/controllers/login.js",
            //        "~/scripts/controllers/register.js",
            //        "~/scripts/controllers/home.js"
            //        ));

            //bundles.Add(new StyleBundle("~/bower_components/main/css").Include(
            //        "~/bower_components/angular-notify/dist/angular-notify.min.css",
            //        "~/bower_components/fontawesome/css/font-awesome.css",
            //        "~/bower_components/metisMenu/dist/metisMenu.css",
            //        "~/bower_components/animate.css/animate.css",
            //        "~/bower_components/sweetalert/lib/sweet-alert.css",
            //        "~/bower_components/fullcalendar/dist/fullcalendar.min.css",
            //        "~/bower_components/bootstrap/dist/css/bootstrap.css",
            //        "~/bower_components/ng-grid/ng-grid.min.css",
            //        "~/bower_components/angular-ui-tree/dist/angular-ui-tree.min.css",
            //        "~/bower_components/bootstrap-tour/build/css/bootstrap-tour.min.css",
            //        "~/bower_components/angular-xeditable/dist/css/xeditable.css",
            //        "~/bower_components/ui-select/dist/select.min.css",
            //        "~/bower_components/bootstrap-touchspin/dist/jquery.bootstrap-touchspin.min.css",
            //        "~/bower_components/awesome-bootstrap-checkbox/awesome-bootstrap-checkbox.css",
            //        "~/bower_components/clockpicker/dist/bootstrap-clockpicker.min.css",
            //        "~/bower_components/eonasdan-bootstrap-datetimepicker/build/css/bootstrap-datetimepicker.min.css",
            //        "~/bower_components/bootstrap-daterangepicker-master/daterangepicker.css",
            //        "~/bower_components/ladda/dist/ladda-themeless.min.css",
            //        "~/bower_components/angular-theme-spinner/dist/angular-theme-spinner.min.css",
            //        "~/bower_components/chosen/chosen.min.css",
            //        "~/bower_components/angular-timezone-selector/dist/angular-timezone-selector.css"
            //        ));

            //bundles.Add(new StyleBundle("~/fonts/css").Include(
            //            "~/fonts/pe-icon-7-stroke/css/pe-icon-7-stroke.css",
            //            "~/fonts/pe-icon-7-stroke/css/helper.css"));

            //bundles.Add(new StyleBundle("~/styles/themes/base/css").Include(
            //            "~/styles/style.css",
            //            "~/styles/flags.css"));


            // Code removed for clarity.
            //BundleTable.EnableOptimizations = true;

        }
    }
}