using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Splus_Extras
{
    public partial class SplusExtras
    {
        private WordEntireDocument _wordDoc;
        private TranslationServiceSingleton _translationService;
        private SettingForm _settingForm;

        private void SplusExtras_Load(object sender, RibbonUIEventArgs e)
        {
            _translationService = TranslationServiceSingleton.Instance;
            _translationService.SaveSetting("en", "ja", "token");
            _translationService.SetService("chatgpt");
            _settingForm  = new SettingForm();
        }

        private void documentButton_Click(object sender, RibbonControlEventArgs e)
        {
            _wordDoc = new WordEntireDocument();
            var mainTexts = _wordDoc.GetContent("main");
            var textBoxes = _wordDoc.GetContent("textbox");
            var tables = _wordDoc.GetContent("table");
            var header = _wordDoc.GetContent("header");
            var footer = _wordDoc.GetContent("footer");

            var translatedMainTexts = _translationService.Translate(mainTexts);
            var translatedTextBoxex = _translationService.Translate(textBoxes);
            var translatedTables = _translationService.Translate(tables);
            var translatedHeader = _translationService.Translate(header);
            var translatedFooter = _translationService.Translate(footer);

            ReplaceTextsList(mainTexts, translatedMainTexts, true);
            ReplaceTextsList(textBoxes, translatedTextBoxex);
            ReplaceTextsList(tables, translatedTables);
            ReplaceTextsList(header, translatedHeader);
            ReplaceTextsList(footer, translatedFooter);

        }

        private void selectionButton_Click(object sender, RibbonControlEventArgs e)
        {
            _wordDoc = new WordEntireDocument();
            var textBox = _wordDoc.GetContent("table");

            var translatedTexts = _translationService.Translate(textBox);
            ReplaceTextsList(textBox, translatedTexts);
        }

        private void settingButton_Click(object sender, RibbonControlEventArgs e)
        {
            _settingForm.StartPosition = FormStartPosition.CenterParent;
            _settingForm.ShowDialog();
        }

        private void ReplaceTextsList(List<Range> texts, List<string> translatedTexts, bool isAddNewLine = false)
        {
            if (texts.Count == 0)
            {
                return;
            }
            for (int i = texts.Count - 1; i >= 0; i--)
            {
                Range range = texts[i];
                string translatedText = Regex.Replace(range.Text, @"^[^\t\r\n]+|[^\t\r\n]+$", translatedTexts[i]);
                if (!isAddNewLine)
                {
                    translatedText = translatedText.TrimEnd();
                }

                if (range.ShapeRange.Count == 0)
                {
                    range.Text = translatedText;
                    continue;
                }
            }
        }
    }
}
