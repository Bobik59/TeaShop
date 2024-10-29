using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace TeaShop
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MsSqlConnLibrary"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTeaData();
        }
        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm();
            editForm.ShowDialog();
            LoadTeaData();
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var teaId = (int)selectedRow.Cells["Id"].Value;
                var teaName = selectedRow.Cells["Name"].Value.ToString();
                var typeId = (int)selectedRow.Cells["TypeId"].Value;
                var countryId = (int)selectedRow.Cells["CountryId"].Value;
                var description = selectedRow.Cells["Description"].Value.ToString();
                var quantityGrams = (int)selectedRow.Cells["QuantityGrams"].Value;
                var costPrice = (decimal)selectedRow.Cells["CostPrice"].Value;

                var editForm = new EditForm(teaId, teaName, typeId, countryId, description, quantityGrams, costPrice);
                editForm.ShowDialog();
                LoadTeaData();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.");
            }
        }


        // Загрузка всех данных из таблицы Tea при запуске формы
        private void LoadTeaData()
        {
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Tea", conn);
                ds = new DataSet();
                adapter.Fill(ds, "Tea");
                dataGridView1.DataSource = ds.Tables["Tea"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                adapter = new SqlDataAdapter(query, conn);
                if (parameters != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                }
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}");
            }
        }

        private void btnShowCherryTea_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT * FROM Tea WHERE Description LIKE @description",
                         new SqlParameter("@description", "%вишни%"));
        }

        private void btnShowCostRange_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCostFrom.Text, out decimal costFrom) &&
                decimal.TryParse(txtCostTo.Text, out decimal costTo))
            {
                ExecuteQuery("SELECT * FROM Tea WHERE CostPrice BETWEEN @costFrom AND @costTo",
                             new SqlParameter("@costFrom", costFrom),
                             new SqlParameter("@costTo", costTo));
            }
            else
            {
                MessageBox.Show("Введите корректные значения для диапазона себестоимости.");
            }
        }

        private void btnShowQuantityRange_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantityFrom.Text, out int qtyFrom) &&
                int.TryParse(txtQuantityTo.Text, out int qtyTo))
            {
                ExecuteQuery("SELECT * FROM Tea WHERE QuantityGrams BETWEEN @qtyFrom AND @qtyTo",
                             new SqlParameter("@qtyFrom", qtyFrom),
                             new SqlParameter("@qtyTo", qtyTo));
            }
            else
            {
                MessageBox.Show("Введите корректные значения для диапазона количества грамм.");
            }
        }

        private void btnShowCountries_Click(object sender, EventArgs e)
        {
            string[] countries = txtCountries.Text.Split(',');
            string countryList = string.Join("','", countries.Select(c => c.Trim()));

            ExecuteQuery($"SELECT * FROM Tea JOIN Country ON Tea.CountryId = Country.Id WHERE Country.Name IN (N'{countryList}')");
        }

        private void btnShowCountryTeaCount_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT Country.Name, COUNT(Tea.Id) AS TeaCount FROM Tea JOIN Country ON Tea.CountryId = Country.Id GROUP BY Country.Name");
        }

        private void btnShowAverageQuantityPerCountry_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT Country.Name, AVG(Tea.QuantityGrams) AS AverageQuantity FROM Tea JOIN Country ON Tea.CountryId = Country.Id GROUP BY Country.Name");
        }

        private void btnShowTop3CheapestTeaInCountry_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT TOP 3 Tea.Name, Tea.CostPrice FROM Tea JOIN Country ON Tea.CountryId = Country.Id WHERE Country.Name = @country ORDER BY Tea.CostPrice ASC",
                         new SqlParameter("@country", txtCountry.Text.Trim()));
        }

        private void btnShowTop3ExpensiveTeaInCountry_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT TOP 3 Tea.Name, Tea.CostPrice FROM Tea JOIN Country ON Tea.CountryId = Country.Id WHERE Country.Name = @country ORDER BY Tea.CostPrice DESC",
                         new SqlParameter("@country", txtCountry.Text.Trim()));
        }

        private void btnShowTop3CheapestTeaAllCountries_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT TOP 3 Name, CostPrice FROM Tea ORDER BY CostPrice ASC");
        }

        private void btnShowTop3ExpensiveTeaAllCountries_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT TOP 3 Name, CostPrice FROM Tea ORDER BY CostPrice DESC");
        }

        private void btnTop3CountriesByTeaCount_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT TOP 3 Country.Name, COUNT(Tea.Id) AS TeaCount FROM Tea JOIN Country ON Tea.CountryId = Country.Id GROUP BY Country.Name ORDER BY TeaCount DESC");
        }

        private void btnTop3CountriesByQuantity_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT TOP 3 Country.Name, SUM(Tea.QuantityGrams) AS TotalQuantity FROM Tea JOIN Country ON Tea.CountryId = Country.Id GROUP BY Country.Name ORDER BY TotalQuantity DESC");
        }

        private void btnTop3GreenTeaByQuantity_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT TOP 3 Tea.Name, Tea.QuantityGrams FROM Tea JOIN Type ON Tea.TypeId = Type.Id WHERE Type.Name = @type ORDER BY Tea.QuantityGrams DESC",
                         new SqlParameter("@type", "Зеленый"));
        }

        private void btnTop3BlackTeaByQuantity_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT TOP 3 Tea.Name, Tea.QuantityGrams FROM Tea JOIN Type ON Tea.TypeId = Type.Id WHERE Type.Name = @type ORDER BY Tea.QuantityGrams DESC",
                         new SqlParameter("@type", "Черный"));
        }

        private void btnTop3TeaByTypeQuantity_Click(object sender, EventArgs e)
        {
            ExecuteQuery(@"SELECT Type.Name AS TeaType, Tea.Name, Tea.QuantityGrams 
                           FROM Tea 
                           JOIN Type ON Tea.TypeId = Type.Id 
                           ORDER BY Tea.QuantityGrams DESC");
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var teaId = (int)selectedRow.Cells["Id"].Value;

                    try
                    {
                        using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MsSqlConnLibrary"].ConnectionString))
                        {
                            conn.Open();
                            var cmd = new SqlCommand("DELETE FROM Tea WHERE Id = @Id", conn);
                            cmd.Parameters.AddWithValue("@Id", teaId);
                            cmd.ExecuteNonQuery();

                            LoadTeaData(); 
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при удалении записи: " + ex.Message);
                    }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.");
            }
        }

    }
}
