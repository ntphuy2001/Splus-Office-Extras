using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splus_Extras
{
    internal class TranslateServiceStrategyFactory
    {
        public static ITranslationService CreateStrategy(string strategyType, string token)
        {
            switch (strategyType.ToLower())
            {
                case "chatgpt": return new ChatGPTTranslateService(token);
                case "ggtranslate": return new GGTranslateService(token);
                case "deepl": return new DeepLTranslateService(token);
                default: throw new ArgumentException("Invalid strategy type");
            }
        }
    }
}
