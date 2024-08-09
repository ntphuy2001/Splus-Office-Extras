using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace Splus_Extras
{
    public interface IContentStrategy
    {
        List<Range> GetContent(Document doc);
    }
}
