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
           
        }

        
    }

   

   
}