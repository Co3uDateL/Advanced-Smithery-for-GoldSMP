
namespace _GOLDSMP__Smithery
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.pb_sword = new System.Windows.Forms.PictureBox();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.layer_0 = new System.Windows.Forms.PictureBox();
            this.layer_1 = new System.Windows.Forms.PictureBox();
            this.layer_2 = new System.Windows.Forms.PictureBox();
            this.layer_4 = new System.Windows.Forms.PictureBox();
            this.layer_3 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Code2 = new System.Windows.Forms.Label();
            this.FolderBro = new System.Windows.Forms.FolderBrowserDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.Location = new System.Drawing.Point(67, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дайте вашему мечу подходящее имя! ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.ForeColor = System.Drawing.Color.Cyan;
            this.textBox1.Location = new System.Drawing.Point(13, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 22;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(487, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Это имя вашего меча";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8F);
            this.label4.Location = new System.Drawing.Point(203, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "(до 30 символов)";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GenerateButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.ForeColor = System.Drawing.Color.Black;
            this.GenerateButton.Location = new System.Drawing.Point(0, 603);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(883, 64);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Сгенерировать";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.Generate);
            // 
            // pb_sword
            // 
            this.pb_sword.BackColor = System.Drawing.Color.Gray;
            this.pb_sword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_sword.Location = new System.Drawing.Point(20, 120);
            this.pb_sword.Margin = new System.Windows.Forms.Padding(0);
            this.pb_sword.Name = "pb_sword";
            this.pb_sword.Size = new System.Drawing.Size(400, 400);
            this.pb_sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_sword.TabIndex = 8;
            this.pb_sword.TabStop = false;
            this.pb_sword.Click += new System.EventHandler(this.pb_sword_Click);
            // 
            // ConfigButton
            // 
            this.ConfigButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ConfigButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConfigButton.Font = new System.Drawing.Font("Consolas", 12F);
            this.ConfigButton.ForeColor = System.Drawing.Color.Black;
            this.ConfigButton.Location = new System.Drawing.Point(0, 567);
            this.ConfigButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(883, 36);
            this.ConfigButton.TabIndex = 2;
            this.ConfigButton.Text = "Настроить";
            this.ConfigButton.UseVisualStyleBackColor = true;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigureGenerator);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.Location = new System.Drawing.Point(-1, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(494, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Или оставьте пустым для случайной генерации.";
            // 
            // layer_0
            // 
            this.layer_0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layer_0.BackColor = System.Drawing.Color.Gray;
            this.layer_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layer_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layer_0.Location = new System.Drawing.Point(420, 120);
            this.layer_0.Margin = new System.Windows.Forms.Padding(0);
            this.layer_0.Name = "layer_0";
            this.layer_0.Size = new System.Drawing.Size(80, 80);
            this.layer_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.layer_0.TabIndex = 11;
            this.layer_0.TabStop = false;
            this.layer_0.Click += new System.EventHandler(this.layer_0_Click);
            // 
            // layer_1
            // 
            this.layer_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layer_1.BackColor = System.Drawing.Color.Gray;
            this.layer_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layer_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layer_1.Location = new System.Drawing.Point(420, 200);
            this.layer_1.Margin = new System.Windows.Forms.Padding(0);
            this.layer_1.Name = "layer_1";
            this.layer_1.Size = new System.Drawing.Size(80, 80);
            this.layer_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.layer_1.TabIndex = 12;
            this.layer_1.TabStop = false;
            this.layer_1.Click += new System.EventHandler(this.layer_1_Click);
            // 
            // layer_2
            // 
            this.layer_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layer_2.BackColor = System.Drawing.Color.Gray;
            this.layer_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layer_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layer_2.Location = new System.Drawing.Point(420, 280);
            this.layer_2.Margin = new System.Windows.Forms.Padding(0);
            this.layer_2.Name = "layer_2";
            this.layer_2.Size = new System.Drawing.Size(80, 80);
            this.layer_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.layer_2.TabIndex = 13;
            this.layer_2.TabStop = false;
            this.layer_2.Click += new System.EventHandler(this.layer_2_Click);
            // 
            // layer_4
            // 
            this.layer_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layer_4.BackColor = System.Drawing.Color.Gray;
            this.layer_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layer_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layer_4.Location = new System.Drawing.Point(420, 440);
            this.layer_4.Margin = new System.Windows.Forms.Padding(0);
            this.layer_4.Name = "layer_4";
            this.layer_4.Size = new System.Drawing.Size(80, 80);
            this.layer_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.layer_4.TabIndex = 15;
            this.layer_4.TabStop = false;
            this.layer_4.Click += new System.EventHandler(this.layer_4_Click);
            // 
            // layer_3
            // 
            this.layer_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layer_3.BackColor = System.Drawing.Color.Gray;
            this.layer_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layer_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layer_3.Location = new System.Drawing.Point(420, 360);
            this.layer_3.Margin = new System.Windows.Forms.Padding(0);
            this.layer_3.Name = "layer_3";
            this.layer_3.Size = new System.Drawing.Size(80, 80);
            this.layer_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.layer_3.TabIndex = 14;
            this.layer_3.TabStop = false;
            this.layer_3.Click += new System.EventHandler(this.layer_3_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.ForeColor = System.Drawing.Color.Cyan;
            this.textBox2.Location = new System.Drawing.Point(13, 532);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(487, 26);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Здесь будет имя которое нужно вставить в майнкрафт";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Code2
            // 
            this.Code2.AutoSize = true;
            this.Code2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Code2.Location = new System.Drawing.Point(339, 500);
            this.Code2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Code2.Name = "Code2";
            this.Code2.Size = new System.Drawing.Size(81, 20);
            this.Code2.TabIndex = 25;
            this.Code2.Text = "Код меча";
            // 
            // FolderBro
            // 
            this.FolderBro.SelectedPath = "C:\\Users\\Admin\\Desktop";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(21, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Текстуры";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(420, 120);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.layer_0_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(420, 200);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.layer_1_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.GenerateButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.ConfigButton;
            this.ClientSize = new System.Drawing.Size(883, 667);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Code2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.layer_4);
            this.Controls.Add(this.layer_3);
            this.Controls.Add(this.layer_2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.layer_1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.layer_0);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.pb_sword);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Генератор мечей";
            ((System.ComponentModel.ISupportInitialize)(this.pb_sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.PictureBox pb_sword;
        private System.Windows.Forms.Button ConfigButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox layer_0;
        private System.Windows.Forms.PictureBox layer_1;
        private System.Windows.Forms.PictureBox layer_2;
        private System.Windows.Forms.PictureBox layer_4;
        private System.Windows.Forms.PictureBox layer_3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Code2;
        private System.Windows.Forms.FolderBrowserDialog FolderBro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

