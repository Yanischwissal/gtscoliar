using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;
using System.Threading;

namespace gtscoliar.Views.gtstgView{
    public partial class gtstgView : XtraUserControl {
        public gtstgView() {
			InitializeComponent();
           

            if (!mvvmContext.IsDesignMode)
                InitializeNavigation();
            ribbonControl.Merge += ribbonControl_Merge;
            ribbonControl.UnMerge += ribbonControl_UnMerge;
        }

        private void ribbonControl_UnMerge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e) {
            ribbonControl.SelectedPage = e.MergeOwner.SelectedPage;
            ribbonControl.StatusBar.UnMergeStatusBar();
        }

        void ribbonControl_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e) {
            ribbonControl.SelectedPage = e.MergedChild.SelectedPage;
            ribbonControl.StatusBar.MergeStatusBar(e.MergedChild.StatusBar);
        }
        void InitializeNavigation() {
			DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = DevExpress.XtraEditors.ScrollUIMode.Touch;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013 Light Gray");	

            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame));
            DevExpress.Utils.MVVM.MVVMContext.RegisterFlyoutDialogService();
            // We want to use buttons in Ribbon to show the specific modules
            var fluentAPI = mvvmContext.OfType<gtscoliar.ViewModels.gtstgViewModel>();
			            fluentAPI.BindCommand(navigationBarItemanne_scoliarCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
			fluentAPI.BindCommand(barButtonItemanne_scoliarCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
			            fluentAPI.BindCommand(navigationBarItemevaluerCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
			fluentAPI.BindCommand(barButtonItemevaluerCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
			            fluentAPI.BindCommand(navigationBarItemmode_de_formationCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
			fluentAPI.BindCommand(barButtonItemmode_de_formationCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
			            fluentAPI.BindCommand(navigationBarItemmoduleCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
			fluentAPI.BindCommand(barButtonItemmoduleCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
			            fluentAPI.BindCommand(navigationBarItemoptionCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
			fluentAPI.BindCommand(barButtonItemoptionCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
			            fluentAPI.BindCommand(navigationBarItempromoCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
			fluentAPI.BindCommand(barButtonItempromoCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
			            fluentAPI.BindCommand(navigationBarItemsectionCollectionView, (x, m) => x.Show(m), x => x.Modules[6]);
			fluentAPI.BindCommand(barButtonItemsectionCollectionView, (x, m) => x.Show(m), x => x.Modules[6]);
			            fluentAPI.BindCommand(navigationBarItemsemasetreCollectionView, (x, m) => x.Show(m), x => x.Modules[7]);
			fluentAPI.BindCommand(barButtonItemsemasetreCollectionView, (x, m) => x.Show(m), x => x.Modules[7]);
			            fluentAPI.BindCommand(navigationBarItemSpecialitéCollectionView, (x, m) => x.Show(m), x => x.Modules[8]);
			fluentAPI.BindCommand(barButtonItemSpecialitéCollectionView, (x, m) => x.Show(m), x => x.Modules[8]);
			            fluentAPI.BindCommand(navigationBarItemstgCollectionView, (x, m) => x.Show(m), x => x.Modules[9]);
			fluentAPI.BindCommand(barButtonItemstgCollectionView, (x, m) => x.Show(m), x => x.Modules[9]);
			            fluentAPI.BindCommand(navigationBarItemsysdiagramCollectionView, (x, m) => x.Show(m), x => x.Modules[10]);
			fluentAPI.BindCommand(barButtonItemsysdiagramCollectionView, (x, m) => x.Show(m), x => x.Modules[10]);
						            // We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
        }
    }
}
