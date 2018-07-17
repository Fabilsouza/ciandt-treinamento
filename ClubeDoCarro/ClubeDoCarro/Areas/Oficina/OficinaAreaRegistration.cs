using System.Web.Mvc;

namespace ClubeDoCarro.Areas.Oficina
{
    public class OficinaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Oficina";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Oficina_default",
                "Oficina/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional,controller = "Home" },
                new string[] { "ClubeDoCarro.Areas.Oficina.Controllers" }
            );
        }
    }
}