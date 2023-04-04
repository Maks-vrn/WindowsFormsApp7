using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        Class1 dataBase = new Class1();
        DataTable tovar = new DataTable();
        int counter;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var reader = new SqlCommand("Select * from products_b_import", dataBase.getConnection()).ExecuteReader();
            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;
            GetData(counter);

        }
        public void GetData(int counter)
        {
            try
            {
                label21.Text = tovar.Rows[counter][0].ToString(); //Наименование
                label1.Text = tovar.Rows[counter][4].ToString(); //Тип товара
                label22.Text = tovar.Rows[counter][1].ToString(); //Артикул
                label100.Text = tovar.Rows[counter][2].ToString(); //Стоимость
                label80.Text = "Материалы" + tovar.Rows[counter][4].ToString(); //Материалы
                pictureBox1.Image = Image.FromFile(tovar.Rows[counter][3].ToString());

                label42.Text = tovar.Rows[counter + 1][0].ToString(); //Наименование
                label23.Text = tovar.Rows[counter + 1][4].ToString(); //Тип товара
                label61.Text = tovar.Rows[counter + 1][1].ToString(); //Артикул
                label101.Text = tovar.Rows[counter + 1][2].ToString(); //Стоимость
                label81.Text = "Материалы" + tovar.Rows[counter + 1][4].ToString(); //Материалы
                pictureBox2.Image = Image.FromFile(tovar.Rows[counter + 1][3].ToString());

                label43.Text = tovar.Rows[counter + 2][0].ToString(); //Наименование
                label24.Text = tovar.Rows[counter + 2][4].ToString(); //Тип товара
                label62.Text = tovar.Rows[counter + 2][1].ToString(); //Артикул
                label102.Text = tovar.Rows[counter + 2][2].ToString(); //Стоимость
                label82.Text = "Материалы" + tovar.Rows[counter + 2][4].ToString(); //Материалы
                pictureBox8.Image = Image.FromFile(tovar.Rows[counter + 2][3].ToString());

                label44.Text = tovar.Rows[counter + 3][0].ToString(); //Наименование
                label25.Text = tovar.Rows[counter + 3][4].ToString(); //Тип товара
                label63.Text = tovar.Rows[counter + 3][1].ToString(); //Артикул
                label103.Text = tovar.Rows[counter + 3][2].ToString(); //Стоимость
                label83.Text = "Материалы" + tovar.Rows[counter + 3][4].ToString(); //Материалы
                pictureBox7.Image = Image.FromFile(tovar.Rows[counter + 3][3].ToString());

                label45.Text = tovar.Rows[counter + 4][0].ToString(); //Наименование
                label26.Text = tovar.Rows[counter + 4][4].ToString(); //Тип товара
                label64.Text = tovar.Rows[counter + 4][1].ToString(); //Артикул
                label104.Text = tovar.Rows[counter + 4][2].ToString(); //Стоимость
                label84.Text = "Материалы" + tovar.Rows[counter + 4][4].ToString(); //Материалы
                pictureBox6.Image = Image.FromFile(tovar.Rows[counter + 4][3].ToString());

                label46.Text = tovar.Rows[counter + 5][0].ToString(); //Наименование
                label27.Text = tovar.Rows[counter + 5][4].ToString(); //Тип товара
                label65.Text = tovar.Rows[counter + 5][1].ToString(); //Артикул
                label105.Text = tovar.Rows[counter + 5][2].ToString(); //Стоимость
                label85.Text = "Материалы" + tovar.Rows[counter + 5][4].ToString(); //Материалы
                pictureBox5.Image = Image.FromFile(tovar.Rows[counter + 5][3].ToString());

                label47.Text = tovar.Rows[counter + 6][0].ToString(); //Наименование
                label28.Text = tovar.Rows[counter + 6][4].ToString(); //Тип товара
                label66.Text = tovar.Rows[counter + 6][1].ToString(); //Артикул
                label106.Text = tovar.Rows[counter + 6][2].ToString(); //Стоимость
                label86.Text = "Материалы" + tovar.Rows[counter + 6][4].ToString(); //Материалы
                pictureBox4.Image = Image.FromFile(tovar.Rows[counter + 6][3].ToString());

                label48.Text = tovar.Rows[counter + 7][0].ToString(); //Наименование
                label29.Text = tovar.Rows[counter + 7][4].ToString(); //Тип товара
                label67.Text = tovar.Rows[counter + 7][1].ToString(); //Артикул
                label107.Text = tovar.Rows[counter + 7][2].ToString(); //Стоимость
                label87.Text = "Материалы" + tovar.Rows[counter + 7][4].ToString(); //Материалы
                pictureBox3.Image = Image.FromFile(tovar.Rows[counter + 7][3].ToString());

                label49.Text = tovar.Rows[counter + 8][0].ToString(); //Наименование
                label30.Text = tovar.Rows[counter + 8][4].ToString(); //Тип товара
                label68.Text = tovar.Rows[counter + 8][1].ToString(); //Артикул
                label108.Text = tovar.Rows[counter + 8][2].ToString(); //Стоимость
                label88.Text = "Материалы" + tovar.Rows[counter + 8][4].ToString(); //Материалы
                pictureBox9.Image = Image.FromFile(tovar.Rows[counter + 8][3].ToString());

                label50.Text = tovar.Rows[counter + 9][0].ToString(); //Наименование
                label31.Text = tovar.Rows[counter + 9][4].ToString(); //Тип товара
                label69.Text = tovar.Rows[counter + 9][1].ToString(); //Артикул
                label109.Text = tovar.Rows[counter + 9][2].ToString(); //Стоимость
                label89.Text = "Материалы" + tovar.Rows[counter + 9][4].ToString(); //Материалы
                pictureBox10.Image = Image.FromFile(tovar.Rows[counter + 9][3].ToString());

                label51.Text = tovar.Rows[counter + 10][0].ToString(); //Наименование
                label32.Text = tovar.Rows[counter + 10][4].ToString(); //Тип товара
                label70.Text = tovar.Rows[counter + 10][1].ToString(); //Артикул
                label110.Text = tovar.Rows[counter + 10][2].ToString(); //Стоимость
                label90.Text = "Материалы" + tovar.Rows[counter + 10][4].ToString(); //Материалы
                pictureBox20.Image = Image.FromFile(tovar.Rows[counter + 10][3].ToString());

                label52.Text = tovar.Rows[counter + 11][0].ToString(); //Наименование
                label33.Text = tovar.Rows[counter + 11][4].ToString(); //Тип товара
                label71.Text = tovar.Rows[counter + 11][1].ToString(); //Артикул
                label111.Text = tovar.Rows[counter + 11][2].ToString(); //Стоимость
                label91.Text = "Материалы" + tovar.Rows[counter + 11][4].ToString(); //Материалы
                pictureBox19.Image = Image.FromFile(tovar.Rows[counter + 11][3].ToString());

                label53.Text = tovar.Rows[counter + 12][0].ToString(); //Наименование
                label34.Text = tovar.Rows[counter + 12][4].ToString(); //Тип товара
                label72.Text = tovar.Rows[counter + 12][1].ToString(); //Артикул
                label112.Text = tovar.Rows[counter + 12][2].ToString(); //Стоимость
                label92.Text = "Материалы" + tovar.Rows[counter + 12][4].ToString(); //Материалы
                pictureBox18.Image = Image.FromFile(tovar.Rows[counter + 12][3].ToString());

                label54.Text = tovar.Rows[counter + 13][0].ToString(); //Наименование
                label35.Text = tovar.Rows[counter + 13][4].ToString(); //Тип товара
                label73.Text = tovar.Rows[counter + 13][1].ToString(); //Артикул
                label113.Text = tovar.Rows[counter + 13][2].ToString(); //Стоимость
                label93.Text = "Материалы" + tovar.Rows[counter + 13][4].ToString(); //Материалы
                pictureBox17.Image = Image.FromFile(tovar.Rows[counter + 13][3].ToString());

                label55.Text = tovar.Rows[counter + 14][0].ToString(); //Наименование
                label36.Text = tovar.Rows[counter + 14][4].ToString(); //Тип товара
                label74.Text = tovar.Rows[counter + 14][1].ToString(); //Артикул
                label114.Text = tovar.Rows[counter + 14][2].ToString(); //Стоимость
                label94.Text = "Материалы" + tovar.Rows[counter + 14][4].ToString(); //Материалы
                pictureBox12.Image = Image.FromFile(tovar.Rows[counter + 14][3].ToString());

                label56.Text = tovar.Rows[counter + 15][0].ToString(); //Наименование
                label37.Text = tovar.Rows[counter + 15][4].ToString(); //Тип товара
                label75.Text = tovar.Rows[counter + 15][1].ToString(); //Артикул
                label115.Text = tovar.Rows[counter + 15][2].ToString(); //Стоимость
                label95.Text = "Материалы" + tovar.Rows[counter + 15][4].ToString(); //Материалы
                pictureBox13.Image = Image.FromFile(tovar.Rows[counter + 15][3].ToString());

                label57.Text = tovar.Rows[counter + 16][0].ToString(); //Наименование
                label38.Text = tovar.Rows[counter + 16][4].ToString(); //Тип товара
                label76.Text = tovar.Rows[counter + 16][1].ToString(); //Артикул
                label116.Text = tovar.Rows[counter + 16][2].ToString(); //Стоимость
                label96.Text = "Материалы" + tovar.Rows[counter + 16][4].ToString(); //Материалы
                pictureBox14.Image = Image.FromFile(tovar.Rows[counter + 16][3].ToString());

                label58.Text = tovar.Rows[counter + 17][0].ToString(); //Наименование
                label39.Text = tovar.Rows[counter + 17][4].ToString(); //Тип товара
                label77.Text = tovar.Rows[counter + 17][1].ToString(); //Артикул
                label117.Text = tovar.Rows[counter + 17][2].ToString(); //Стоимость
                label97.Text = "Материалы" + tovar.Rows[counter + 17][4].ToString(); //Материалы
                pictureBox15.Image = Image.FromFile(tovar.Rows[counter + 17][3].ToString());

                label59.Text = tovar.Rows[counter + 18][0].ToString(); //Наименование
                label40.Text = tovar.Rows[counter + 18][4].ToString(); //Тип товара
                label78.Text = tovar.Rows[counter + 18][1].ToString(); //Артикул
                label118.Text = tovar.Rows[counter + 18][2].ToString(); //Стоимость
                label98.Text = "Материалы" + tovar.Rows[counter + 18][4].ToString(); //Материалы
                pictureBox16.Image = Image.FromFile(tovar.Rows[counter + 18][3].ToString());

                label60.Text = tovar.Rows[counter + 19][0].ToString(); //Наименование
                label41.Text = tovar.Rows[counter + 19][4].ToString(); //Тип товара
                label79.Text = tovar.Rows[counter + 19][1].ToString(); //Артикул
                label119.Text = tovar.Rows[counter + 19][2].ToString(); //Стоимость
                label99.Text = "Материалы" + tovar.Rows[counter + 19][4].ToString(); //Материалы
                pictureBox11.Image = Image.FromFile(tovar.Rows[counter + 19][3].ToString());
            }
            catch
            {
                MessageBox.Show("Все возможные позиции выведены на экран");
            }
        }
        private void label82_Click(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var reader = new SqlCommand("SELECT * from products_b_import ORDER BY Наименование_продукции ASC", dataBase.getConnection()).ExecuteReader();
            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;
            GetData(counter);
        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var reader = new SqlCommand("SELECT * from products_b_import ORDER BY Наименование_продукции DESC", dataBase.getConnection()).ExecuteReader();
            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;
            GetData(counter);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void одинСлойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var reader = new SqlCommand("SELECT * from products_b_import where concat(Тип_продукции, Тип_продукции)like '%" + "1" + "%'", dataBase.getConnection()).ExecuteReader();
            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;
            GetData(counter);
        }

        private void дваСлояToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var reader = new SqlCommand("SELECT * from products_b_import where concat(Тип_продукции, Тип_продукции)like '%" + "2" + "%'", dataBase.getConnection()).ExecuteReader();
            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;
            GetData(counter);
        }

        private void триСлояToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var reader = new SqlCommand("SELECT * from products_b_import where concat(Тип_продукции, Тип_продукции)like '%" + "3" + "%'", dataBase.getConnection()).ExecuteReader();
            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;
            GetData(counter);
        }

        private void детскаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var reader = new SqlCommand("SELECT * from products_b_import where concat(Тип_продукции, Тип_продукции)like '%" + "4" + "%'", dataBase.getConnection()).ExecuteReader();
            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;
            GetData(counter);
        }

        private void суперМягкаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var reader = new SqlCommand("SELECT * from products_b_import where concat(тип_продукции, Тип_продукции)like '%" + "5" + "%'", dataBase.getConnection()).ExecuteReader();
            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;
            GetData(counter);
        }
    }
}
