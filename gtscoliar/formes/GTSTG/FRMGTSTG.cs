using gtscoliar.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtscoliar.formes.GTSTG
{
    public partial class FRMGTSTG : DevExpress.XtraEditors.XtraForm
    {
        public FRMGTSTG()
        {
            InitializeComponent();
            load();
            
        }
        public void load()
        {
          

        
            

        }

        private void FRMGTSTG_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gtmgDataSet.evaluer'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.evaluerTableAdapter.Fill(this.gtmgDataSet.evaluer);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
         
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void fillBy_numstgToolStripButton_Click(object sender, EventArgs e)
        {
         

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stgCollectionView1_Load(object sender, EventArgs e)
        {

        }

        private void gtstgView1_Load(object sender, EventArgs e)
        {

        }
    }
}
