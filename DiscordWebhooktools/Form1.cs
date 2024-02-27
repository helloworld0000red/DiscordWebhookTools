using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWebhooktools
{
    public partial class Form1 : Form
    {
        private Form Form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void message_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            this.Focus();
        }

        private void spam_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            this.Focus();
        }

        private async void delete_Click(object sender, EventArgs e)
        {
            string webhookUrl = webhook.Text.Trim();

            if (string.IsNullOrEmpty(webhookUrl))
            {
                MessageBox.Show("pwease enter a webhook URL Daddy~");
                return;
            }

            bool success = await DeleteWebhookAsync(webhookUrl);

            if (success)
            {
                MessageBox.Show("He gon :O");
            }
            else
            {
                MessageBox.Show("UwU ther has bween a fucky wucky it would apwear we fawiled to delete the webhook punish me this could mean its already deleted");
            }
        }

        private static async Task<bool> DeleteWebhookAsync(string webhookUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.DeleteAsync(webhookUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {

                return false;
            }



        }
        public string GetWebhookUrl()
        {
            return webhook.Text.Trim();
        }

        private async void get_Click(object sender, EventArgs e)
        {
            string webhookUrl = webhook.Text.Trim();
            string responseContent = await SendGetRequest(webhookUrl);

            if (responseContent != null)
            {
                JObject json = JObject.Parse(responseContent);
                json.Remove("token");
                json.Remove("url");
                string output = "";
                int propertyCount = json.Properties().Count();
                int currentPropertyIndex = 0;
                foreach (var property in json.Properties())
                {
                    output += $"{property.Name}: {property.Value}";
                    if (currentPropertyIndex < propertyCount - 1)
                    {
                        output += $",{Environment.NewLine}";
                    }

                    currentPropertyIndex++;
                }
                Console.Text = output;

                MessageBox.Show("GET reqwestt sent successfwwy ;3");
            }
            else
            {
                MessageBox.Show("UwU ther has bween a fucky wucky it would apwear we fawiled to send get request to the webhook punish me this could mean its already deleted ;3");
            }
        }

        public static async Task<string> SendGetRequest(string webhookUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(webhookUrl);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        private void file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Fiwles (*.*)|*.*";
            openFileDialog.Title = "Sewecct a File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                filePathTextBox.Text = selectedFile;

                SendFileToWebhook(selectedFile);
            }
        }
        private async void SendFileToWebhook(string filePath)
        {
            try
            {
                string webhookUrl = webhook.Text.Trim();
                byte[] fileData = File.ReadAllBytes(filePath);

                using (var client = new HttpClient())
                using (var formData = new MultipartFormDataContent())
                {
                    formData.Add(new ByteArrayContent(fileData), "file", Path.GetFileName(filePath));

                    var response = await client.PostAsync(webhookUrl, formData);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        dynamic jsonResponse = JObject.Parse(responseContent);

                        string fileName = jsonResponse.attachments[0].filename;
                        string fileURL = jsonResponse.attachments[0].url;

                        Console.AppendText($"UwU\n\nFile Name: {fileName}\nFile URL: {fileURL}\n\n");
                    }
                    else
                    {
                        Console.AppendText($"fwucky wucky UwU: {response.StatusCode}\n\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.AppendText($"Fwucky Wwucky: {ex.Message}\n\n");
            }
        }
    }
}