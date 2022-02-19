﻿using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using System.Data.Entity;

namespace gtscoliar.Views.promoView{
    public partial class promoView : XtraUserControl {
        public promoView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
            // This line of code is generated by Data Source Configuration Wizard
            optionsTableAdapter1.Fill(gtmgDataSet1.options);
            // This line of code is generated by Data Source Configuration Wizard
            entityServerModeSource1.QueryableSource = new gtscoliar.Database.gtstg().options;
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            gtscoliar.Database.gtstg dbContext = new gtscoliar.Database.gtstg();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.mode_de_formations.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    modeformationTextEdit.Properties.DataSource = dbContext.mode_de_formations.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<gtscoliar.ViewModels.promoViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                promoViewBindingSource, x => x.Entity, x => x.Update());
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
