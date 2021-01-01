using HizliSatis.Connection;
using HizliSatis.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HizliSatis
{
    public partial class DatabaseAyari : DevExpress.XtraEditors.XtraForm
    {
        public DatabaseAyari()
        {
            InitializeComponent();
        }
        SatisEnt db = new SatisEnt();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var connectionString = string.Format("data source={0};initial catalog={1};persist security info=True;user id={2};password={3};MultipleActiveResultSets=True;App=EntityFramework", txtSQL.Text, txtDatabase.Text, txtUser.Text, txtPass.Text);
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.Save("MikroEnt", connectionString);
                    setting.Save("Model1", connectionString);

                    // setting.Save("HizliSatis.Properties.Settings.StoklarDataset", connectionString);
                    MessageBox.Show("Güncelleme İşlemi Başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Bağlantı Hatası");
            }
        }
        private void Connection()
        {
            var connectionString = string.Format("Data Source={0};Initial Catalog={1};persist security info=True;user id={2};password={3}; MultipleActiveResultSets = True; App = EntityFramework",txtSQL.Text,txtDatabase.Text,txtUser.Text,txtPass.Text);
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    MessageBox.Show("Bağlantı başarılı");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Bağlantı Hatası"+ e.Message );
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Connection();
        }

        private void DatabaseAyari_Load(object sender, EventArgs e)
        {
            var con = System.Configuration.ConfigurationManager.
    ConnectionStrings["MikroEnt"].ConnectionString;
            System.Data.Common.DbConnection connection = new SqlConnection(con);
            var server = connection.DataSource;
            var dbname = connection.Database;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(con);
            string userid = builder.UserID;
            string password = builder.Password;
            txtDatabase.Text = dbname;
            txtPass.Text = password;
            txtUser.Text = userid;
            txtSQL.Text = server;
        }

   
        private void simpleButton3_Click(object sender, EventArgs e)
        { Sifre sf = new Sifre();
            sf.ShowDialog();
            var sifre = Sifre.sifre;
            sifre = Licence.Licence.ToMD5(sifre);
            var sifresorgu = db.Ayarlar.Where(u => u.Sifre == sifre).FirstOrDefault();
            if (sifresorgu != null)
            {
                AyarlarForm af = new AyarlarForm();
                af.ShowDialog();
            }
            else
            {
                MessageBox.Show("Girdiğiniz şifre hatalıdır.Lütfen tekrar deneyiniz!!");
            }
        }
    }
}
