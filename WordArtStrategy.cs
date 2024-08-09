using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splus_Extras
{
    internal class WordArtStrategy: IContentStrategy
    {
        public List<Range> GetContent(Document doc)
        {
            return doc.Shapes.Cast<Microsoft.Office.Interop.Word.Shape>()
                .Where(s => s.Type == MsoShapeType.msoTextEffect)
                .Select(s => s.TextFrame.TextRange)
                .Where(t => !string.IsNullOrWhiteSpace(t.Text.Trim()))
                .ToList();
        }
    }
}
