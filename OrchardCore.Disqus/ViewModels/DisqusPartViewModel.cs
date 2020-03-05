using Microsoft.AspNetCore.Mvc.ModelBinding;
using OrchardCore.ContentManagement;
using OrchardCore.Disqus.Models;
using OrchardCore.Disqus.Settings;

namespace OrchardCore.Disqus.ViewModels
{
    public class DisqusPartViewModel
    {
        public string ShortName { get; set; }

        public bool ShowComments { get; set; }

        [BindNever]
        public ContentItem ContentItem { get; set; }

        [BindNever]
        public DisqusPart DisqusPart { get; set; }

        [BindNever]
        public DisqusPartSettings Settings { get; set; }
    }
}
