using System.Web.Mvc;

namespace diagnosis.Areas.ExpertSection
{
    public class ExpertSectionAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ExpertSection";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ExpertSection_default",
                "ExpertSection/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
