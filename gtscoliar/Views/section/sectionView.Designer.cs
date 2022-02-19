namespace gtscoliar.Views.sectionView {
    partial class sectionView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.sectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.numrosctionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemFornumrosction = new DevExpress.XtraLayout.LayoutControlItem();
            this.nomsectionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemFornomsection = new DevExpress.XtraLayout.LayoutControlItem();
            this.modeformationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemFormodeformation = new DevExpress.XtraLayout.LayoutControlItem();
            this.optionsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForoptions = new DevExpress.XtraLayout.LayoutControlItem();
            this.promoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForpromo = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiCustomize = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupLayout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrosctionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornumrosction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomsectionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornomsection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeformationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormodeformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForoptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.numrosctionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.nomsectionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.modeformationTextEdit);
            this.dataLayoutControl1.Controls.Add(this.optionsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.promoTextEdit);
            this.dataLayoutControl1.DataSource = this.sectionViewBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 126);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1024, 642);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1024, 642);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // sectionViewBindingSource
            // 
            this.sectionViewBindingSource.DataSource = typeof(gtscoliar.Database.section);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemFornumrosction,
            this.ItemFornomsection,
            this.ItemFormodeformation,
            this.ItemForoptions,
            this.ItemForpromo});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1004, 622);
            // 
            // numrosctionTextEdit
            // 
            this.numrosctionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sectionViewBindingSource, "numrosction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numrosctionTextEdit.Location = new System.Drawing.Point(96, 12);
            this.numrosctionTextEdit.Name = "numrosctionTextEdit";
            this.numrosctionTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.numrosctionTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.numrosctionTextEdit.Properties.Mask.EditMask = "N0";
            this.numrosctionTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.numrosctionTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numrosctionTextEdit.Size = new System.Drawing.Size(916, 20);
            this.numrosctionTextEdit.StyleController = this.dataLayoutControl1;
            this.numrosctionTextEdit.TabIndex = 4;
            this.numrosctionTextEdit.EditValueChanged += new System.EventHandler(this.numrosctionTextEdit_EditValueChanged);
            // 
            // ItemFornumrosction
            // 
            this.ItemFornumrosction.Control = this.numrosctionTextEdit;
            this.ItemFornumrosction.Location = new System.Drawing.Point(0, 0);
            this.ItemFornumrosction.Name = "ItemFornumrosction";
            this.ItemFornumrosction.Size = new System.Drawing.Size(1004, 24);
            this.ItemFornumrosction.Text = "numrosction";
            this.ItemFornumrosction.TextSize = new System.Drawing.Size(72, 13);
            // 
            // nomsectionTextEdit
            // 
            this.nomsectionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sectionViewBindingSource, "nomsection", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nomsectionTextEdit.Location = new System.Drawing.Point(96, 36);
            this.nomsectionTextEdit.Name = "nomsectionTextEdit";
            this.nomsectionTextEdit.Size = new System.Drawing.Size(916, 20);
            this.nomsectionTextEdit.StyleController = this.dataLayoutControl1;
            this.nomsectionTextEdit.TabIndex = 5;
            // 
            // ItemFornomsection
            // 
            this.ItemFornomsection.Control = this.nomsectionTextEdit;
            this.ItemFornomsection.Location = new System.Drawing.Point(0, 24);
            this.ItemFornomsection.Name = "ItemFornomsection";
            this.ItemFornomsection.Size = new System.Drawing.Size(1004, 24);
            this.ItemFornomsection.Text = "nomsection";
            this.ItemFornomsection.TextSize = new System.Drawing.Size(72, 13);
            // 
            // modeformationTextEdit
            // 
            this.modeformationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sectionViewBindingSource, "modeformation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modeformationTextEdit.Location = new System.Drawing.Point(96, 60);
            this.modeformationTextEdit.Name = "modeformationTextEdit";
            this.modeformationTextEdit.Size = new System.Drawing.Size(916, 20);
            this.modeformationTextEdit.StyleController = this.dataLayoutControl1;
            this.modeformationTextEdit.TabIndex = 6;
            // 
            // ItemFormodeformation
            // 
            this.ItemFormodeformation.Control = this.modeformationTextEdit;
            this.ItemFormodeformation.Location = new System.Drawing.Point(0, 48);
            this.ItemFormodeformation.Name = "ItemFormodeformation";
            this.ItemFormodeformation.Size = new System.Drawing.Size(1004, 24);
            this.ItemFormodeformation.Text = "modeformation";
            this.ItemFormodeformation.TextSize = new System.Drawing.Size(72, 13);
            // 
            // optionsTextEdit
            // 
            this.optionsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sectionViewBindingSource, "options", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.optionsTextEdit.Location = new System.Drawing.Point(96, 84);
            this.optionsTextEdit.Name = "optionsTextEdit";
            this.optionsTextEdit.Size = new System.Drawing.Size(916, 20);
            this.optionsTextEdit.StyleController = this.dataLayoutControl1;
            this.optionsTextEdit.TabIndex = 7;
            // 
            // ItemForoptions
            // 
            this.ItemForoptions.Control = this.optionsTextEdit;
            this.ItemForoptions.Location = new System.Drawing.Point(0, 72);
            this.ItemForoptions.Name = "ItemForoptions";
            this.ItemForoptions.Size = new System.Drawing.Size(1004, 24);
            this.ItemForoptions.Text = "options";
            this.ItemForoptions.TextSize = new System.Drawing.Size(72, 13);
            // 
            // promoTextEdit
            // 
            this.promoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sectionViewBindingSource, "promo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.promoTextEdit.Location = new System.Drawing.Point(96, 108);
            this.promoTextEdit.Name = "promoTextEdit";
            this.promoTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.promoTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.promoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.promoTextEdit.Properties.Mask.EditMask = "N0";
            this.promoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.promoTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.promoTextEdit.Size = new System.Drawing.Size(916, 20);
            this.promoTextEdit.StyleController = this.dataLayoutControl1;
            this.promoTextEdit.TabIndex = 8;
            // 
            // ItemForpromo
            // 
            this.ItemForpromo.Control = this.promoTextEdit;
            this.ItemForpromo.Location = new System.Drawing.Point(0, 96);
            this.ItemForpromo.Name = "ItemForpromo";
            this.ItemForpromo.Size = new System.Drawing.Size(1004, 526);
            this.ItemForpromo.Text = "promo";
            this.ItemForpromo.TextSize = new System.Drawing.Size(72, 13);
            // 
            // mvvmContext
            // 
            this.mvvmContext.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtscoliar.ViewModels.sectionViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtscoliar.ViewModels.sectionViewModel), "SaveAndClose", this.bbiSaveAndClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtscoliar.ViewModels.sectionViewModel), "SaveAndNew", this.bbiSaveAndNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtscoliar.ViewModels.sectionViewModel), "Reset", this.bbiReset),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtscoliar.ViewModels.sectionViewModel), "Delete", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtscoliar.ViewModels.sectionViewModel), "Close", this.bbiClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtscoliar.ViewModels.sectionViewModel), "SaveLayout", this.bbiSaveLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(gtscoliar.ViewModels.sectionViewModel), "ResetLayout", this.bbiResetLayout)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
            this.mvvmContext.ViewModelType = typeof(gtscoliar.ViewModels.sectionViewModel);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Save And New";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            // 
            // bbiSaveLayout
            // 
            this.bbiSaveLayout.Caption = "Save Layout";
            this.bbiSaveLayout.Id = 8;
            this.bbiSaveLayout.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSaveLayout.Name = "bbiSaveLayout";
            // 
            // bbiResetLayout
            // 
            this.bbiResetLayout.Caption = "Reset Layout";
            this.bbiResetLayout.Id = 9;
            this.bbiResetLayout.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiResetLayout.Name = "bbiResetLayout";
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiCustomize,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose,
            this.bbiSaveLayout,
            this.bbiResetLayout,
            this.mainRibbonControl.SearchEditItem});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1024, 126);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiCustomize
            // 
            this.bbiCustomize.Caption = "Customize";
            this.bbiCustomize.Id = 1;
            this.bbiCustomize.ImageOptions.ImageUri.Uri = "Customization";
            this.bbiCustomize.Name = "bbiCustomize";
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup,
            this.ribbonPageGroupLayout});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndNew);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiDelete);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "section Tasks";
            // 
            // ribbonPageGroupLayout
            // 
            this.ribbonPageGroupLayout.AllowTextClipping = false;
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiCustomize);
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiSaveLayout);
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiResetLayout);
            this.ribbonPageGroupLayout.Name = "ribbonPageGroupLayout";
            this.ribbonPageGroupLayout.Text = "Layout";
            // 
            // sectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "sectionView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrosctionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornumrosction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomsectionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornomsection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeformationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormodeformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForoptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
		private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
		private DevExpress.XtraBars.BarButtonItem bbiCustomize;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupLayout;
		private System.Windows.Forms.BindingSource sectionViewBindingSource;
        private DevExpress.XtraEditors.TextEdit numrosctionTextEdit;
        private DevExpress.XtraEditors.TextEdit nomsectionTextEdit;
        private DevExpress.XtraEditors.TextEdit modeformationTextEdit;
        private DevExpress.XtraEditors.TextEdit optionsTextEdit;
        private DevExpress.XtraEditors.TextEdit promoTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemFornumrosction;
        private DevExpress.XtraLayout.LayoutControlItem ItemFornomsection;
        private DevExpress.XtraLayout.LayoutControlItem ItemFormodeformation;
        private DevExpress.XtraLayout.LayoutControlItem ItemForoptions;
        private DevExpress.XtraLayout.LayoutControlItem ItemForpromo;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveLayout;
        private DevExpress.XtraBars.BarButtonItem bbiResetLayout;
    }
}
