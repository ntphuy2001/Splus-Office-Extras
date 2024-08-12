using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splus_Extras
{
    internal class DeepLTranslateService: ITranslationService
    {
        private string _token;

        public DeepLTranslateService(string token)
        {
            _token = token;
        }

        public bool connect2Service(string token)
        {
            return true;
        }

        public List<string> Translate(List<Range> listResources, string sourceLanguage, string targetLanguage)
        {
            string _prompt = $"Translate from {sourceLanguage} to {targetLanguage}";
            List<string> listResult = new List<string>();

            for (int i = 0; i < listResources.Count; i++)
            {
                Range resource = listResources[i];
                listResult.Add($"DeepL translate from {sourceLanguage} to {targetLanguage}: {resource.Text.TrimEnd()}");
            }

            return listResult;
        }
    }
}
