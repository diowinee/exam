using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOO_Odejda_dlya_rychek.Forms;
using System.Data.SqlClient;
using OOO_Odejda_dlya_rychek.Classes;

namespace OOO_Odejda_dlya_rychek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verhnayaPanel.BackColor = ColorTranslator.FromHtml("#B3F4E9");
            nijnyaPanel.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            dobavitMaterial.BackColor = ColorTranslator.FromHtml("#B3F4E9");
            redactirovat.BackColor = ColorTranslator.FromHtml("#B3F4E9");
            vivodMaterialov.BackgroundColor = ColorTranslator.FromHtml("#B3F4E9");
            vivodMaterialov.Columns.Add("id", "Id");
            vivodMaterialov.Columns.Add("titlePoln", "Название");
            vivodMaterialov.Columns.Add("material", "Материал");
            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column.Name = "Изображение";
            column.ImageLayout = DataGridViewImageCellLayout.Zoom;
            vivodMaterialov.Columns.Add(column);
            vivodMaterialov.Columns.Add("price", "Цена");
            vivodMaterialov.Columns.Add("countHouse", "Кол");
            vivodMaterialov.Columns.Add("minCount", "Кол");
            vivodMaterialov.Columns.Add("countPack", "Кол");
            vivodMaterialov.Columns.Add("descr", "Описание");
            sortirovka.Items.Add("Наименование по убыванию");
            sortirovka.Items.Add("Остаток на складе по убыванию");
            sortirovka.Items.Add("Стоимость по убыванию");
            sortirovka.Items.Add("Наименование по возрастанию");
            sortirovka.Items.Add("Остаток на складе по возрастанию");
            sortirovka.Items.Add("Стоимость по возрастанию");
            filtracia.DropDownStyle = ComboBoxStyle.DropDown;
            sortirovka.DropDownStyle = ComboBoxStyle.DropDown;
            sortirovka.SelectedIndex = 3;
            filtracia.Items.Add("Все типы");
            filtracia.SelectedIndex = 0;
            vivodMaterialov.AllowUserToAddRows = false;
            vivodMaterialov.AllowUserToDeleteRows = false;
            vivodMaterialov.ReadOnly = true;
            vivodMaterialov.Columns[0].Visible = false;
            SqlConnection connection = new SqlConnection(Connection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "select * from [dbo].[MaterialType]";
                SqlCommand cmd = new SqlCommand(sqlExp,connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        filtracia.Items.Add(reader[1].ToString());
                    }
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Прозошла ошибка : {ex}");
            }
            connection.Close();
            vidodDannihDataGrid();
        }

        private void dobavitMaterial_Click(object sender, EventArgs e)
        {
            AddMaterial addMaterial = new AddMaterial();
            addMaterial.Show();
            this.Hide();
        }

        private void redactirovat_Click(object sender, EventArgs e)
        {
            EditMaterial editMaterial = new EditMaterial();
            editMaterial.Show();
            this.Hide();
        }

        private void vidodDannihDataGrid()
        {

            SqlConnection connection = new SqlConnection(Connection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "select * from [dbo].[Material] m inner join [dbo].[MaterialType] mt on m.MaterialTypeId=mt.Id" +
                    " where m.Title like @poisk";
                if (filtracia.Text!="Все типы")
                {
                    sqlExp += " and mt.Title = @filtr";  
                }
                sqlExp += "  order by ";
                switch (sortirovka.SelectedIndex)
                {
                    case 0:
                        sqlExp += "m.Title desc";
                        break;
                    case 1:
                        sqlExp += "m.countInWarehouse desc";
                        break;
                    case 2:
                        sqlExp += "m.Price desc";
                        break;
                    case 3:
                        sqlExp += "m.Title asc";
                        break;
                    case 4:
                        sqlExp += "m.countInWarehouse asc";
                        break;
                    case 5:
                        sqlExp += "m.Price asc";
                        break;
                }
                SqlCommand cmd = new SqlCommand(sqlExp, connection);
                cmd.Parameters.AddWithValue("@poisk", poisk.Text+ "%");
                cmd.Parameters.AddWithValue("@filtr", filtracia.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                vivodMaterialov.Rows.Clear();
                if (reader.HasRows)
                {
                    int nomer = 0;
                    while (reader.Read())
                    {
                        vivodMaterialov.Rows.Add();
                        for (int x=0;x<9;x++)
                        {
                            if (x == 3)
                            {
                                vivodMaterialov.Rows[nomer].Cells[x].Value = Image.FromFile(Application.StartupPath + "\\materials\\picture.png");
                            }
                            else
                            {
                                vivodMaterialov.Rows[nomer].Cells[x].Value = reader[x].ToString();
                            }
                            
                        }
                        vivodMaterialov.Rows[nomer].DefaultCellStyle.BackColor = Color.Red;
                        nomer++;
                    }
                }
                reader.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Прозошла ошибка : {ex}");
            }
            connection.Close();
        }

        private void sortirovka_SelectedIndexChanged(object sender, EventArgs e)
        {
            vidodDannihDataGrid();
        }

        private void filtracia_SelectedIndexChanged(object sender, EventArgs e)
        {
            vidodDannihDataGrid();
        }

        private void poisk_TextChanged(object sender, EventArgs e)
        {
            bool sovdadenie = false;
            if (vivodMaterialov.RowCount == 0)
            {
                vidodDannihDataGrid();
            }
            for (int x=0;x<vivodMaterialov.RowCount;x++)
            {
                if (vivodMaterialov.Rows[x].Cells[1].Value.ToString().ToLower().StartsWith(poisk.Text.ToLower()))
                {
                    vidodDannihDataGrid();
                    sovdadenie = true;
                    break;
                }
            }
            if (!sovdadenie)
            {
                vivodMaterialov.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath);
        }
    }
}
