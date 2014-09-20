using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vega.USiteBuilder;
using Ken99.Model.Template;

namespace Ken99.Model.DocType
{
    [DocumentType(Name = "TextPage"
        , Alias = "umbTextPage"
        , AllowedChildNodeTypeOf = new Type[] { typeof(Home) }
        , AllowedChildNodeTypes = new Type[] {typeof(TextPage), typeof(NewsOverview) }
        , AllowedTemplates = new string[] { TemplateAlias.TextPage }
        , DefaultTemplate = TemplateAlias.TextPage)]
    public class TextPage : Master
    {
        #region Content

        [DocumentTypeProperty(UmbracoPropertyType.TrueFalse
            , Name = "Featured Page?"
            , Alias = "featuredPage"
            , Tab = DocTypePropertyTab.Content
            , Description = "Is this a page that should be featured on the home page?")]
        public string FeaturedPage { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Upload
            , Name = "Image"
            , Alias = "image"
            , Tab = DocTypePropertyTab.Content
            , Description = "")]
        public string SubHeader { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.RichtextEditor
            , Name = "Content"
            , Alias = "bodyText"
            , Tab = DocTypePropertyTab.Content
            , Description = "")]
        public string Content { get; set; }

        #endregion

    }
}
