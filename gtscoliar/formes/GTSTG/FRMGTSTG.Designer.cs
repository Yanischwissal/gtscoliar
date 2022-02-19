
namespace gtscoliar.formes.GTSTG
{
    partial class FRMGTSTG
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMGTSTG));
            this.evaluerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gtmgDataSet = new gtscoliar.gtmgDataSet();
            this.evaluerTableAdapter = new gtscoliar.gtmgDataSetTableAdapters.evaluerTableAdapter();
            this.gtstgView1 = new gtscoliar.Views.gtstgView.gtstgView();
            ((System.ComponentModel.ISupportInitialize)(this.evaluerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtmgDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // evaluerBindingSource
            // 
            this.evaluerBindingSource.DataMember = "evaluer";
            this.evaluerBindingSource.DataSource = this.gtmgDataSet;
            // 
            // gtmgDataSet
            // 
            this.gtmgDataSet.DataSetName = "gtmgDataSet";
            this.gtmgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evaluerTableAdapter
            // 
            this.evaluerTableAdapter.ClearBeforeFill = true;
            // 
            // gtstgView1
            // 
            resources.ApplyResources(this.gtstgView1, "gtstgView1");
            this.gtstgView1.Name = "gtstgView1";
            this.gtstgView1.Load += new System.EventHandler(this.gtstgView1_Load);
            // 
            // FRMGTSTG
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gtstgView1);
            this.Name = "FRMGTSTG";
            this.Load += new System.EventHandler(this.FRMGTSTG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evaluerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtmgDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private gtmgDataSet gtmgDataSet;
        private System.Windows.Forms.BindingSource evaluerBindingSource;
        private gtmgDataSetTableAdapters.evaluerTableAdapter evaluerTableAdapter;
        private Views.gtstgView.gtstgView gtstgView1;
    }
}