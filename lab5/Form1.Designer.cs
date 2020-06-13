namespace InterfacesPart2
{
    partial class Form1
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.trackBarDraught = new System.Windows.Forms.TrackBar();
            this.comboBoxVesselType = new System.Windows.Forms.ComboBox();
            this.hScrollMaxSpeed = new System.Windows.Forms.HScrollBar();
            this.comboBoxSpeedUnit = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDraught = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDraught)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(396, 29);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(195, 22);
            this.textBoxTitle.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(396, 245);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(195, 22);
            this.textBoxPrice.TabIndex = 1;
            this.textBoxPrice.Text = "1000";
            // 
            // trackBarDraught
            // 
            this.trackBarDraught.Location = new System.Drawing.Point(396, 80);
            this.trackBarDraught.Maximum = 100;
            this.trackBarDraught.Minimum = 1;
            this.trackBarDraught.Name = "trackBarDraught";
            this.trackBarDraught.Size = new System.Drawing.Size(329, 56);
            this.trackBarDraught.TabIndex = 2;
            this.trackBarDraught.Value = 1;
            this.trackBarDraught.ValueChanged += new System.EventHandler(this.trackBarDraught_ValueChanged);
            // 
            // comboBoxVesselType
            // 
            this.comboBoxVesselType.FormattingEnabled = true;
            this.comboBoxVesselType.Location = new System.Drawing.Point(412, 130);
            this.comboBoxVesselType.Name = "comboBoxVesselType";
            this.comboBoxVesselType.Size = new System.Drawing.Size(148, 24);
            this.comboBoxVesselType.TabIndex = 3;
            this.comboBoxVesselType.SelectedIndexChanged += new System.EventHandler(this.comboBoxVesselType_SelectedIndexChanged);
            // 
            // hScrollMaxSpeed
            // 
            this.hScrollMaxSpeed.Location = new System.Drawing.Point(396, 190);
            this.hScrollMaxSpeed.Maximum = 109;
            this.hScrollMaxSpeed.Name = "hScrollMaxSpeed";
            this.hScrollMaxSpeed.Size = new System.Drawing.Size(271, 32);
            this.hScrollMaxSpeed.TabIndex = 4;
            this.hScrollMaxSpeed.ValueChanged += new System.EventHandler(this.hScrollMaxSpeed_ValueChanged);
            // 
            // comboBoxSpeedUnit
            // 
            this.comboBoxSpeedUnit.FormattingEnabled = true;
            this.comboBoxSpeedUnit.Location = new System.Drawing.Point(723, 192);
            this.comboBoxSpeedUnit.Name = "comboBoxSpeedUnit";
            this.comboBoxSpeedUnit.Size = new System.Drawing.Size(65, 24);
            this.comboBoxSpeedUnit.TabIndex = 5;
            this.comboBoxSpeedUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpeedUnit_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Load photo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PNG|*png";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Draught";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vessel type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // labelDraught
            // 
            this.labelDraught.AutoSize = true;
            this.labelDraught.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDraught.Location = new System.Drawing.Point(731, 80);
            this.labelDraught.Name = "labelDraught";
            this.labelDraught.Size = new System.Drawing.Size(29, 23);
            this.labelDraught.TabIndex = 13;
            this.labelDraught.Text = "0.1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 59);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(687, 193);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(16, 23);
            this.labelSpeed.TabIndex = 15;
            this.labelSpeed.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelDraught);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxSpeedUnit);
            this.Controls.Add(this.hScrollMaxSpeed);
            this.Controls.Add(this.comboBoxVesselType);
            this.Controls.Add(this.trackBarDraught);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "Form1";
            this.Text = "BoatStore";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDraught)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TrackBar trackBarDraught;
        private System.Windows.Forms.ComboBox comboBoxVesselType;
        private System.Windows.Forms.HScrollBar hScrollMaxSpeed;
        private System.Windows.Forms.ComboBox comboBoxSpeedUnit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDraught;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelSpeed;
    }
}

