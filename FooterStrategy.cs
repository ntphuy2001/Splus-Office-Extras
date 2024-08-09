using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splus_Extras
{
    internal class FooterStrategy: IContentStrategy
    {
        public List<Range> GetContent(Document doc)
        {
            return doc.Sections.Cast<Section>()
                .SelectMany(section => section.Footers.Cast<HeaderFooter>())
                .Select(footer => footer.Range)
                .Where(t => !string.IsNullOrWhiteSpace(t.Text.Trim()))
                .ToList();
        }
    }
}
