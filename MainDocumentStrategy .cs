using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splus_Extras
{
    internal class MainDocumentStrategy: IContentStrategy
    {
        public List<Range> GetContent(Document doc)
        {
            return doc.Paragraphs.Cast<Paragraph>()
                .Where(p => !(bool)p.Range.Information[WdInformation.wdWithInTable])
                .Select(p => p.Range)
                .Where(t => !string.IsNullOrWhiteSpace(t.Text.Trim()))
                .ToList();
        }
    }
}
