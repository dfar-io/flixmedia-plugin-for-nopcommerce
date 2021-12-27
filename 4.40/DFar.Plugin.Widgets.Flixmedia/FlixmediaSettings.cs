using DFar.Plugin.Widgets.Flixmedia.Models;
using Nop.Core.Configuration;
using Nop.Web.Framework.Infrastructure;

namespace DFar.Plugin.Widgets.Flixmedia
{
    public class FlixmediaSettings : ISettings
    {
        public string FlixID { get; private set; }
        public string WidgetZone { get; private set; }

        public static FlixmediaSettings DefaultValues()
        {
            return new FlixmediaSettings()
            {
                WidgetZone = PublicWidgetZones.ProductDetailsEssentialBottom
            };
        }

        public static FlixmediaSettings FromModel(FlixmediaConfigModel model)
        {
            return new FlixmediaSettings()
            {
                FlixID = model.FlixID,
                WidgetZone = model.WidgetZone
            };
        }

        public FlixmediaConfigModel ToModel()
        {
            return new FlixmediaConfigModel
            {
                FlixID = FlixID,
                WidgetZone = WidgetZone
            };
        }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(FlixID);
        }
    }
}