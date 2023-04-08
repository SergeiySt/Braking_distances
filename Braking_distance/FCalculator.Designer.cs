namespace Braking_distance
{
    partial class FCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCalculator));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BExit = new System.Windows.Forms.Button();
            this.brakesStatecomboBox = new System.Windows.Forms.ComboBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.carWeightTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tireDiameterTextBox = new System.Windows.Forms.TextBox();
            this.tireHeightTextBox = new System.Windows.Forms.TextBox();
            this.tireWidthTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tireTypeComboBox = new System.Windows.Forms.ComboBox();
            this.roadConditionComboBox = new System.Windows.Forms.ComboBox();
            this.roadTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weatherComboBox = new System.Windows.Forms.ComboBox();
            this.BResult = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(962, 432);
            this.tabControl.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.brakesStatecomboBox);
            this.tabPage1.Controls.Add(this.textBoxSpeed);
            this.tabPage1.Controls.Add(this.carWeightTextBox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tireTypeComboBox);
            this.tabPage1.Controls.Add(this.roadConditionComboBox);
            this.tabPage1.Controls.Add(this.roadTypeComboBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.weatherComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(954, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Калькулятор";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BExit
            // 
            this.BExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BExit.Location = new System.Drawing.Point(326, 335);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(151, 34);
            this.BExit.TabIndex = 48;
            this.BExit.Text = "Закрити вікно";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click_1);
            // 
            // brakesStatecomboBox
            // 
            this.brakesStatecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brakesStatecomboBox.FormattingEnabled = true;
            this.brakesStatecomboBox.Location = new System.Drawing.Point(238, 146);
            this.brakesStatecomboBox.Name = "brakesStatecomboBox";
            this.brakesStatecomboBox.Size = new System.Drawing.Size(204, 28);
            this.brakesStatecomboBox.TabIndex = 47;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpeed.Location = new System.Drawing.Point(238, 180);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(204, 26);
            this.textBoxSpeed.TabIndex = 46;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.resultLabel.Location = new System.Drawing.Point(15, 34);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(119, 32);
            this.resultLabel.TabIndex = 45;
            this.resultLabel.Text = "label10";
            // 
            // carWeightTextBox
            // 
            this.carWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carWeightTextBox.Location = new System.Drawing.Point(238, 215);
            this.carWeightTextBox.Name = "carWeightTextBox";
            this.carWeightTextBox.Size = new System.Drawing.Size(204, 26);
            this.carWeightTextBox.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tireDiameterTextBox);
            this.groupBox1.Controls.Add(this.tireHeightTextBox);
            this.groupBox1.Controls.Add(this.tireWidthTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(10, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 129);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Розмір шин";
            // 
            // tireDiameterTextBox
            // 
            this.tireDiameterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireDiameterTextBox.Location = new System.Drawing.Point(148, 92);
            this.tireDiameterTextBox.Name = "tireDiameterTextBox";
            this.tireDiameterTextBox.Size = new System.Drawing.Size(278, 26);
            this.tireDiameterTextBox.TabIndex = 5;
            // 
            // tireHeightTextBox
            // 
            this.tireHeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireHeightTextBox.Location = new System.Drawing.Point(148, 57);
            this.tireHeightTextBox.Name = "tireHeightTextBox";
            this.tireHeightTextBox.Size = new System.Drawing.Size(278, 26);
            this.tireHeightTextBox.TabIndex = 4;
            // 
            // tireWidthTextBox
            // 
            this.tireWidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireWidthTextBox.Location = new System.Drawing.Point(148, 22);
            this.tireWidthTextBox.Name = "tireWidthTextBox";
            this.tireWidthTextBox.Size = new System.Drawing.Size(278, 26);
            this.tireWidthTextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(62, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Діаметр:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Висота профілю: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ширина профілю: ";
            // 
            // tireTypeComboBox
            // 
            this.tireTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireTypeComboBox.FormattingEnabled = true;
            this.tireTypeComboBox.Location = new System.Drawing.Point(238, 112);
            this.tireTypeComboBox.Name = "tireTypeComboBox";
            this.tireTypeComboBox.Size = new System.Drawing.Size(204, 28);
            this.tireTypeComboBox.TabIndex = 42;
            // 
            // roadConditionComboBox
            // 
            this.roadConditionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roadConditionComboBox.FormattingEnabled = true;
            this.roadConditionComboBox.Location = new System.Drawing.Point(239, 76);
            this.roadConditionComboBox.Name = "roadConditionComboBox";
            this.roadConditionComboBox.Size = new System.Drawing.Size(203, 28);
            this.roadConditionComboBox.TabIndex = 41;
            // 
            // roadTypeComboBox
            // 
            this.roadTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roadTypeComboBox.FormattingEnabled = true;
            this.roadTypeComboBox.Location = new System.Drawing.Point(238, 42);
            this.roadTypeComboBox.Name = "roadTypeComboBox";
            this.roadTypeComboBox.Size = new System.Drawing.Size(204, 28);
            this.roadTypeComboBox.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Тип автомобільних шин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(72, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Стан покритя доріг:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Швидкість автомобіля (км/ч):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(56, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Маса автомобіля (кг.):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(111, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Покритя доріг:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(124, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Стану гальм:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(162, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Погода:";
            // 
            // weatherComboBox
            // 
            this.weatherComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weatherComboBox.FormattingEnabled = true;
            this.weatherComboBox.Location = new System.Drawing.Point(238, 8);
            this.weatherComboBox.Name = "weatherComboBox";
            this.weatherComboBox.Size = new System.Drawing.Size(204, 28);
            this.weatherComboBox.TabIndex = 32;
            // 
            // BResult
            // 
            this.BResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BResult.Location = new System.Drawing.Point(172, 335);
            this.BResult.Name = "BResult";
            this.BResult.Size = new System.Drawing.Size(139, 34);
            this.BResult.TabIndex = 31;
            this.BResult.Text = "Порахувати";
            this.BResult.UseVisualStyleBackColor = true;
            this.BResult.Click += new System.EventHandler(this.BResult_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(954, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Історія розрахунків";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelInfo
            // 
            this.panelInfo.AutoScroll = true;
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Location = new System.Drawing.Point(7, 7);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(941, 386);
            this.panelInfo.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(3, 10);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(51, 20);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "label8";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BExit);
            this.groupBox2.Controls.Add(this.BResult);
            this.groupBox2.Controls.Add(this.resultLabel);
            this.groupBox2.Location = new System.Drawing.Point(456, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 380);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // FCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCalculator";
            this.Text = "Калькулятор розрахунку гальмівного шляху";
            this.Load += new System.EventHandler(this.FCalculator_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.ComboBox brakesStatecomboBox;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox carWeightTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tireDiameterTextBox;
        private System.Windows.Forms.TextBox tireHeightTextBox;
        private System.Windows.Forms.TextBox tireWidthTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tireTypeComboBox;
        private System.Windows.Forms.ComboBox roadConditionComboBox;
        private System.Windows.Forms.ComboBox roadTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox weatherComboBox;
        private System.Windows.Forms.Button BResult;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}