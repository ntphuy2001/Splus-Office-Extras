using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splus_Extras
{
    internal class WordEntireDocument
    {
        private Application _wordApp;
        private Document _currentDoc;

        public WordEntireDocument()
        {
            _wordApp = Globals.ThisAddIn.Application;
            _currentDoc = _wordApp.ActiveDocument;
        }

        public List<Range> GetContent(string contentType)
        {
            if (_currentDoc == null) return new List<Range>();
            var strategy = ContentStrategyFactory.CreateStrategy(contentType);
            return strategy.GetContent(_currentDoc);
        }
    }
}
