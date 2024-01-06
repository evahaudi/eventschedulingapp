using MySql.Data.MySqlClient;

using System;
using System.Net;
using System.Windows.Forms;
using Google.Cloud.Translation.V2;
using Newtonsoft.Json.Linq;

namespace Schedulingproject
{
    public partial class Form1 : Form
    {
        private const string IPSTACK_API_KEY = " 67e66dce9544524be732c9c7917d35d1";
        private const string GOOGLE_TRANSLATE_API_KEY = "AIzaSyCrmMJIUwka1bSH6jX_UUz6nzyRLNtwgdY";

        public Form1()
        {
            InitializeComponent();
        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string connectionString = "Server=localhost;Database=client_schedule;Uid=root;Pwd=@2023Germany;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM user WHERE userName = @username AND password = @password";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        string userLanguage = GetUserLanguage();
                        string successMessage = "Login Successful!";
                        string translatedMessage = TranslateText(successMessage, userLanguage);
                        MessageBox.Show(translatedMessage);
                        // Add code here to navigate to another form or perform necessary actions upon successful login
                    }
                    else
                    {
                        string errorMessage = "Invalid username or password!";
                        string userLanguage = GetUserLanguage();
                        string translatedMessage = TranslateText(errorMessage, userLanguage);
                        MessageBox.Show(translatedMessage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private string GetUserLanguage()
        {
            try
            {
                string ipAddress = new WebClient().DownloadString("https://api.ipify.org");
                string response = new WebClient().DownloadString($"http://api.ipstack.com/{ipAddress}?access_key={IPSTACK_API_KEY}");
                dynamic data = JObject.Parse(response);

                return data.language ?? "en"; // User's preferred language or default to English if language cannot be determined
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting user's language: " + ex.Message);
                return "en"; // Default language if language cannot be determined
            }
        }

        private string TranslateText(string text, string targetLanguage)
        {
            try
            {
                TranslationClient client = TranslationClient.CreateFromApiKey(GOOGLE_TRANSLATE_API_KEY);
                TranslationResult result = client.TranslateText(text, targetLanguage);
                return result.TranslatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error translating text: " + ex.Message);
                return text; // Return original text in case of translation failure
            }
        }
    }
}
