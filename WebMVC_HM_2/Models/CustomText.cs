using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC_HM_2.Models
{
    public class CustomText : ActionResult
    {
        private TextSettings _textSettings;

        public CustomText(TextSettings textSettings)
        {
            _textSettings = textSettings;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;
            response.ContentType = "text/html";

            string html = $@"
                <!DOCTYPE html>
                <html>
                <head>
                    <meta name='viewport' content='width=device-width' />
                    <title>Custom Text</title>
                </head>
                <body>
                    <p style='color: {_textSettings.Color}; font-size: {_textSettings.Size}px;'>{_textSettings.Text}</p>
                </body>
                </html>";

            response.Write(html);
        }
    }
}