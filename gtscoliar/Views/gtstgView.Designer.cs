namespace gtscoliar.Views.gtstgView {
    partial class gtstgView {
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
			this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.ribbonPageGroupNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
			this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
			this.officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
									this.navigationBarItemanne_scoliarCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemanne_scoliarCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemevaluerCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemevaluerCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemmode_de_formationCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemmode_de_formationCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemmoduleCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemmoduleCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemoptionCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemoptionCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItempromoCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItempromoCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemsectionCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemsectionCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemsemasetreCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemsemasetreCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemSpecialitéCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemSpecialitéCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemstgCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemstgCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemsysdiagramCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemsysdiagramCollectionView = new DevExpress.XtraBars.BarButtonItem();
						            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
            this.SuspendLayout();
			// 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.MaxItemId = 14;
            this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.skinRibbonGalleryBarItem, this.barSubItemNavigation });
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
			this.ribbonPageGroupNavigation,
            this.ribbonPageGroup});
			this.ribbonPage.MergeOrder = -1;
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "View";
			// 
            // ribbonPageGroupNavigation
            // 
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barSubItemNavigation);
            this.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation";
            this.ribbonPageGroupNavigation.Text = "Module";
			 // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.Name = "barSubItemNavigation";
			            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowTextClipping = false;
			this.ribbonPageGroup.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.ShowCaptionButton = false;
            this.ribbonPageGroup.Text = "Appearance";
			// 
            // ribbonStatusBar
            // 
			this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
			// 
            // officeNavigationBar
            //
			this.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom; 
            this.officeNavigationBar.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            			this.navigationBarItemanne_scoliarCollectionView,
						this.navigationBarItemevaluerCollectionView,
						this.navigationBarItemmode_de_formationCollectionView,
						this.navigationBarItemmoduleCollectionView,
						this.navigationBarItemoptionCollectionView,
						this.navigationBarItempromoCollectionView,
						this.navigationBarItemsectionCollectionView,
						this.navigationBarItemsemasetreCollectionView,
						this.navigationBarItemSpecialitéCollectionView,
						this.navigationBarItemstgCollectionView,
						this.navigationBarItemsysdiagramCollectionView,
									
			});
            this.officeNavigationBar.Name = "officeNavigationBar";
            this.officeNavigationBar.Text = "officeNavigationBar";
						// 
            // navigationBarItemanne_scoliarCollectionView
            // 
			this.navigationBarItemanne_scoliarCollectionView.Name = "navigationBarItemanne_scoliarCollectionView";
            this.navigationBarItemanne_scoliarCollectionView.Text = "anne scoliar";
			// 
            // barButtonItemanne_scoliarCollectionView
            // 
			this.barButtonItemanne_scoliarCollectionView.Name = "barButtonItemanne_scoliarCollectionView";
            this.barButtonItemanne_scoliarCollectionView.Caption = "anne scoliar";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemanne_scoliarCollectionView));
					
						// 
            // navigationBarItemevaluerCollectionView
            // 
			this.navigationBarItemevaluerCollectionView.Name = "navigationBarItemevaluerCollectionView";
            this.navigationBarItemevaluerCollectionView.Text = "evaluers";
			// 
            // barButtonItemevaluerCollectionView
            // 
			this.barButtonItemevaluerCollectionView.Name = "barButtonItemevaluerCollectionView";
            this.barButtonItemevaluerCollectionView.Caption = "evaluers";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemevaluerCollectionView));
					
						// 
            // navigationBarItemmode_de_formationCollectionView
            // 
			this.navigationBarItemmode_de_formationCollectionView.Name = "navigationBarItemmode_de_formationCollectionView";
            this.navigationBarItemmode_de_formationCollectionView.Text = "mode de formations";
			// 
            // barButtonItemmode_de_formationCollectionView
            // 
			this.barButtonItemmode_de_formationCollectionView.Name = "barButtonItemmode_de_formationCollectionView";
            this.barButtonItemmode_de_formationCollectionView.Caption = "mode de formations";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemmode_de_formationCollectionView));
					
						// 
            // navigationBarItemmoduleCollectionView
            // 
			this.navigationBarItemmoduleCollectionView.Name = "navigationBarItemmoduleCollectionView";
            this.navigationBarItemmoduleCollectionView.Text = "modules";
			// 
            // barButtonItemmoduleCollectionView
            // 
			this.barButtonItemmoduleCollectionView.Name = "barButtonItemmoduleCollectionView";
            this.barButtonItemmoduleCollectionView.Caption = "modules";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemmoduleCollectionView));
					
						// 
            // navigationBarItemoptionCollectionView
            // 
			this.navigationBarItemoptionCollectionView.Name = "navigationBarItemoptionCollectionView";
            this.navigationBarItemoptionCollectionView.Text = "options";
			// 
            // barButtonItemoptionCollectionView
            // 
			this.barButtonItemoptionCollectionView.Name = "barButtonItemoptionCollectionView";
            this.barButtonItemoptionCollectionView.Caption = "options";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemoptionCollectionView));
					
						// 
            // navigationBarItempromoCollectionView
            // 
			this.navigationBarItempromoCollectionView.Name = "navigationBarItempromoCollectionView";
            this.navigationBarItempromoCollectionView.Text = "promoes";
			// 
            // barButtonItempromoCollectionView
            // 
			this.barButtonItempromoCollectionView.Name = "barButtonItempromoCollectionView";
            this.barButtonItempromoCollectionView.Caption = "promoes";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItempromoCollectionView));
					
						// 
            // navigationBarItemsectionCollectionView
            // 
			this.navigationBarItemsectionCollectionView.Name = "navigationBarItemsectionCollectionView";
            this.navigationBarItemsectionCollectionView.Text = "sections";
			// 
            // barButtonItemsectionCollectionView
            // 
			this.barButtonItemsectionCollectionView.Name = "barButtonItemsectionCollectionView";
            this.barButtonItemsectionCollectionView.Caption = "sections";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemsectionCollectionView));
					
						// 
            // navigationBarItemsemasetreCollectionView
            // 
			this.navigationBarItemsemasetreCollectionView.Name = "navigationBarItemsemasetreCollectionView";
            this.navigationBarItemsemasetreCollectionView.Text = "semasetres";
			// 
            // barButtonItemsemasetreCollectionView
            // 
			this.barButtonItemsemasetreCollectionView.Name = "barButtonItemsemasetreCollectionView";
            this.barButtonItemsemasetreCollectionView.Caption = "semasetres";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemsemasetreCollectionView));
					
						// 
            // navigationBarItemSpecialitéCollectionView
            // 
			this.navigationBarItemSpecialitéCollectionView.Name = "navigationBarItemSpecialitéCollectionView";
            this.navigationBarItemSpecialitéCollectionView.Text = "Specialité";
			// 
            // barButtonItemSpecialitéCollectionView
            // 
			this.barButtonItemSpecialitéCollectionView.Name = "barButtonItemSpecialitéCollectionView";
            this.barButtonItemSpecialitéCollectionView.Caption = "Specialité";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSpecialitéCollectionView));
					
						// 
            // navigationBarItemstgCollectionView
            // 
			this.navigationBarItemstgCollectionView.Name = "navigationBarItemstgCollectionView";
            this.navigationBarItemstgCollectionView.Text = "stgs";
			// 
            // barButtonItemstgCollectionView
            // 
			this.barButtonItemstgCollectionView.Name = "barButtonItemstgCollectionView";
            this.barButtonItemstgCollectionView.Caption = "stgs";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemstgCollectionView));
					
						// 
            // navigationBarItemsysdiagramCollectionView
            // 
			this.navigationBarItemsysdiagramCollectionView.Name = "navigationBarItemsysdiagramCollectionView";
            this.navigationBarItemsysdiagramCollectionView.Text = "sysdiagrams";
			// 
            // barButtonItemsysdiagramCollectionView
            // 
			this.barButtonItemsysdiagramCollectionView.Name = "barButtonItemsysdiagramCollectionView";
            this.barButtonItemsysdiagramCollectionView.Caption = "sysdiagrams";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemsysdiagramCollectionView));
					
							
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(gtscoliar.ViewModels.gtstgViewModel);
			 // 
            // navigationFrame
            // 
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.Text = "navigationFrame";
			// 
            // gtstgView
            // 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.officeNavigationBar);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "gtstgView";
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
		}
		
        #endregion

		private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
		private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
		private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
		private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame; 
						private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemanne_scoliarCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemanne_scoliarCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemevaluerCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemevaluerCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemmode_de_formationCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemmode_de_formationCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemmoduleCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemmoduleCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemoptionCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemoptionCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItempromoCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItempromoCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemsectionCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemsectionCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemsemasetreCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemsemasetreCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemSpecialitéCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemSpecialitéCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemstgCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemstgCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemsysdiagramCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemsysdiagramCollectionView;
					}
}
