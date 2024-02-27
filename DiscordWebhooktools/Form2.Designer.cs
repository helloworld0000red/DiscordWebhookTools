namespace DiscordWebhooktools
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.minimise = new Guna.UI2.WinForms.Guna2CircleButton();
            this.sendonce = new Guna.UI2.WinForms.Guna2Button();
            this.Spam = new Guna.UI2.WinForms.Guna2Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // close
            // 
            this.close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(407, 12);
            this.close.Name = "close";
            this.close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.close.Size = new System.Drawing.Size(22, 23);
            this.close.TabIndex = 0;
            this.close.Text = "close";
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
            this.minimise.Location = new System.Drawing.Point(379, 12);
            this.minimise.Name = "minimise";
            this.minimise.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.minimise.Size = new System.Drawing.Size(22, 23);
            this.minimise.TabIndex = 1;
            this.minimise.Text = "minimise";
            this.minimise.Click += new System.EventHandler(this.minimise_Click);
            // 
            // sendonce
            // 
            this.sendonce.Animated = true;
            this.sendonce.AutoRoundedCorners = true;
            this.sendonce.BorderRadius = 12;
            this.sendonce.DefaultAutoSize = true;
            this.sendonce.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendonce.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendonce.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendonce.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendonce.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendonce.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendonce.ForeColor = System.Drawing.Color.White;
            this.sendonce.Location = new System.Drawing.Point(12, 340);
            this.sendonce.Name = "sendonce";
            this.sendonce.Size = new System.Drawing.Size(89, 27);
            this.sendonce.TabIndex = 3;
            this.sendonce.Text = "Send Once";
            this.sendonce.Click += new System.EventHandler(this.sendonce_Click);
            // 
            // Spam
            // 
            this.Spam.Animated = true;
            this.Spam.AutoRoundedCorners = true;
            this.Spam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Spam.BorderRadius = 12;
            this.Spam.DefaultAutoSize = true;
            this.Spam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Spam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Spam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Spam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Spam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Spam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Spam.ForeColor = System.Drawing.Color.White;
            this.Spam.Location = new System.Drawing.Point(107, 340);
            this.Spam.Name = "Spam";
            this.Spam.Size = new System.Drawing.Size(112, 27);
            this.Spam.TabIndex = 4;
            this.Spam.Text = "Spam Message";
            this.Spam.Click += new System.EventHandler(this.Spam_ClickAsync);
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.SystemColors.InfoText;
            this.Message.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Message.Location = new System.Drawing.Point(12, 41);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(417, 293);
            this.Message.TabIndex = 5;
            this.Message.Text = "Message";
            this.Message.TextChanged += new System.EventHandler(this.Message_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::DiscordWebhooktools.Properties.Resources.pretty__1_;
            this.ClientSize = new System.Drawing.Size(441, 378);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Spam);
            this.Controls.Add(this.sendonce);
            this.Controls.Add(this.minimise);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CircleButton minimise;
        private Guna.UI2.WinForms.Guna2CircleButton close;
        private System.Windows.Forms.TextBox Message;
        private Guna.UI2.WinForms.Guna2Button Spam;
        private Guna.UI2.WinForms.Guna2Button sendonce;
    }
}