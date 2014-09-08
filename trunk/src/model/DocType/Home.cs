using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vega.USiteBuilder;
using Ken99.Model.Template;

namespace Ken99.Model.DocType
{
    [DocumentType(Name = "Home"
        , Alias = "umbHomePage"
        , AllowAtRoot = true
        , AllowedTemplates = new string[]{TemplateAlias.HomePage}
        , DefaultTemplate = TemplateAlias.HomePage)]
    public class Home : Master
    {
        #region Social

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "Facebook link"
            , Alias = "facebookLink"
            , Tab = DocTypePropertyTab.Social
            , Description = "")]
        public string FacebookLink { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "Twitter link"
            , Alias = "twitterLink"
            , Tab = DocTypePropertyTab.Social
            , Description = "")]
        public string TwitterLink { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "Rss link"
            , Alias = "rssLink"
            , Tab = DocTypePropertyTab.Social
            , Description = "")]
        public string RssLink { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "Dribbble link"
            , Alias = "dribbbleLink"
            , Tab = DocTypePropertyTab.Social
            , Description = "")]
        public string DribbbleLink { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "LinkedIn link"
            , Alias = "linkedInLink"
            , Tab = DocTypePropertyTab.Social
            , Description = "")]
        public string LinkedInLink { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "Google+ link"
            , Alias = "googleLink"
            , Tab = DocTypePropertyTab.Social
            , Description = "")]
        public string GooglePluslink { get; set; }

        #endregion

        #region Content

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "Site Name"
            , Alias = "siteName"
            , Tab = DocTypePropertyTab.Content
            , Description = "")]
        public string SiteName { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "Byline"
            , Alias = "byline"
            , Tab = DocTypePropertyTab.Content
            , Description = "")]
        public string ByLine { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "Copyright"
            , Alias = "copyright"
            , Tab = DocTypePropertyTab.Content
            , Description = "")]
        public string CopyRight { get; set; }

        #endregion

        #region Banner

        [DocumentTypeProperty(UmbracoPropertyType.TrueFalse
            , Name = "Hide banner?"
            , Alias = "hideBanner"
            , Tab = DocTypePropertyTab.Banner
            , Description = "")]
        public string HideBanner { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "Banner Header"
            , Alias = "bannerHeader"
            , Tab = DocTypePropertyTab.Banner
            , Description = "")]
        public string BannerHeader { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "Banner Subheader"
            , Alias = "bannerSubheader"
            , Tab = DocTypePropertyTab.Banner
            , Description = "")]
        public string BannerSubheader { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "Banner link text"
            , Alias = "bannerLinkText"
            , Tab = DocTypePropertyTab.Banner
            , Description = "")]
        public string BannerLinkText { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.ContentPicker
            , Name = "Banner link"
            , Alias = "bannerLink"
            , Tab = DocTypePropertyTab.Banner
            , Description = "")]
        public string BannerLink { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.Upload
            , Name = "Banner background image"
            , Alias = "bannerBackgroundImage"
            , Tab = DocTypePropertyTab.Banner
            , Description = "")]
        public string BannerBackgroundImage { get; set; }


        #endregion

        #region Abount

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "About Title"
            , Alias = "aboutTitle"
            , Tab = DocTypePropertyTab.About
            , Description = "")]
        public string AboutTitle { get; set; }

        [DocumentTypeProperty(UmbracoPropertyType.RichtextEditor
            , Name = "About Text"
            , Alias = "aboutText"
            , Tab = DocTypePropertyTab.About
            , Description = "")]
        public string AboutText { get; set; }

        #endregion
    }
}
