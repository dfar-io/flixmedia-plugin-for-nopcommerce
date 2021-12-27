using Nop.Services.Logging;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;
using Nop.Core;
using System.Threading.Tasks;

namespace DFar.Plugin.Widgets.Flixmedia.Components
{
    public class WidgetsFlixmediaViewComponent : NopViewComponent
    {
        private readonly FlixmediaSettings _settings;
        private readonly ILogger _logger;
        private readonly IWebHelper _webHelper;

        public WidgetsFlixmediaViewComponent(
            FlixmediaSettings settings,
            ILogger logger,
            IWebHelper webHelper
        )
        {
            _settings = settings;
            _logger = logger;
            _webHelper = webHelper;
        }

        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData = null)
        {
            if (!_settings.IsValid())
            {
                await _logger.ErrorAsync("Widgets.Flixmedia: Flix ID is required to be " +
                              "set to enable product syndication.");
                return Content("");
            }

            if (widgetZone == _settings.WidgetZone)
            {
                return Content("<div>it works!</div>");
            }
            // if (widgetZone == _settings.ProductDetailWidgetZone)
            // {
            //     return View("~/Plugins/Widgets.Flixmedia/Views/Detail.cshtml");
            // }
            // if (widgetZone == _settings.ProductDetailReviewsWidgetZone)
            // {
            //     return View("~/Plugins/Widgets.Flixmedia/Views/DetailReviews.cshtml");
            // }

            // Scripts
            // if (widgetZone == PublicWidgetZones.CategoryDetailsBottom ||
            //     widgetZone == PublicWidgetZones.ManufacturerDetailsBottom)
            // {
            //     return View("~/Plugins/Widgets.Flixmedia/Views/ListingScript.cshtml", _settings);
            // }
            // if (widgetZone == PublicWidgetZones.ProductDetailsBottom)
            // {
            //     return await Detail(additionalData as ProductDetailsModel);
            // }

            await _logger.ErrorAsync($"Widgets.Flixmedia: No view provided for widget zone {widgetZone}");
            return Content("");
        }
    }
}