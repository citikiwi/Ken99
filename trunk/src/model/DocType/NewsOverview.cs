using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vega.USiteBuilder;
using Ken99.Model.Template;

namespace Ken99.Model.DocType
{
    [DocumentType(Name = "News Overview"
        , Alias = "umbNewsOverview"
        , AllowedChildNodeTypeOf = new Type[] { typeof(Home) }
        , AllowedTemplates = new string[] { TemplateAlias.NewsOverview }
        , DefaultTemplate = TemplateAlias.NewsOverview)]
    public class NewsOverview : Master
    {
    }
}
