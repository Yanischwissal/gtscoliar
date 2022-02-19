using gtscoliar.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace gtscoliar.formes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.options'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.optionsTableAdapter.Fill(this.dataSet1.options);

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }


        private void comboBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
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

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

            List<Database.section> sections = shared.db.sections.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nom");
            var en = int.Parse(comboBox2.SelectedValue.ToString());
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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Database.gtstg dd = new Database.gtstg();
            DataTable dt = new DataTable();
            dt.Columns.Add("numrostg");

            dt.Columns.Add("nom");
            dt.Columns.Add("control1");
            dt.Columns.Add("control2", typeof(float));
            dt.Columns.Add("exm");
            dt.Columns.Add("rtp");
            int sec = int.Parse(comboBox3.SelectedValue.ToString());
            var idsem = comboBox4.SelectedValue.ToString();
            var idmod = int.Parse(comboBox5.SelectedValue.ToString());
            var reqe = from evalue in shared.db.evaluers
                       join stg in shared.db.stgs on evalue.stagiair equals stg.numstg
                       where stg.numrosection == sec && evalue.module == idmod && evalue.semastre == idsem && evalue.anne_scoliar == 1

                       select new { numrostg = stg.numstg, nom = stg.nom, control1 = evalue.controle1, control2 = evalue.controle2, exm = evalue.exm, rtp = evalue.ratrapag };

            if (int.Parse(reqe.Count().ToString()) > 0)
            {
                foreach (var r in reqe)
                {
                    dt.Rows.Add(r.numrostg, r.nom, r.control1, r.control2, r.exm, r.exm);
                }

                dataGridView1.DataSource = dt;   

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = false;




            }
            else
            {


                foreach (Database.stg section in shared.db.stgs)
                {
                    if (section.numrosection == sec)
                    {
                        dt.Rows.Add(section.numstg, (section.nom + " " + section.prenom));
                    }
                }






                dataGridView1.DataSource = dt;

            }
            var req = from stg in shared.db.stgs.Where(w => w.numrosection == sec)
                      select new { stg.numstg, stg.nom };
            DataTable de = new DataTable();
            de.Columns.Add("id");
            de.Columns.Add("nom");
            if (req.Count() > 0)
            {
                foreach (var reqee in req)
                {
                    de.Rows.Add(reqee.nom, reqee.numstg);
                }
            }

            dataGridView2.DataSource = de;




            //foreach (Database.evaluer evaluer1 in shared.db.evaluers)

            //    if ()
            //        {


            //        }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string idet = row.Cells["numrostg"].Value.ToString();


                    Database.evaluer ev = new Database.evaluer();


                    ev.anne_scoliar = 1;
                    ev.module = int.Parse(comboBox5.SelectedValue.ToString());
                    ev.stagiair = row.Cells["numrostg"].Value.ToString();
                    ev.semastre = comboBox4.SelectedValue.ToString();
                    ev.controle1 = float.Parse(row.Cells["control1"].Value.ToString());
                    ev.controle2 = float.Parse(row.Cells["control2"].Value.ToString());
                    ev.exm = float.Parse(row.Cells["exm"].Value.ToString());
                    ev.ratrapag = float.Parse(row.Cells["rtp"].Value.ToString());
                    shared.db.evaluers.Add(ev);
                }
                try
                {

                    shared.db.SaveChanges();
                    MessageBox.Show("is sakisaflite");
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
           
           
                int sec = int.Parse(comboBox3.SelectedValue.ToString());
                var idsem = comboBox4.SelectedValue.ToString();
                var idmod = int.Parse(comboBox5.SelectedValue.ToString());

                var qre = from eva in shared.db.evaluers
                          join stg in shared.db.stgs on eva.stagiair equals stg.numstg
                          join mod in shared.db.modules on eva.module equals mod.codemodul
                          where stg.numrosection == sec && eva.semastre == idsem
                          select new
                          {
                              numrostg = stg.numstg,
                              nom_et_prenom = (stg.nom + " " + stg.prenom),
                              moyne = ((eva.controle1 + eva.controle2 + eva.exm + eva.ratrapag) / 5),
                              module = mod.module1
                          };
                DataTable dt = new DataTable();
            foreach (var qres in qre)
            {
                if (dt.Columns.Count <= 0)
                {
                    dt.Columns.Add("numro");
                    dt.Columns.Add("nom et prenom");
                    dt.Columns.Add(qres.module);

                } else
                {
                    int x = 0;
                   foreach(DataColumn dc in dt.Columns)
                    {
                        if (dc.ColumnName == qres.module)
                        {
                            x += 2;
                            
                        }

                    }
                    if (x == 0)
                    {
                        dt.Columns.Add(qres.module);
                    }
                }
            }

            foreach (var qres in qre)
            {
                var r = dt.Rows.Count;
                foreach (DataRow dro in dt.Rows)
                {
                    if (dro[0].ToString() == qres.numrostg.ToString())
                    {

                        dro[qres.module] = qres.moyne;
                        r += 1;


                    }
                    else
                    {



                    }


                }
                if (dt.Rows.Count <= 0 || r == dt.Rows.Count)
                {
                    DataRow dro;
                    dro = dt.NewRow();

                    dro[0] = qres.numrostg;
                    dro[1] = qres.nom_et_prenom;
                    dro[qres.module.ToString()] = qres.moyne;
                    dt.Rows.Add(dro);
                }


                //foreach (DataRow dr in dt.Rows)
                //{
                //    if (dr[0].ToString() == qres.numrostg)
                //    {
                //        dr[qres.module] = qres.moyne;
                //    }
                //    else
                //    {
                //        dt.Rows.Add(qres.numrostg, qres.nom_et_prenom);
                //        foreach (DataRow db in dt.Rows)
                //            if (db["numro"].ToString() == qres.numrostg.ToString())
                //            {





                //                db[qres.module] = qres.moyne;

                //            }

                //    }
                //}

            }
                
                   
                


                dataGridView2.DataSource = dt;

            

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
