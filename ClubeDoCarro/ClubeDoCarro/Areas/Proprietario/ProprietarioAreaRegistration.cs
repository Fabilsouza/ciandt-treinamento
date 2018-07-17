using System.Web.Mvc;

namespace ClubeDoCarro.Areas.Proprietario
{
    public class ProprietarioAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Proprietario";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Proprietario_default",
                "Proprietario/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional , controller = "Home"},
                new string[] { "ClubeDoCarro.Areas.Proprietario.Controllers" }
            );
        }
    }
}