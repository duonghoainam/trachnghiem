using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Newtonsoft.Json;

namespace trachnghiemTF
{
    public partial class Form1 : Form
    {
        public List<EnViDTO> favor;
        private int counter = 10;
        
        int number, socau=3, socaudung = 0;
        
        EnViDTO key;
        List<EnViDTO> listTraLoi = new List<EnViDTO>();
        List<EnViDTO> listCauHoi = new List<EnViDTO>();
        public Form1()
        {
            InitializeComponent();
            favor = LoadSavedFavoriteWord();

            taotrachnghiem();
        }
        public void taotrachnghiem()
        {
            counter = 10;
            listTraLoi.Clear();
            var rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    number = rand.Next(0, favor.Count);
                } while (listTraLoi.Contains(favor[number]) || listCauHoi.Contains(favor[number])); //4 cau tra loi bi trung thi tiep tuc random i tang den khi du 4 cau
                listTraLoi.Add(favor[number]);

                if (i == 0) button1.Text = listTraLoi[i].VietNamese;
                if (i == 1) button2.Text = listTraLoi[i].VietNamese;
                if (i == 2) button3.Text = listTraLoi[i].VietNamese;
                if (i == 3) button4.Text = listTraLoi[i].VietNamese;
            }

            key = listTraLoi[rand.Next(0, 4)];
            label1.Text = key.English.ToString();
            listCauHoi.Add(key);

            //timer1.Start();
            label3.Text = counter.ToString();
        }
        public List<EnViDTO> LoadSavedFavoriteWord()
        {
            using (StreamReader r = new StreamReader(@".\favorite.json"))
            {
                string json = r.ReadToEnd();
                List<EnViDTO> items = JsonConvert.DeserializeObject<List<EnViDTO>>(json);
                return items;
            }
        }
        public void ketthuc()
        {
            //timer1.Stop();
            MessageBox.Show("Điểm của bạn là: " + socaudung.ToString());
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            label3.Text = counter.ToString();
            if (counter == 0)
            {
                taotrachnghiem();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key.VietNamese == button1.Text)
            {
                socaudung++;
                label2.Text = socaudung.ToString();
            }
            if (socau-- > 1) taotrachnghiem();
            else ketthuc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key.VietNamese == button2.Text)
            {
                socaudung++;
                label2.Text = socaudung.ToString();
            }
            if (socau-- > 1) taotrachnghiem();
            else ketthuc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key.VietNamese == button3.Text)
            {
                socaudung++;
                label2.Text = socaudung.ToString();
            }
            if (socau-- > 1) taotrachnghiem();
            else ketthuc();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (key.VietNamese == button4.Text)
            {
                socaudung++;
                label2.Text = socaudung.ToString();
            }
            if (socau-- > 1) taotrachnghiem();
            else ketthuc();
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_thulai_Click(object sender, EventArgs e)
        {
            socaudung = 0;
            socau = 3;
            label2.Text = "0";
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
