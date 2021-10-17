using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;
using System;

namespace CRUD.APP.Extensions
{
    public class DeleteElementByActionNameTagHelper : TagHelper
    {
        private readonly HttpContextAccessor _contextAccessor;
        public DeleteElementByActionNameTagHelper(HttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        [HtmlAttributeName("supress-by-action")]
        public string Action { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var action = _contextAccessor.HttpContext.GetRouteData().Values["action"].ToString();

            if (action.Contains(Action)) return;

            output.SuppressOutput();
        }
    }
}
