namespace Splus_Extras
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.sourceLanguage = new System.Windows.Forms.Label();
            this.targetLanguage = new System.Windows.Forms.Label();
            this.sourceLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.targetLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.token = new System.Windows.Forms.Label();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.limithWordLabel = new System.Windows.Forms.Label();
            this.limitWordTextbox = new System.Windows.Forms.TextBox();
            this.limitWord = new System.Windows.Forms.Label();
            this.chatgpt = new System.Windows.Forms.RadioButton();
            this.ggtranslate = new System.Windows.Forms.RadioButton();
            this.deepl = new System.Windows.Forms.RadioButton();
            this.version = new System.Windows.Forms.Label();
            this.translateServiceGroup = new System.Windows.Forms.GroupBox();
            this.translateServiceGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(224, 244);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(305, 245);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // sourceLanguage
            // 
            this.sourceLanguage.AutoSize = true;
            this.sourceLanguage.Location = new System.Drawing.Point(10, 65);
            this.sourceLanguage.Name = "sourceLanguage";
            this.sourceLanguage.Size = new System.Drawing.Size(80, 13);
            this.sourceLanguage.TabIndex = 2;
            this.sourceLanguage.Text = "Translate from: ";
            // 
            // targetLanguage
            // 
            this.targetLanguage.AutoSize = true;
            this.targetLanguage.Location = new System.Drawing.Point(10, 100);
            this.targetLanguage.Name = "targetLanguage";
            this.targetLanguage.Size = new System.Drawing.Size(66, 13);
            this.targetLanguage.TabIndex = 3;
            this.targetLanguage.Text = "Translate to:";
            // 
            // sourceLanguageComboBox
            // 
            this.sourceLanguageComboBox.FormattingEnabled = true;
            this.sourceLanguageComboBox.Items.AddRange(new object[] {
            "Chinese",
            "English",
            "Japanese",
            "Vietnamese"});
            this.sourceLanguageComboBox.Location = new System.Drawing.Point(100, 60);
            this.sourceLanguageComboBox.Name = "sourceLanguageComboBox";
            this.sourceLanguageComboBox.Size = new System.Drawing.Size(193, 21);
            this.sourceLanguageComboBox.TabIndex = 4;
            // 
            // targetLanguageComboBox
            // 
            this.targetLanguageComboBox.FormattingEnabled = true;
            this.targetLanguageComboBox.Items.AddRange(new object[] {
            "Chinese",
            "English",
            "Japanese",
            "Vietnamese"});
            this.targetLanguageComboBox.Location = new System.Drawing.Point(100, 95);
            this.targetLanguageComboBox.Name = "targetLanguageComboBox";
            this.targetLanguageComboBox.Size = new System.Drawing.Size(193, 21);
            this.targetLanguageComboBox.TabIndex = 5;
            // 
            // token
            // 
            this.token.AutoSize = true;
            this.token.Location = new System.Drawing.Point(6, 67);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(38, 13);
            this.token.TabIndex = 6;
            this.token.Text = "Token";
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Location = new System.Drawing.Point(94, 64);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(193, 20);
            this.tokenTextBox.TabIndex = 7;
            this.tokenTextBox.UseSystemPasswordChar = true;
            // 
            // limithWordLabel
            // 
            this.limithWordLabel.AutoSize = true;
            this.limithWordLabel.Location = new System.Drawing.Point(10, 30);
            this.limithWordLabel.Name = "limithWordLabel";
            this.limithWordLabel.Size = new System.Drawing.Size(84, 13);
            this.limithWordLabel.TabIndex = 8;
            this.limithWordLabel.Text = "Limit characters:";
            // 
            // limitWordTextbox
            // 
            this.limitWordTextbox.Location = new System.Drawing.Point(100, 25);
            this.limitWordTextbox.Name = "limitWordTextbox";
            this.limitWordTextbox.Size = new System.Drawing.Size(193, 20);
            this.limitWordTextbox.TabIndex = 9;
            // 
            // limitWord
            // 
            this.limitWord.AutoSize = true;
            this.limitWord.Location = new System.Drawing.Point(300, 28);
            this.limitWord.Name = "limitWord";
            this.limitWord.Size = new System.Drawing.Size(80, 13);
            this.limitWord.TabIndex = 10;
            this.limitWord.Text = "(1.000~10.000)";
            // 
            // chatgpt
            // 
            this.chatgpt.AutoSize = true;
            this.chatgpt.Checked = true;
            this.chatgpt.Location = new System.Drawing.Point(57, 29);
            this.chatgpt.Name = "chatgpt";
            this.chatgpt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chatgpt.Size = new System.Drawing.Size(69, 17);
            this.chatgpt.TabIndex = 11;
            this.chatgpt.TabStop = true;
            this.chatgpt.Text = "ChatGPT";
            this.chatgpt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chatgpt.UseMnemonic = false;
            this.chatgpt.UseVisualStyleBackColor = true;
            // 
            // ggtranslate
            // 
            this.ggtranslate.AutoSize = true;
            this.ggtranslate.Location = new System.Drawing.Point(158, 29);
            this.ggtranslate.Name = "ggtranslate";
            this.ggtranslate.Size = new System.Drawing.Size(106, 17);
            this.ggtranslate.TabIndex = 12;
            this.ggtranslate.Text = "Google Translate";
            this.ggtranslate.UseVisualStyleBackColor = true;
            // 
            // deepl
            // 
            this.deepl.AutoSize = true;
            this.deepl.Location = new System.Drawing.Point(308, 29);
            this.deepl.Name = "deepl";
            this.deepl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deepl.Size = new System.Drawing.Size(57, 17);
            this.deepl.TabIndex = 13;
            this.deepl.Text = "DeepL";
            this.deepl.UseVisualStyleBackColor = true;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(10, 250);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(37, 13);
            this.version.TabIndex = 14;
            this.version.Text = "v1.0.0";
            // 
            // translateServiceGroup
            // 
            this.translateServiceGroup.Controls.Add(this.chatgpt);
            this.translateServiceGroup.Controls.Add(this.deepl);
            this.translateServiceGroup.Controls.Add(this.ggtranslate);
            this.translateServiceGroup.Controls.Add(this.token);
            this.translateServiceGroup.Controls.Add(this.tokenTextBox);
            this.translateServiceGroup.Location = new System.Drawing.Point(6, 122);
            this.translateServiceGroup.Name = "translateServiceGroup";
            this.translateServiceGroup.Size = new System.Drawing.Size(371, 99);
            this.translateServiceGroup.TabIndex = 15;
            this.translateServiceGroup.TabStop = false;
            this.translateServiceGroup.Text = "Translate services";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 275);
            this.Controls.Add(this.translateServiceGroup);
            this.Controls.Add(this.version);
            this.Controls.Add(this.limitWord);
            this.Controls.Add(this.limitWordTextbox);
            this.Controls.Add(this.limithWordLabel);
            this.Controls.Add(this.targetLanguageComboBox);
            this.Controls.Add(this.sourceLanguageComboBox);
            this.Controls.Add(this.targetLanguage);
            this.Controls.Add(this.sourceLanguage);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "SettingForm";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.translateServiceGroup.ResumeLayout(false);
            this.translateServiceGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label sourceLanguage;
        private System.Windows.Forms.Label targetLanguage;
        private System.Windows.Forms.ComboBox sourceLanguageComboBox;
        private System.Windows.Forms.ComboBox targetLanguageComboBox;
        private System.Windows.Forms.Label token;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.Label limithWordLabel;
        private System.Windows.Forms.TextBox limitWordTextbox;
        private System.Windows.Forms.Label limitWord;
        private System.Windows.Forms.RadioButton chatgpt;
        private System.Windows.Forms.RadioButton ggtranslate;
        private System.Windows.Forms.RadioButton deepl;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.GroupBox translateServiceGroup;
    }
}