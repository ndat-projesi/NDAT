using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDAT
{
    public partial class Form1 : Form
    {
        private List<Uye> uyeler;

        public object Label2 { get; private set; }

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(LoginForm_Load);
            
        }
        
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Üye listesi oluşturma
            uyeler = new List<Uye>
            {
                new Uye(1, "Ahmet", "Yılmaz", "05001112233", "ahmet@gmail.com", DateTime.Now.AddYears(-2), UyeTipi.Normal),
                new DaimiUye(2, "Mehmet", "Kaya", "05004445566", "mehmet@gmail.com", DateTime.Now.AddYears(-1), UyeTipi.Daimi, 10, 5),
                new VIPUye(3, "Ayşe", "Demir", "05007778899", "ayse@gmail.com", DateTime.Now.AddMonths(-6), UyeTipi.VIP, 20, 10),
            };
            

            // Kullanıcı Adı Label
            Label1.AutoSize = false;
            Label1.Size = new System.Drawing.Size(100, 20);
            Label1.Text = "Kullanıcı Adı";

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            Uye uye = uyeler.Find(u => u.Ad.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Soyad.Equals(password, StringComparison.OrdinalIgnoreCase));

            // Basit kullanıcı doğrulama (bu kısmı kendi sisteminize göre değiştirebilirsiniz)
            if (uye != null)
            {
                this.Hide();
                Form3 mainForm = new Form3(uye);
                
                mainForm.Show();
            }
                
            else
            {                                                   
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
