using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splus_Extras
{
    internal interface ITranslationService
    {
        bool connect2Service(string token);
        List<string> Translate(List<Range> listResources,
                               string sourceLanguage,
                               string targetLanguage);
    }
}
