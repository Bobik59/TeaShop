using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TeaShop
{
    public partial class EditForm : Form
    {
        private int? teaId;

        public EditForm(int? teaId = null, string teaName = "", int typeId = 0, int countryId = 0,
                        string description = "", int quantityGrams = 0, decimal costPrice = 0)
        {
            InitializeComponent();
            this.teaId = teaId;

            // Установка значений в текстовые поля, если переданы данные для редактирования
            if (teaId.HasValue)
            {
                txtName.Text = teaName;
                txtTypeId.Text = typeId.ToString();
                txtCountryId.Text = countryId.ToString();
                txtDescription.Text = description;
                txtQuantityGrams.Text = quantityGrams.ToString();
                txtCostPrice.Text = costPrice.ToString();
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MsSqlConnLibrary"].ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd;

                    if (teaId.HasValue)
                    {
                        // Обновление записи
                        cmd = new SqlCommand("UPDATE Tea SET Name = @Name, TypeId = @TypeId, CountryId = @CountryId, " +
                                             "Description = @Description, QuantityGrams = @QuantityGrams, CostPrice = @CostPrice " +
                                             "WHERE Id = @Id", conn);
                        cmd.Parameters.AddWithValue("@Id", teaId.Value);
                    }
                    else
                    {
                        // Добавление новой записи
                        cmd = new SqlCommand("INSERT INTO Tea (Name, TypeId, CountryId, Description, QuantityGrams, CostPrice) " +
                                             "VALUES (@Name, @TypeId, @CountryId, @Description, @QuantityGrams, @CostPrice)", conn);
                        Close();
                    }

                    // Параметры
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@TypeId", int.Parse(txtTypeId.Text));
                    cmd.Parameters.AddWithValue("@CountryId", int.Parse(txtCountryId.Text));
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@QuantityGrams", int.Parse(txtQuantityGrams.Text));
                    cmd.Parameters.AddWithValue("@CostPrice", decimal.Parse(txtCostPrice.Text));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения данных: " + ex.Message);
            }
        }
    }
}
