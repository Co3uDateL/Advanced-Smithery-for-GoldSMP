
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CountTextures = new System.Windows.Forms.Label();
            this.CountVariations = new System.Windows.Forms.Label();
            this.VariationId = new System.Windows.Forms.Label();
            this.Code2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FolderBro = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layer_3)).BeginInit();
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
            this.textBox1.Size = new System.Drawing.Size(511, 26);
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
            this.pb_sword.Location = new System.Drawing.Point(13, 123);
            this.pb_sword.Margin = new System.Windows.Forms.Padding(53, 0, 0, 49);
            this.pb_sword.Name = "pb_sword";
            this.pb_sword.Size = new System.Drawing.Size(427, 394);
            this.pb_sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_sword.TabIndex = 8;
            this.pb_sword.TabStop = false;
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
            this.layer_0.BackColor = System.Drawing.Color.Gray;
            this.layer_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layer_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layer_0.Location = new System.Drawing.Point(440, 123);
            this.layer_0.Margin = new System.Windows.Forms.Padding(53, 0, 0, 49);
            this.layer_0.Name = "layer_0";
            this.layer_0.Size = new System.Drawing.Size(85, 78);
            this.layer_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.layer_0.TabIndex = 11;
            this.layer_0.TabStop = false;
            this.layer_0.Click += new System.EventHandler(this.layer_0_Click);
            // 
            // layer_1
            // 
            this.layer_1.BackColor = System.Drawing.Color.Gray;
            this.layer_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layer_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layer_1.Location = new System.Drawing.Point(440, 202);
            this.layer_1.Margin = new System.Windows.Forms.Padding(53, 0, 0, 49);
            this.layer_1.Name = "layer_1";
            this.layer_1.Size = new System.Drawing.Size(85, 78);
            this.layer_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.layer_1.TabIndex = 12;
            this.layer_1.TabStop = false;
            this.layer_1.Click += new System.EventHandler(this.layer_1_Click);
            // 
            // layer_2
            // 
            this.layer_2.BackColor = System.Drawing.Color.Gray;
            this.layer_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layer_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layer_2.Location = new System.Drawing.Point(440, 281);
            this.layer_2.Margin = new System.Windows.Forms.Padding(53, 0, 0, 49);
            this.layer_2.Name = "layer_2";
            this.layer_2.Size = new System.Drawing.Size(85, 78);
            this.layer_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.layer_2.TabIndex = 13;
            this.layer_2.TabStop = false;
            this.layer_2.Click += new System.EventHandler(this.layer_2_Click);
            // 
            // layer_4
            // 
            this.layer_4.BackColor = System.Drawing.Color.Gray;
            this.layer_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layer_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layer_4.Location = new System.Drawing.Point(440, 438);
            this.layer_4.Margin = new System.Windows.Forms.Padding(53, 0, 0, 49);
            this.layer_4.Name = "layer_4";
            this.layer_4.Size = new System.Drawing.Size(85, 78);
            this.layer_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.layer_4.TabIndex = 15;
            this.layer_4.TabStop = false;
            this.layer_4.Click += new System.EventHandler(this.layer_4_Click);
            // 
            // layer_3
            // 
            this.layer_3.BackColor = System.Drawing.Color.Gray;
            this.layer_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layer_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layer_3.Location = new System.Drawing.Point(440, 359);
            this.layer_3.Margin = new System.Windows.Forms.Padding(53, 0, 0, 49);
            this.layer_3.Name = "layer_3";
            this.layer_3.Size = new System.Drawing.Size(85, 78);
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
            this.textBox2.Size = new System.Drawing.Size(511, 26);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Здесь будет имя которое нужно вставить в майнкрафт";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(529, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Количетво текстур";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(529, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Количество вариаций";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(529, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Код элемента 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(529, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Код элемента 2";
            // 
            // CountTextures
            // 
            this.CountTextures.AutoSize = true;
            this.CountTextures.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountTextures.Location = new System.Drawing.Point(728, 123);
            this.CountTextures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountTextures.Name = "CountTextures";
            this.CountTextures.Size = new System.Drawing.Size(45, 20);
            this.CountTextures.TabIndex = 22;
            this.CountTextures.Text = "null";
            // 
            // CountVariations
            // 
            this.CountVariations.AutoSize = true;
            this.CountVariations.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountVariations.Location = new System.Drawing.Point(728, 162);
            this.CountVariations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountVariations.Name = "CountVariations";
            this.CountVariations.Size = new System.Drawing.Size(45, 20);
            this.CountVariations.TabIndex = 23;
            this.CountVariations.Text = "null";
            // 
            // VariationId
            // 
            this.VariationId.AutoSize = true;
            this.VariationId.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VariationId.Location = new System.Drawing.Point(728, 281);
            this.VariationId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VariationId.Name = "VariationId";
            this.VariationId.Size = new System.Drawing.Size(45, 20);
            this.VariationId.TabIndex = 24;
            this.VariationId.Text = "null";
            // 
            // Code2
            // 
            this.Code2.AutoSize = true;
            this.Code2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Code2.Location = new System.Drawing.Point(727, 244);
            this.Code2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Code2.Name = "Code2";
            this.Code2.Size = new System.Drawing.Size(45, 20);
            this.Code2.TabIndex = 25;
            this.Code2.Text = "null";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(560, 423);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 48);
            this.button1.TabIndex = 26;
            this.button1.Text = "Выбрать путь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StartSaving);
            // 
            // FolderBro
            // 
            this.FolderBro.SelectedPath = "C:\\Users\\Admin\\Desktop";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(560, 479);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 81);
            this.button2.TabIndex = 27;
            this.button2.Text = "Выгрузить коллекцию";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(529, 281);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "id вариации";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(728, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "null";
            // 
            // MainForm
            // 
            this.AcceptButton = this.GenerateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.ConfigButton;
            this.ClientSize = new System.Drawing.Size(883, 667);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Code2);
            this.Controls.Add(this.VariationId);
            this.Controls.Add(this.CountVariations);
            this.Controls.Add(this.CountTextures);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.layer_4);
            this.Controls.Add(this.layer_3);
            this.Controls.Add(this.layer_2);
            this.Controls.Add(this.layer_1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CountTextures;
        private System.Windows.Forms.Label CountVariations;
        private System.Windows.Forms.Label VariationId;
        private System.Windows.Forms.Label Code2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog FolderBro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

