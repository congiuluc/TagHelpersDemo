using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpersDemo.TagHelpers
{
    [HtmlTargetElement("Time")]
    public class TimeTagHelper:TagHelper
    {
        const string attribute = "";
        public DateTime? DateTime{ get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (DateTime.HasValue) {
                output.Content.SetContent(DateTime.Value.ToString("dd/MM/yyy HH:mm"));
                TagHelperAttribute a;
                output.Attributes.TryGetAttribute("title",out a);
                if (a == null)
                {
                    output.Attributes.Add("title", DateTime.Value.ToUniversalTime());
                }
            }
            else
            {
                output.SuppressOutput();
            }
           
        }
    }
}
