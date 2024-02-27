namespace DiscordWebhooktools
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.message = new Guna.UI2.WinForms.Guna2Button();
            this.file = new Guna.UI2.WinForms.Guna2Button();
            this.get = new Guna.UI2.WinForms.Guna2Button();
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.Console = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.minimise = new Guna.UI2.WinForms.Guna2CircleButton();
            this.webhook = new Guna.UI2.WinForms.Guna2TextBox();
            this.spam = new Guna.UI2.WinForms.Guna2Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // message
            // 
            this.message.Animated = true;
            this.message.AutoRoundedCorners = true;
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.BorderRadius = 12;
            this.message.DefaultAutoSize = true;
            this.message.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.message.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.message.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.message.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.message.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.message.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(461, 393);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(118, 27);
            this.message.TabIndex = 0;
            this.message.Text = "Send a Message";
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // file
            // 
            this.file.Animated = true;
            this.file.AutoRoundedCorners = true;
            this.file.BackColor = System.Drawing.Color.Transparent;
            this.file.BorderRadius = 12;
            this.file.DefaultAutoSize = true;
            this.file.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.file.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.file.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.file.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.file.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.file.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.file.ForeColor = System.Drawing.Color.White;
            this.file.IndicateFocus = true;
            this.file.Location = new System.Drawing.Point(284, 393);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(171, 27);
            this.file.TabIndex = 1;
            this.file.Text = "Send a File to A Webhook";
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // get
            // 
            this.get.Animated = true;
            this.get.AutoRoundedCorners = true;
            this.get.BorderRadius = 12;
            this.get.DefaultAutoSize = true;
            this.get.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.get.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.get.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.get.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.get.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.get.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.get.ForeColor = System.Drawing.Color.White;
            this.get.Location = new System.Drawing.Point(149, 393);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(129, 27);
            this.get.TabIndex = 2;
            this.get.Text = "Get Webhook info";
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // delete
            // 
            this.delete.Animated = true;
            this.delete.AutoRoundedCorners = true;
            this.delete.BorderRadius = 12;
            this.delete.DefaultAutoSize = true;
            this.delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(12, 393);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(131, 27);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete a Webhook";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.SystemColors.Desktop;
            this.Console.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Console.HideSelection = false;
            this.Console.Location = new System.Drawing.Point(12, 58);
            this.Console.Multiline = true;
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(690, 279);
            this.Console.TabIndex = 4;
            this.Console.Text = "Get request output";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(735, 40);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Red\'s Webhook Tools";
            // 
            // close
            // 
            this.close.Animated = true;
            this.close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.close.FillColor = System.Drawing.Color.Red;
            this.close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(686, 12);
            this.close.Name = "close";
            this.close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.close.Size = new System.Drawing.Size(20, 19);
            this.close.TabIndex = 6;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimise
            // 
            this.minimise.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimise.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimise.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimise.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimise.FillColor = System.Drawing.Color.Yellow;
            this.minimise.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimise.ForeColor = System.Drawing.Color.White;
            this.minimise.Location = new System.Drawing.Point(663, 12);
            this.minimise.Name = "minimise";
            this.minimise.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.minimise.Size = new System.Drawing.Size(20, 19);
            this.minimise.TabIndex = 7;
            this.minimise.Text = "Minimize";
            this.minimise.Click += new System.EventHandler(this.minimise_Click);
            // 
            // webhook
            // 
            this.webhook.Animated = true;
            this.webhook.AutoRoundedCorners = true;
            this.webhook.BorderRadius = 17;
            this.webhook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.webhook.DefaultText = "";
            this.webhook.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.webhook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.webhook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.webhook.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.webhook.FillColor = System.Drawing.Color.Black;
            this.webhook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.webhook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.webhook.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.webhook.Location = new System.Drawing.Point(12, 343);
            this.webhook.Name = "webhook";
            this.webhook.PasswordChar = '\0';
            this.webhook.PlaceholderText = "Webhook";
            this.webhook.SelectedText = "";
            this.webhook.Size = new System.Drawing.Size(690, 36);
            this.webhook.TabIndex = 8;
            // 
            // spam
            // 
            this.spam.Animated = true;
            this.spam.AutoRoundedCorners = true;
            this.spam.BackColor = System.Drawing.Color.Transparent;
            this.spam.BorderRadius = 12;
            this.spam.DefaultAutoSize = true;
            this.spam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.spam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.spam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.spam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.spam.ForeColor = System.Drawing.Color.White;
            this.spam.Location = new System.Drawing.Point(585, 393);
            this.spam.Name = "spam";
            this.spam.Size = new System.Drawing.Size(117, 27);
            this.spam.TabIndex = 9;
            this.spam.Text = "Spam Webhook";
            this.spam.Click += new System.EventHandler(this.spam_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.filePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filePathTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filePathTextBox.Location = new System.Drawing.Point(488, 37);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(528, 13);
            this.filePathTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::DiscordWebhooktools.Properties.Resources.pretty__1_;
            this.ClientSize = new System.Drawing.Size(718, 435);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.spam);
            this.Controls.Add(this.webhook);
            this.Controls.Add(this.minimise);
            this.Controls.Add(this.close);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.get);
            this.Controls.Add(this.file);
            this.Controls.Add(this.message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2Button get;
        private Guna.UI2.WinForms.Guna2Button file;
        private Guna.UI2.WinForms.Guna2Button message;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Console;
        private Guna.UI2.WinForms.Guna2CircleButton minimise;
        private Guna.UI2.WinForms.Guna2CircleButton close;
        private Guna.UI2.WinForms.Guna2TextBox webhook;
        private Guna.UI2.WinForms.Guna2Button spam;
        private System.Windows.Forms.TextBox filePathTextBox;
    }
}

