using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vega.USiteBuilder;
using Ken99.Model.Template;

namespace Ken99.Model.DocType
{
    [DocumentType(Name = "News Item"
        , Alias = "umbNewsItem"
        , AllowedChildNodeTypeOf = new Type[] {typeof(NewsOverview)}
        , AllowedTemplates = new string[] { TemplateAlias.NewsItem }
        , DefaultTemplate = TemplateAlias.NewsItem)]
    public class NewsItem : Master
    {
        #region Content

        [DocumentTypeProperty(UmbracoPropertyType.Upload
            , Name = "Image"
            , Alias = "image"
            , Tab = DocTypePropertyTab.Content
            , Description = "")]
        public string Image { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "Subheader"
            , Alias = "subheader"
            , Tab = DocTypePropertyTab.Content
            , Description = "")]
        public string SubHeader { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.RichtextEditor
            , Name = "Content"
            , Alias = "bodyText"
            , Tab = DocTypePropertyTab.Content
            , Description = "")]
        public string Content { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.DatePickerWithTime
            , Name = "Publish date"
            , Alias = "publishDate"
            , Tab = DocTypePropertyTab.Content
            , Description = "You can overrule the date shown on the site by changing it here. If you don't set a date explicitly here then the news item's create date will be shown.")]
        public string PublishDate { get; set; }

        #endregion
    }
}
