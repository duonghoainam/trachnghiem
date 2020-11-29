using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace trachnghiemTF
{
    public partial class excel_form : Form
    {
        private int counter;
        int number, socau, socaudung = 0;
        private DataTable dt = new DataTable();
        DataRow key;
        List<DataRow> listTraLoi = new List<DataRow>();
        List<DataRow> listCauHoi = new List<DataRow>();

        public excel_form()  // add title
        {
            InitializeComponent();
            groupBox1.Hide(); textBox1.Hide();
            string data_path = @"D:\verb\New Folder";
            foreach (var child in Directory.GetFiles(data_path))
            {
                string name = Path.GetFileName(child);
                cbb_choose.Items.Add(name.Substring(0, name.Length - 4));
            }
        }
        private void cbb_choose_SelectedValueChanged(object sender, EventArgs e) // add sheet
        {
            cbb_sheet.Items.Clear();

            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\verb\\New Folder\\" + cbb_choose.SelectedItem.ToString() + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);

            conn.Open();
            DataTable dt_sheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            String[] excelSheets = new String[dt_sheet.Rows.Count];
            int i = 0;

            // Add the sheet name to the string array.
            foreach (DataRow row in dt_sheet.Rows)
            {
                string sheetname = row["TABLE_NAME"].ToString();
                if (!sheetname.Contains("$'ExternalData") && !sheetname.Contains("'$ExternalData") && !sheetname.Contains("bang_cac_"))
                {
                    excelSheets[i] = sheetname.Substring(1, sheetname.Length - 3);
                    cbb_sheet.Items.Add(excelSheets[i]);
                    i++;
                }
            }

        }

        private void cbb_sheet_SelectedValueChanged(object sender, EventArgs e)
        {
            listCauHoi.Clear();
            dt.Clear();

            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\verb\\New Folder\\" + cbb_choose.SelectedItem.ToString() + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + cbb_sheet.SelectedItem.ToString() + "$]", conn);
            

            myDataAdapter.Fill(dt);


            groupBox1.Show();
            label1.Text = "(smaller than " + dt.Rows.Count.ToString() + ")";
        }

        public bool checkanswer(DataRow answer4)
        {
            if (listTraLoi.Count < 3) return true;
            for (int i=0;i<listTraLoi.Count;i++)
            {
                if (!listCauHoi.Contains(listTraLoi[i])) return true;
            }
            if (listCauHoi.Contains(answer4)) return false;
            else return true;
        }
        
        public void taotrachnghiem()
        {
            counter = Int32.Parse(tb_thoigianlam.Text);
            listTraLoi.Clear();
            var rand = new Random();

            for (int i = 0; i < 4; i++)
            {
                do
                {
                    number = rand.Next(0, dt.Rows.Count);
                    while (i == 3 && !checkanswer(dt.Rows[number])) number = rand.Next(0, dt.Rows.Count);
                    if (listTraLoi.Count == 0)
                    {
                        listTraLoi.Add(dt.Rows[number]);
                        break;
                    }
                } while (listTraLoi.Contains(dt.Rows[number])); //4 cau tra loi bi trung thi tiep tuc random i tang den khi du 4 cau
                if (i > 0) listTraLoi.Add(dt.Rows[number]);

            }

            button1.Text = listTraLoi[0][2].ToString();
            button2.Text = listTraLoi[1][2].ToString();
            button3.Text = listTraLoi[2][2].ToString();
            button4.Text = listTraLoi[3][2].ToString();

            do key = listTraLoi[rand.Next(0, 4)]; while (listCauHoi.Contains(key));
            lb_cauhoi.Text = key[0].ToString();
            listCauHoi.Add(key);     textBox1.Text += key[0].ToString() + "--";

            //timer1.Start();
            lb_thoigian.Text = counter.ToString();
        }

        public void ketthuc()
        {
            //timer1.Stop();
            MessageBox.Show("Điểm của bạn là: " + socaudung.ToString());
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            listCauHoi.Clear();
            listTraLoi.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key[2] == button1.Text)
            {
                socaudung++;
                lb_socaudung.Text = socaudung.ToString();
            }
            if (socau-- > 1) taotrachnghiem();
            else ketthuc();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (key[2] == button2.Text)
            {
                socaudung++;
                lb_socaudung.Text = socaudung.ToString();
            }
            if (socau-- > 1) taotrachnghiem();
            else ketthuc();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (key[2] == button3.Text)
            {
                socaudung++;
                lb_socaudung.Text = socaudung.ToString();
            }
            if (socau-- > 1) taotrachnghiem();
            else ketthuc();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (key[2] == button4.Text)
            {
                socaudung++;
                lb_socaudung.Text = socaudung.ToString();
            }
            if (socau-- > 1) taotrachnghiem();
            else ketthuc();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            counter--;
            lb_thoigian.Text = counter.ToString();
            if (counter == 0)
            {
                taotrachnghiem();
                if (--socau == 0) ketthuc();
            }
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            socau = Int32.Parse(tb_soluongcau.Text);
            counter = Int32.Parse(tb_thoigianlam.Text);
            groupBox1.Hide(); textBox1.Show();
            taotrachnghiem();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_thulai_Click(object sender, EventArgs e)
        {
            socaudung = 0;
            socau = Int32.Parse(tb_soluongcau.Text);
            lb_socaudung.Text = "0";
            listCauHoi.Clear();
            listTraLoi.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            taotrachnghiem();
        }
    }
}