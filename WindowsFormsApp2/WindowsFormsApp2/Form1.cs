using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //LoadComboBox();
        }
        //public void LoadComboBox()
        //{
        //    //string host = "http://localhost/ThoiTietTrongNgay/ThongTinThoiTiet";
        //    //HttpWebRequest req = HttpWebRequest.CreateHttp(host);
        //    //WebResponse response = req.GetResponse();
        //    //DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Category[]));
        //    //object data = json.ReadObject(response.GetResponseStream());
        //    //Category[] arr1 = data as Category[];
        //    //cboDanhMuc.DataSource = arr1;
        //    //cboDanhMuc.ValueMember = "MaDanhMuc";
        //    //cboDanhMuc.DisplayMember = "TenDanhMuc";

        //}
        private void HienThi()
        {
            // Ko có datetime
            //string link = "http://localhost/ThoiTietTrongNgay/ThongTinThoiTiet";
            //HttpWebRequest request = WebRequest.CreateHttp(link);
            //WebResponse response = request.GetResponse();
            //DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DuBaoThoiTiet[]));
            //object data = js.ReadObject(response.GetResponseStream());
            //DuBaoThoiTiet[] arr = data as DuBaoThoiTiet[];
            //dataGridView1.DataSource = arr;

            string host = "http://localhost/ThoiTietTrongNgay/ThongTinThoiTiet";
            HttpWebRequest req = HttpWebRequest.CreateHttp(host);
            WebResponse response = req.GetResponse();
            DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings
            {
                DateTimeFormat = new DateTimeFormat("yyyy-MM-ddTHH:mm:ss")
            };
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(DuBaoThoiTiet[]), settings);
            object arr = json.ReadObject(response.GetResponseStream());
            DuBaoThoiTiet[] data = arr as DuBaoThoiTiet[];
            dataGridView1.DataSource = data;
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string host = "http://localhost/ThoiTietTrongNgay/ThongTinThoiTiet";
            HttpWebRequest req = HttpWebRequest.CreateHttp(host);
            WebResponse response = req.GetResponse();
            DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings
            {
                DateTimeFormat = new DateTimeFormat("yyyy-MM-ddTHH:mm:ss")
            };
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(DuBaoThoiTiet[]), settings);
            object arr = json.ReadObject(response.GetResponseStream());
            DuBaoThoiTiet[] data = arr as DuBaoThoiTiet[];
            dataGridView1.DataSource = data;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string pa = string.Format("?gio={0}&maKhuVuc={1}&nhietDo={2}&doAm={3}",
                 txtGio.Text, txtMaKhuVuc.Text,  txtNhietDo.Text, txtDoAm.Text);
            string host = "http://localhost/ThoiTietTrongNgay/Them" + pa;

            HttpWebRequest req = HttpWebRequest.CreateHttp(host);
            req.Method = "POST";
            req.GetRequestStream();
            WebResponse response = req.GetResponse();

            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(bool));
            object arr = json.ReadObject(response.GetResponseStream());
            bool check = (bool)arr;
            if (check)
            {
                HienThi();
                MessageBox.Show("Tạo thành công");
            }
            else
            {
                MessageBox.Show("Tạo thất bại");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            int index = e.RowIndex;
            txtGio.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtMaKhuVuc.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtNhietDo.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtDoAm.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string pa = string.Format("?gio={0}&maKhuVuc={1}",
                txtGio.Text, txtMaKhuVuc.Text);
            string host = "http://localhost/ThoiTietTrongNgay/Xoa" + pa;

            HttpWebRequest req = HttpWebRequest.CreateHttp(host);
            req.Method = "DELETE";
            WebResponse response = req.GetResponse();

            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(bool));
            object arr = json.ReadObject(response.GetResponseStream());
            bool check = (bool)arr;
            if (check)
            {
                HienThi();
                MessageBox.Show("Xoá thành công");
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string pa = string.Format("?gio={0}&maKhuVuc={1}&nhietDo={2}&doAm={3}",
                txtGio.Text, txtMaKhuVuc.Text, txtNhietDo.Text, txtDoAm.Text);

            // Đảm bảo rằng phương thức API để sửa là PUT hoặc PATCH
            string host = "http://localhost/ThoiTietTrongNgay/Sua" + pa;  // Đổi thành đường dẫn phù hợp với API sửa

            HttpWebRequest req = HttpWebRequest.CreateHttp(host);
            req.Method = "PUT";  // Hoặc "PATCH" nếu sử dụng phương thức PATCH
            WebResponse response = req.GetResponse();

            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(bool));
            object arr = json.ReadObject(response.GetResponseStream());
            bool check = (bool)arr;

            if (check)
            {
                HienThi();
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string gio = txtGio.Text;
            string maKhuVuc = txtMaKhuVuc.Text;

            string pa = string.Format("?gio={0}&maKhuVuc={1}", gio, maKhuVuc);
            string host = "http://localhost/ThoiTietTrongNgay/TimKiem" + pa;

            HttpWebRequest req = HttpWebRequest.CreateHttp(host);
            WebResponse response = req.GetResponse();

            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(DuBaoThoiTiet[]));
            object arr = json.ReadObject(response.GetResponseStream());
            DuBaoThoiTiet[] data = arr as DuBaoThoiTiet[];
            dataGridView1.DataSource = data;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
