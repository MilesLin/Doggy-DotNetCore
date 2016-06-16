using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DonNetCore.TagHelpers
{
    //[HtmlTargetElement("email", TagStructure = TagStructure.WithoutEndTag)]
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project    
    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "contoso.com";

        // Can be passed via <email mail-to="..." />. 
        // Pascal case gets translated into lower-kebab-case.
        public string MailTo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // 取代email tag
            output.TagName = "a";

            var address = MailTo + "@" + EmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + address);
            //output.Content.SetContent(address);

        }
    }
}
