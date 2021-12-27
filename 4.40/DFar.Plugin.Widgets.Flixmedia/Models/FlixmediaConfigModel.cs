using Nop.Web.Framework.Mvc.ModelBinding;

namespace DFar.Plugin.Widgets.Flixmedia.Models
{
    public class FlixmediaConfigModel
    {
        [NopResourceDisplayName(FlixmediaLocales.FlixID)]
        public string FlixID { get; set; }

        [NopResourceDisplayName(FlixmediaLocales.WidgetZone)]
        public string WidgetZone { get; set; }
    }
}