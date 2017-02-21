using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpersDemo.Models
{
    public class WebSiteInfoViewModel
    {
        [Required]
        public int WebSiteId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime LatestUpdate { get; set; }

        public bool IsPrivate { get; set; }

        [Url]
        public string DefaultUrl { get; set; }

        public string LanguageId { get; set; }
        public List<LanguageViewModel> SupportedLanguages { get; set; }

    }
}
