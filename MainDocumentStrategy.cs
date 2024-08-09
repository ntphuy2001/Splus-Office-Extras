using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splus_Extras.ConcreteContent
{
    internal class MainDocumentStrategy
    {
        public List<string> GetContent(Document doc)
        {
            return doc.Paragraphs.Cast<Paragraph>()
                .Select(p => p.Range.Text.Trim())
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .ToList();
        }
    }
}
