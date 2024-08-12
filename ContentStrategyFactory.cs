using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splus_Extras
{
    internal class ContentStrategyFactory
    {
        public static IContentStrategy CreateStrategy(string strategyType)
        {
            switch (strategyType.ToLower())
            {
                case "main": return new MainDocumentStrategy();
                case "table": return new TableStrategy();
                case "textbox": return new TextBoxStrategy();
                case "header": return new HeaderStrategy();
                case "footer": return new FooterStrategy();
                default: throw new ArgumentException("Invalid strategy type");
            }
        }
    }
}
