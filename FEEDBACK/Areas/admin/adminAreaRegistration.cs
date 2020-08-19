using System.Web.Mvc;

namespace FEEDBACK.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );



            context.MapRoute(
                "Edit",
                "admin/{controller}/{action}/{id}",
                new { controller = "LOAIKHACHSANs", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "dm_khachsan",
                "admin/{controller}/{action}/{id}",
                new { controller = "DM_KHACHSAN", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Search_KS",
                "admin/{controller}/{action}/{id}",
                new { controller = "Search_KS", action = "Search", id = UrlParameter.Optional }
            );


        }
    }
}