using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPMT_Technical_task
{
    public partial class Edit_Settings : Form
    {
        public Edit_Settings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TechnicalTask TS = new TechnicalTask();
            TS.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string connectionString = string.Format("Server={0};Database={1};User Id={2};Password={3}", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            try {

                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSettings setting = new AppSettings();
                    setting.SaveConnectionString("Demo", connectionString);
                    MessageBox.Show("Your connection is saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch(Exception ex){

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
            TechnicalTask TS = new TechnicalTask();
            TS.ShowDialog();
        }
    }
}
