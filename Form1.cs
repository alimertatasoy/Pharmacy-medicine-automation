using MySql.Data.MySqlClient;
using System.Data;

namespace ders2503
{
    public partial class Form1 : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server=localhost;uid = root;pwd = ;database=ilac");
        MySqlCommand komut;
        MySqlDataAdapter adator;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            adator = new MySqlDataAdapter("select * from ilaclistesi", baglanti);
            DataTable tablo = new DataTable();
            adator.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdText = "insert into ilaclistesi (ilac_adi,ilac_kodu,stok,resim) values ('" + textBox1.Text + "', '" + textBox2.Text + "', " + int.Parse(textBox3.Text) + ",'" + textBox4.Text + "' )";
            komut = new MySqlCommand(cmdText, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urlresim = textBox4.Text;
            pictureBox1.Load(urlresim);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            pictureBox1.Load(dataGridView1.CurrentRow.Cells[4].Value.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Resim Dosyalar� |*.jpg; *jpeg";
            fd.ShowDialog();
            pictureBox1.ImageLocation = fd.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Se�ili sat�r�n index'ini al�n
            int rowIndex = dataGridView1.CurrentRow.Index;

            // Se�ili sat�r�n stok de�erini bir azalt�n
            int stok = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            stok--;

            // Se�ili sat�r�n stok de�erini g�ncelleyin
            string ilacKodu = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string updateQuery = "UPDATE ilaclistesi SET stok = " + stok + " WHERE ilac_kodu = '" + ilacKodu + "'";
            komut = new MySqlCommand(updateQuery, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            // G�ncellenmi� veriyi DataGridView'e y�kleyin
            listele();

            // Se�ili sat�r� tekrar se�in
            dataGridView1.Rows[rowIndex].Selected = true;
        }

    }
}