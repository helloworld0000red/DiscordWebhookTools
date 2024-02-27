using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWebhooktools
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }



        private void close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Message_TextChanged(object sender, EventArgs e)
        {

        }

        private async void sendonce_Click(object sender, EventArgs e)
        {
            string webhookUrl = form1.GetWebhookUrl();
            string message = Message.Text.Trim();

            if (string.IsNullOrEmpty(webhookUrl))
            {
                MessageBox.Show("No webhook :O");
                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Pwease entwer meswage :3");
                return;
            }

            bool success = await SendMessageToWebhook(webhookUrl, message);

            if (success)
            {
                MessageBox.Show("Mewsage Swent Succesfuwy daddy ;3");
            }
            else
            {
                MessageBox.Show("fawild to swend messwage UwU :O Webhook might be gon");
            }
        }


        private async Task<bool> SendMessageToWebhook(string webhookUrl, string message)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    string jsonPayload = JsonConvert.SerializeObject(new { content = message });
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(webhookUrl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("success i dont have to write like a furry here since this is console no one will see this");
                        return true;
                    }
                    else
                    {
                        // Log the error message
                        Console.WriteLine($"failed why: {response.StatusCode}");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"error: {ex.Message}");
                return false;
            }
        }

        private async void Spam_ClickAsync(object sender, EventArgs e)
        {
            string webhookUrl = form1.GetWebhookUrl();
            string message = Message.Text.Trim();

            if (string.IsNullOrEmpty(webhookUrl))
            {
                MessageBox.Show("No webhook :O");
                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Pwease entwer meswage :3");
                return;
            }

            while (true)
            {
                bool success = await SendMessageToWebhook(webhookUrl, message);

                if (success)
                {
                    Console.WriteLine("Mewsage Swent Succesfuwy daddy ;3");
                }
                else
                {
                    Console.WriteLine("fawild to swend messwage UwU :O Webhook might be gon");
                }

                // Deway
                await Task.Delay(100);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
