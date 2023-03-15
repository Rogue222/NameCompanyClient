using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NameCompanyClient.Windows
{
    /// <summary>
    /// Логика взаимодействия для Automatization.xaml
    /// </summary>
    public partial class Automatization : Window
    {
        public Automatization()
        {
            InitializeComponent();
        }

        private async void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.PostAsync($"http://localhost:61333/api/AccountInfoes?login={LoginTbx.Text}&password={PasswordPb.Password}", new StringContent(""));
            var message = await result.Content.ReadAsStringAsync();
            MessageBox.Show(result.Content.ToString());

        }
    }
}
