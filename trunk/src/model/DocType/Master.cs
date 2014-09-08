using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vega.USiteBuilder;

namespace Ken99.Model.DocType
{
    [DocumentType(Name = "Master"
        , Alias = "umbMaster")]
    public class Master : DocumentTypeBase
    {
        #region Tab:Content

        [DocumentTypeProperty(UmbracoPropertyType.Textstring
            , Name = "Page title"
            , Alias = "title"
            , Tab = DocTypePropertyTab.Content
            , Description = "The page title overrules the name this page was given. So if the page name is \"About us\" the title could be \"About Our Company Name\".")]
        public string PageTile { get; set; }

        #endregion

        #region Navigation

        [DocumentTypeProperty(UmbracoPropertyType.TrueFalse
            , Name = "Hide in navigation?"
            , Alias = "umbracoNaviHide"
            , Tab = DocTypePropertyTab.Navigation
            , Description = "If set to \"Yes\", this page will be hidden from the navigation menu at the top.")]
        public string HideInNavigation { get; set; }

        #endregion
    }
}
