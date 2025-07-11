namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button4
            // 
            this.Button4.Animated = true;
            this.Button4.AutoRoundedCorners = true;
            this.Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button4.Font = new System.Drawing.Font("LEMON MILK Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.Location = new System.Drawing.Point(-2, 102);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(194, 63);
            this.Button4.TabIndex = 13;
            this.Button4.Text = "KLASÖRÜ OTOMATİK BUL";
            this.Button4.Click += new System.EventHandler(this.Button4_Click_1);
            // 
            // Button3
            // 
            this.Button3.Animated = true;
            this.Button3.AutoRoundedCorners = true;
            this.Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button3.Font = new System.Drawing.Font("LEMON MILK Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(567, 143);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(119, 35);
            this.Button3.TabIndex = 12;
            this.Button3.Text = "SİL";
            this.Button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // Button2
            // 
            this.Button2.Animated = true;
            this.Button2.AutoRoundedCorners = true;
            this.Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button2.Font = new System.Drawing.Font("LEMON MILK Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(567, 102);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(119, 35);
            this.Button2.TabIndex = 11;
            this.Button2.Text = "İNDİR";
            this.Button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // Button1
            // 
            this.Button1.Animated = true;
            this.Button1.AutoRoundedCorners = true;
            this.Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Button1.Font = new System.Drawing.Font("LEMON MILK Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(567, 61);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(119, 35);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "Klasör Seç";
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Animated = true;
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBox1.BorderRadius = 10;
            this.textBox1.BorderThickness = 2;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DefaultText = "";
            this.textBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("LEMON MILK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(193, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBox1.PlaceholderText = "";
            this.textBox1.SelectedText = "";
            this.textBox1.Size = new System.Drawing.Size(365, 35);
            this.textBox1.TabIndex = 9;
            // 
            // Guna2Panel1
            // 
            this.Guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.Guna2Panel1.Controls.Add(this.Close);
            this.Guna2Panel1.Controls.Add(this.Minimize);
            this.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Guna2Panel1.Location = new System.Drawing.Point(-2, -2);
            this.Guna2Panel1.Name = "Guna2Panel1";
            this.Guna2Panel1.Size = new System.Drawing.Size(697, 41);
            this.Guna2Panel1.TabIndex = 8;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.CustomClick = true;
            this.Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Close.IconColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(661, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(36, 36);
            this.Close.TabIndex = 2;
            this.Close.Click += new System.EventHandler(this.Close_Click_1);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Minimize.IconColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(617, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(36, 36);
            this.Minimize.TabIndex = 1;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("LEMON MILK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(-2, 66);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(194, 30);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Dosya Konumu:";
            // 
            // Guna2DragControl1
            // 
            this.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.Guna2DragControl1.TargetControl = this.Guna2Panel1;
            this.Guna2DragControl1.UseTransparentDrag = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(693, 253);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Guna2Panel1);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RDR2 TR Yama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2Button Button4;
        internal Guna.UI2.WinForms.Guna2Button Button3;
        internal Guna.UI2.WinForms.Guna2Button Button2;
        internal Guna.UI2.WinForms.Guna2Button Button1;
        internal Guna.UI2.WinForms.Guna2TextBox textBox1;
        internal Guna.UI2.WinForms.Guna2Panel Guna2Panel1;
        internal Guna.UI2.WinForms.Guna2ControlBox Close;
        internal Guna.UI2.WinForms.Guna2ControlBox Minimize;
        internal System.Windows.Forms.Label Label1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
    }
}

