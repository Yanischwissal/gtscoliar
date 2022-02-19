using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtscoliar.formes.splashsakiren
{
    public partial class splashsacrine : Form
    {
        public splashsacrine()
        {
            InitializeComponent();
            load();
        }

        private void splashsacrine_Load(object sender, EventArgs e)
        {

        }
        public void load()
        {
            try
            {
                classes.shared.db.anne_scoliar.Load();
                progressBarControl1.Position += 10;
                labelControl2.Text = "anne scolaire";
                classes.shared.db.evaluers.Load();
                progressBarControl1.Position += 10;
                labelControl2.Text = "evalustion";
                classes.shared.db.mode_de_formations.Load();
                progressBarControl1.Position += 10;
                labelControl2.Text = "mode de fomation";
                classes.shared.db.modules.Load();
                progressBarControl1.Position += 10;
                labelControl2.Text = "emodules";
                classes.shared.db.options.Load();
                progressBarControl1.Position += 10;
                labelControl2.Text = "option";
                classes.shared.db.promoes.Load();
                progressBarControl1.Position += 10;
                labelControl2.Text = "promo";
                classes.shared.db.sections.Load();
                progressBarControl1.Position += 10;
                labelControl2.Text = "secation";
                classes.shared.db.semasetres.Load();
                progressBarControl1.Position += 10;
                labelControl2.Text = "semasetres";
                classes.shared.db.Specialité.Load();
                progressBarControl1.Position += 10;
                labelControl2.Text = "spesalite";
                classes.shared.db.stgs.Load();
                progressBarControl1.Position += 10;
                labelControl2.Text = "stagiar";





            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
