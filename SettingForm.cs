using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Splus_Extras
{
    public partial class SettingForm : Form
    {
        private TranslationServiceSingleton _translationService;

        private void SettingForm_Load(object sender, EventArgs e)
        {
            _translationService = TranslationServiceSingleton.Instance;
        }

        public SettingForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string sourceLanguage = sourceLanguageComboBox.Text;
            string targetLanguage = targetLanguageComboBox.Text;
            string service = SelectedRadioBoxesInGroupBox;
            string token = tokenTextBox.Text;
            _translationService.SetService(service);
            _translationService.SaveSetting(sourceLanguage, targetLanguage, token);
            Close();
        }

        private string SelectedRadioBoxesInGroupBox
        {
            get
            {
                foreach (Control ctrl in translateServiceGroup.Controls)
                {
                    if (ctrl is System.Windows.Forms.RadioButton)
                    {
                        System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)ctrl;
                        if (radioButton.Checked)
                        {
                            return radioButton.Name;
                        }
                    }
                }
                return "chatgpt";
            }
        }
    }
}
