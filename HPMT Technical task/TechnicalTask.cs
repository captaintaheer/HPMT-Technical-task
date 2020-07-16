using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace HPMT_Technical_task
{
    public partial class TechnicalTask : Form
    {
        bool isMenu1PanelOpen = false;
        bool isMenu2PanelOpen = false;
        bool isMenu3PanelOpen = false;
        IEnumerable<Records> records = new List<Records>();
        public TechnicalTask()
        {
            InitializeComponent();

           dataGridView1.DataSource = records;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Settings_btn(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Settings ES = new Edit_Settings();
            ES.ShowDialog();
        }

        private void Edit_btn(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Records_Box(object sender, EventArgs e)
        {

        }

        private void Record1_Click(object sender, EventArgs e)
        {
           DataAccess db = new DataAccess();
           records = db.GetRecords1();
           dataGridView1.DataSource = records;
        }
        private void Record2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            records = db.GetRecords2();
            dataGridView1.DataSource = records;
        }

        private void Record3_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            records = db.GetRecords3();
            dataGridView1.DataSource = records;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    DataAccess db = new DataAccess();
                    records = db.DeleteRecords();
                    dataGridView1.DataSource = records;
                }


            }

        }
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void Job1_lbl_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMenu1PanelOpen)
            {
                panelMenu1.Height -= 54;
                if (panelMenu1.Height == 0)
                {
                    timer1.Stop();
                    isMenu1PanelOpen = false;
                }
            }
            else if (!isMenu1PanelOpen) {
                panelMenu1.Height += 54;
                if (panelMenu1.Height == 54)
                {
                    timer1.Stop();
                    isMenu1PanelOpen = true;
                }
            }
        }

        private void Menu2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isMenu2PanelOpen)
            {
                panelMenu2.Height -= 54;
                if (panelMenu2.Height == 0)
                {
                    timer2.Stop();
                    isMenu2PanelOpen = false;
                }
            }
            else if (!isMenu2PanelOpen)
            {
                panelMenu2.Height += 54;
                if (panelMenu2.Height == 54)
                {
                    timer2.Stop();
                    isMenu2PanelOpen = true;
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isMenu3PanelOpen)
            {
                panelMenu3.Height -= 54;
                if (panelMenu3.Height == 0)
                {
                    timer3.Stop();
                    isMenu3PanelOpen = false;
                }
            }
            else if (!isMenu3PanelOpen)
            {
                panelMenu3.Height += 54;
                if (panelMenu3.Height == 54)
                {
                    timer3.Stop();
                    isMenu3PanelOpen = true;
                }
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
