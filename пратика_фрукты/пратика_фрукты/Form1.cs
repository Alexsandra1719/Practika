using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace FruityViceApp
{
    public partial class MainForm : Form
    {
        private const string OrderApiUrl = "https://www.fruityvice.com/api/fruit/order/";
        private const string AllFruitsApiUrl = "https://www.fruityvice.com/api/fruit/all";

        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string order = txtOrder.Text.Trim();
            if (string.IsNullOrEmpty(order))
            {
                MessageBox.Show("Введите название порядка фруктов (например: Rosales)");
                return;
            }

            await LoadAndDisplayFruits($"{OrderApiUrl}{order.ToLower()}");

        }

        private async void btnLoadAll_Click(object sender, EventArgs e)
        {
        
        }

        private async System.Threading.Tasks.Task LoadAndDisplayFruits(string apiUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        var fruits = JsonConvert.DeserializeObject<List<Fruit>>(jsonResponse);
                        DisplayFruits(fruits);
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка при загрузке данных: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

        }

        private void DisplayFruits(List<Fruit> fruits)
        {
            lstFruits.Items.Clear();
            if (fruits == null || fruits.Count == 0)
            {
                MessageBox.Show("Фрукты не найдены");
                return;
            }

            foreach (var fruit in fruits)
            {
                lstFruits.Items.Add(fruit.Name);
            }

            lstFruits.Tag = fruits;
        }



        private void lstFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFruits.SelectedIndex == -1 || !(lstFruits.Tag is List<Fruit> fruits))
                return;

            Fruit selectedFruit = fruits[lstFruits.SelectedIndex];
            DisplayFruitDetails(selectedFruit);

        }

        private void DisplayFruitDetails(Fruit fruit)
        {
            txtDetails.Text = $"Название: {fruit.Name}\r\n" +
                             $"Семейство: {fruit.Family}\r\n" +
                             $"Род: {fruit.Genus}\r\n" +
                             $"Калории: {fruit.Nutritions.Calories}\r\n" +
                             $"Жиры: {fruit.Nutritions.Fat}\r\n" +
                             $"Сахар: {fruit.Nutritions.Sugar}\r\n" +
                             $"Углеводы: {fruit.Nutritions.Carbohydrates}\r\n" +
                             $"Белки: {fruit.Nutritions.Protein}";
        }



    }




}