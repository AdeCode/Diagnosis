using System.Web.Mvc;

namespace diagnosis.Areas.UserSection
{
    public class UserSectionAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "UserSection";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "UserSection_default",
                "UserSection/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
