
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
            this.layer0 = new System.Windows.Forms.PictureBox();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.latest1 = new System.Windows.Forms.PictureBox();
            this.latest2 = new System.Windows.Forms.PictureBox();
            this.latest3 = new System.Windows.Forms.PictureBox();
            this.latest5 = new System.Windows.Forms.PictureBox();
            this.latest4 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.layer0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latest1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latest2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latest3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latest5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latest4)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.Location = new System.Drawing.Point(50, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дайте вашему мечу подходящее имя! ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.ForeColor = System.Drawing.Color.Cyan;
            this.textBox1.Location = new System.Drawing.Point(10, 55);
            this.textBox1.MaxLength = 22;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Это имя вашего меча";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8F);
            this.label4.Location = new System.Drawing.Point(152, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "(до 30 символов)";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GenerateButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.ForeColor = System.Drawing.Color.Black;
            this.GenerateButton.Location = new System.Drawing.Point(0, 490);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(662, 52);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Сгенерировать";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.Generate);
            // 
            // layer0
            // 
            this.layer0.BackColor = System.Drawing.Color.Gray;
            this.layer0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layer0.Location = new System.Drawing.Point(10, 100);
            this.layer0.Margin = new System.Windows.Forms.Padding(40, 0, 0, 40);
            this.layer0.Name = "layer0";
            this.layer0.Size = new System.Drawing.Size(320, 320);
            this.layer0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.layer0.TabIndex = 8;
            this.layer0.TabStop = false;
            // 
            // ConfigButton
            // 
            this.ConfigButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ConfigButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConfigButton.Font = new System.Drawing.Font("Consolas", 12F);
            this.ConfigButton.ForeColor = System.Drawing.Color.Black;
            this.ConfigButton.Location = new System.Drawing.Point(0, 461);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(662, 29);
            this.ConfigButton.TabIndex = 2;
            this.ConfigButton.Text = "Настроить";
            this.ConfigButton.UseVisualStyleBackColor = true;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigureGenerator);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.Location = new System.Drawing.Point(-1, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Или оставьте пустым для случайной генерации.";
            // 
            // latest1
            // 
            this.latest1.BackColor = System.Drawing.Color.Gray;
            this.latest1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.latest1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latest1.Location = new System.Drawing.Point(330, 100);
            this.latest1.Margin = new System.Windows.Forms.Padding(40, 0, 0, 40);
            this.latest1.Name = "latest1";
            this.latest1.Size = new System.Drawing.Size(64, 64);
            this.latest1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.latest1.TabIndex = 11;
            this.latest1.TabStop = false;
            // 
            // latest2
            // 
            this.latest2.BackColor = System.Drawing.Color.Gray;
            this.latest2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.latest2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latest2.Location = new System.Drawing.Point(330, 164);
            this.latest2.Margin = new System.Windows.Forms.Padding(40, 0, 0, 40);
            this.latest2.Name = "latest2";
            this.latest2.Size = new System.Drawing.Size(64, 64);
            this.latest2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.latest2.TabIndex = 12;
            this.latest2.TabStop = false;
            // 
            // latest3
            // 
            this.latest3.BackColor = System.Drawing.Color.Gray;
            this.latest3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.latest3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latest3.Location = new System.Drawing.Point(330, 228);
            this.latest3.Margin = new System.Windows.Forms.Padding(40, 0, 0, 40);
            this.latest3.Name = "latest3";
            this.latest3.Size = new System.Drawing.Size(64, 64);
            this.latest3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.latest3.TabIndex = 13;
            this.latest3.TabStop = false;
            // 
            // latest5
            // 
            this.latest5.BackColor = System.Drawing.Color.Gray;
            this.latest5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.latest5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latest5.Location = new System.Drawing.Point(330, 356);
            this.latest5.Margin = new System.Windows.Forms.Padding(40, 0, 0, 40);
            this.latest5.Name = "latest5";
            this.latest5.Size = new System.Drawing.Size(64, 64);
            this.latest5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.latest5.TabIndex = 15;
            this.latest5.TabStop = false;
            // 
            // latest4
            // 
            this.latest4.BackColor = System.Drawing.Color.Gray;
            this.latest4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.latest4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latest4.Location = new System.Drawing.Point(330, 292);
            this.latest4.Margin = new System.Windows.Forms.Padding(40, 0, 0, 40);
            this.latest4.Name = "latest4";
            this.latest4.Size = new System.Drawing.Size(64, 64);
            this.latest4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.latest4.TabIndex = 14;
            this.latest4.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.ForeColor = System.Drawing.Color.Cyan;
            this.textBox2.Location = new System.Drawing.Point(10, 432);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(384, 23);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Здесь будет имя которое нужно вставить в майнкрафт";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(397, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Количетво текстур";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(397, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Количество вариаций";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(397, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Код элемента 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(397, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Код элемента 2";
            // 
            // CountTextures
            // 
            this.CountTextures.AutoSize = true;
            this.CountTextures.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountTextures.Location = new System.Drawing.Point(546, 100);
            this.CountTextures.Name = "CountTextures";
            this.CountTextures.Size = new System.Drawing.Size(35, 15);
            this.CountTextures.TabIndex = 22;
            this.CountTextures.Text = "null";
            // 
            // CountVariations
            // 
            this.CountVariations.AutoSize = true;
            this.CountVariations.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountVariations.Location = new System.Drawing.Point(546, 132);
            this.CountVariations.Name = "CountVariations";
            this.CountVariations.Size = new System.Drawing.Size(35, 15);
            this.CountVariations.TabIndex = 23;
            this.CountVariations.Text = "null";
            // 
            // VariationId
            // 
            this.VariationId.AutoSize = true;
            this.VariationId.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VariationId.Location = new System.Drawing.Point(546, 228);
            this.VariationId.Name = "VariationId";
            this.VariationId.Size = new System.Drawing.Size(35, 15);
            this.VariationId.TabIndex = 24;
            this.VariationId.Text = "null";
            // 
            // Code2
            // 
            this.Code2.AutoSize = true;
            this.Code2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Code2.Location = new System.Drawing.Point(545, 198);
            this.Code2.Name = "Code2";
            this.Code2.Size = new System.Drawing.Size(35, 15);
            this.Code2.TabIndex = 25;
            this.Code2.Text = "null";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(420, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 39);
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
            this.button2.Location = new System.Drawing.Point(420, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 66);
            this.button2.TabIndex = 27;
            this.button2.Text = "Выгрузить коллекцию";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(397, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "id вариации";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(546, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "null";
            // 
            // MainForm
            // 
            this.AcceptButton = this.GenerateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.ConfigButton;
            this.ClientSize = new System.Drawing.Size(662, 542);
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
            this.Controls.Add(this.latest5);
            this.Controls.Add(this.latest4);
            this.Controls.Add(this.latest3);
            this.Controls.Add(this.latest2);
            this.Controls.Add(this.latest1);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.layer0);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Генератор мечей";
            ((System.ComponentModel.ISupportInitialize)(this.layer0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latest1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latest2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latest3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latest5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latest4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.PictureBox layer0;
        private System.Windows.Forms.Button ConfigButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox latest1;
        private System.Windows.Forms.PictureBox latest2;
        private System.Windows.Forms.PictureBox latest3;
        private System.Windows.Forms.PictureBox latest5;
        private System.Windows.Forms.PictureBox latest4;
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

