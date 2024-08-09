namespace Splus_Extras
{
    partial class SplusExtras : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SplusExtras()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplusExtras));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.translatorGroup = this.Factory.CreateRibbonGroup();
            this.translatorBox = this.Factory.CreateRibbonBox();
            this.documentButton = this.Factory.CreateRibbonButton();
            this.selectionButton = this.Factory.CreateRibbonButton();
            this.boxSeparator = this.Factory.CreateRibbonSeparator();
            this.settingBox = this.Factory.CreateRibbonBox();
            this.settingButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.translatorGroup.SuspendLayout();
            this.translatorBox.SuspendLayout();
            this.settingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.translatorGroup);
            this.tab1.Label = "Splus-Extras";
            this.tab1.Name = "tab1";
            // 
            // translatorGroup
            // 
            this.translatorGroup.Items.Add(this.translatorBox);
            this.translatorGroup.Items.Add(this.boxSeparator);
            this.translatorGroup.Items.Add(this.settingBox);
            this.translatorGroup.Label = "Translator";
            this.translatorGroup.Name = "translatorGroup";
            // 
            // translatorBox
            // 
            this.translatorBox.Items.Add(this.documentButton);
            this.translatorBox.Items.Add(this.selectionButton);
            this.translatorBox.Name = "translatorBox";
            // 
            // documentButton
            // 
            this.documentButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.documentButton.Image = ((System.Drawing.Image)(resources.GetObject("documentButton.Image")));
            this.documentButton.Label = "Document";
            this.documentButton.Name = "documentButton";
            this.documentButton.ScreenTip = "2";
            this.documentButton.ShowImage = true;
            this.documentButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.documentButton_Click);
            // 
            // selectionButton
            // 
            this.selectionButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.selectionButton.Image = ((System.Drawing.Image)(resources.GetObject("selectionButton.Image")));
            this.selectionButton.Label = "Selection";
            this.selectionButton.Name = "selectionButton";
            this.selectionButton.ShowImage = true;
            this.selectionButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.selectionButton_Click);
            // 
            // boxSeparator
            // 
            this.boxSeparator.Name = "boxSeparator";
            // 
            // settingBox
            // 
            this.settingBox.Items.Add(this.settingButton);
            this.settingBox.Name = "settingBox";
            // 
            // settingButton
            // 
            this.settingButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.settingButton.Image = ((System.Drawing.Image)(resources.GetObject("settingButton.Image")));
            this.settingButton.Label = "Setting";
            this.settingButton.Name = "settingButton";
            this.settingButton.ShowImage = true;
            this.settingButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.settingButton_Click);
            // 
            // SplusExtras
            // 
            this.Name = "SplusExtras";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.SplusExtras_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.translatorGroup.ResumeLayout(false);
            this.translatorGroup.PerformLayout();
            this.translatorBox.ResumeLayout(false);
            this.translatorBox.PerformLayout();
            this.settingBox.ResumeLayout(false);
            this.settingBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup translatorGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox translatorBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton documentButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton selectionButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox settingBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton settingButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator boxSeparator;
    }

    partial class ThisRibbonCollection
    {
        internal SplusExtras SplusExtras
        {
            get { return this.GetRibbon<SplusExtras>(); }
        }
    }
}
