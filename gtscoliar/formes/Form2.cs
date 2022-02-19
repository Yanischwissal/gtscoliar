using gtscoliar.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gtscoliar.formes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            List<Database.option> codeoption = shared.db.options.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nom");
            foreach (Database.option option in codeoption)
            {
                dt.Rows.Add(option.codeopstion, option.options);
            }
            comboBox1.ValueMember = dt.Columns[0].ColumnName;
            comboBox1.DisplayMember = dt.Columns[1].ColumnName;
            comboBox1.DataSource = dt;

            List<Database.semasetre> semasetres = shared.db.semasetres.ToList();
            DataTable da = new DataTable();
            da.Columns.Add("id");
            da.Columns.Add("nom");
            foreach (Database.semasetre semasetre in semasetres)
            {
                da.Rows.Add(semasetre.somestre, semasetre.somestre);
            }
            comboBox4.ValueMember = da.Columns[0].ColumnName;
            comboBox4.DisplayMember = da.Columns[1].ColumnName;
            comboBox4.DataSource = da;

            List<Database.module> modules = shared.db.modules.ToList();
            DataTable dg = new DataTable();
            dg.Columns.Add("id");
            dg.Columns.Add("nom");

            comboBox3.DataSource = null;
            comboBox3.Items.Clear();
            foreach (Database.module module in modules)
            {

                dg.Rows.Add(module.codemodul, module.module1);

            }
            comboBox5.ValueMember = dg.Columns[0].ColumnName;
            comboBox5.DisplayMember = dg.Columns[1].ColumnName;
            comboBox5.DataSource = dg;
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Database.section> sections = shared.db.sections.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nom");
            int en = int.Parse(comboBox2.SelectedValue.ToString());
            comboBox3.DataSource = null;
            comboBox3.Items.Clear();
            foreach (Database.section section in sections)
            {
                if (section.promo == en)
                {
                    dt.Rows.Add(section.numrosction, (section.modeformation.ToString() + section.options.ToString() + section.promo.ToString() + section.nomsection));
                }
            }
            comboBox3.ValueMember = dt.Columns[0].ColumnName;
            comboBox3.DisplayMember = dt.Columns[1].ColumnName;
            comboBox3.DataSource = dt;
            List<Database.section> sectio = shared.db.sections.ToList();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Database.promo> promos = shared.db.promoes.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nom");
            foreach (Database.promo promo in promos)
            {

                dt.Rows.Add(promo.Code_Promo, (promo.modeformation.ToString() + promo.opption.ToString() + promo.Code_Promo.ToString()));

            }
            comboBox2.ValueMember = dt.Columns[0].ColumnName;
            comboBox2.DisplayMember = dt.Columns[1].ColumnName;
            comboBox2.DataSource = dt;

        }
        DataTable tbl;
        public void table()
        {
            int sec = int.Parse(comboBox3.SelectedValue.ToString());
            var idsem = comboBox4.SelectedValue.ToString();
            var idmod = int.Parse(comboBox5.SelectedValue.ToString());

            tbl = new DataTable();
        

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
