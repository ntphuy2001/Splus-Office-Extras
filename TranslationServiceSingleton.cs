using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splus_Extras
{
    internal class TranslationServiceSingleton
    {
        private static readonly Lazy<TranslationServiceSingleton> lazy =
            new Lazy<TranslationServiceSingleton>(() => new TranslationServiceSingleton());

        public static TranslationServiceSingleton Instance { get { return lazy.Value; } }

        private ITranslationService _currentService;
        private string _sourceLanguage;
        private string _targetLanguage;
        private string _token;

        private TranslationServiceSingleton() {}

        public void SetService(string serviceType)
        {
            _currentService = TranslateServiceStrategyFactory.CreateStrategy(serviceType, _token);
        }

        public void SaveSetting(string sourceLanguage, string targetLanguage, string token)
        {
            _sourceLanguage = sourceLanguage;
            _targetLanguage = targetLanguage;
            _token = token;
        }

        public string TargetLanguage { get => _targetLanguage; }
        public string SourceLanguage { get => _sourceLanguage; }

        public List<string> Translate(List<Range> listResources)
        {
            return _currentService.Translate(listResources, _sourceLanguage, _targetLanguage);
        }
    }
}
