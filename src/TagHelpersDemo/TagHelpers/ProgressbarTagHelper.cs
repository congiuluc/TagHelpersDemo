using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpersDemo.TagHelpers
{

    // [HtmlTargetElement("div", Attributes = ProgressValueAttributeName)]
    
    public class BsProgressBarTagHelper:TagHelper
    {
        public BsProgressBarTagHelper()
        {
            MinValue = 0;
            MaxValue = 100;
        }
        private const string ProgressValueAttributeName = "bs-progress";
        public int Value { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            
            output.TagName = "div";
            output.Content.SetContent(string.Format("{0}%", Value));
            if (output.Attributes.ContainsName("class")) {
                output.Attributes.SetAttribute("class", string.Format("progress-bar {0}", output.Attributes["class"].Value));
            }
            else
            {
                output.Attributes.SetAttribute("class", "progress-bar");
            }
            output.Attributes.SetAttribute("role", "progressbar");
            output.Attributes.SetAttribute("aria-valuenow", Value);
            output.Attributes.SetAttribute("aria-valuemin", MinValue);
            output.Attributes.SetAttribute("aria-valuemax", MaxValue);
            output.Attributes.SetAttribute("style", string.Format("width: {0}%;", Value));

            output.PreElement.AppendHtml(@"<div class='progress'>");
            output.PostElement.AppendHtml(@"</div>");
            
        }
    }
}
