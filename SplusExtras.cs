using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Splus_Extras
{
    public partial class SplusExtras
    {
        private WordEntireDocument _wordDoc;
        private TranslationServiceSingleton _translationService = TranslationServiceSingleton.Instance;

        private void SplusExtras_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void documentButton_Click(object sender, RibbonControlEventArgs e)
        {
            _wordDoc = new WordEntireDocument();
            var mainTexts = _wordDoc.GetContent("textbox");
            var translatedTexts = _translationService.Translate(mainTexts);
            DisplayTextList(mainTexts, translatedTexts, true);
        }

        private void DisplayTextList(List<Range> texts, List<string> translatedTexts, bool isAddNewLine=false)
        {
            if (texts.Count == 0)
            {
                return;
            }
            for (int i = texts.Count - 1; i >= 0; i--)
            {
                Range range = texts[i];
                string translatedText = Regex.Replace(range.Text, @"^[^\t\r\n]+|[^\t\r\n]+$", translatedTexts[i]);

                if (range.ShapeRange.Count == 0)
                {
                    range.Text = translatedText;
                    continue;
                }

                // Lưu các Shapes tạm thời
                var shapesInfo = new List<(float left, float top, float width, float height, string text)>();
                
                foreach (Shape shape in range.ShapeRange)
                {
                    shapesInfo.Add((shape.Left, shape.Top, shape.Width, shape.Height, shape.TextFrame.HasText == ((int)Microsoft.Office.Core.MsoTriState.msoTrue) ? shape.TextFrame.TextRange.Text : ""));
                }
                var shapes = new List<Shape>();
                foreach (Shape shape in range.ShapeRange)
                {
                    shapes.Add(shape);
                }

                range.Text = translatedText;

                // Chèn lại các Shapes vào vị trí ban đầu
                foreach (var shape in shapes)
                {
                    // Đảm bảo rằng shape vẫn tồn tại trong tài liệu trước khi chèn lại
                    if (shape.Parent != null)
                    {
                        shape.Select();
                        range.Paste();
                    }
                }
            }
        }

        private void selectionButton_Click(object sender, RibbonControlEventArgs e)
        {
            _wordDoc = new WordEntireDocument();
            
            var textBox = _wordDoc.GetContent("table");

            var translatedTexts = _translationService.Translate(textBox);
            DisplayTextList(textBox, translatedTexts);
        }

        private void settingButton_Click(object sender, RibbonControlEventArgs e)
        {
            _wordDoc = new WordEntireDocument();
            var mainTexts = _wordDoc.GetContent("main");

            _translationService.SaveSetting("en", "ja", "token");
            _translationService.SetService("chatgpt");

            var translatedTexts = _translationService.Translate(mainTexts);

            DisplayTextList(mainTexts, translatedTexts);
        }
    }
}
