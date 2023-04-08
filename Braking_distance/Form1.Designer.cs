namespace Braking_distance
{
    partial class FMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.BConnectDB = new System.Windows.Forms.Button();
            this.BBegin = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перед початком роботи з калькулятором потрібно налаштувати підключення до бази да" +
    "них";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BConnectDB
            // 
            this.BConnectDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BConnectDB.Location = new System.Drawing.Point(32, 105);
            this.BConnectDB.Name = "BConnectDB";
            this.BConnectDB.Size = new System.Drawing.Size(141, 57);
            this.BConnectDB.TabIndex = 1;
            this.BConnectDB.Text = "Підключення до БД";
            this.BConnectDB.UseVisualStyleBackColor = true;
            this.BConnectDB.Click += new System.EventHandler(this.BConnectDB_Click);
            // 
            // BBegin
            // 
            this.BBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BBegin.Location = new System.Drawing.Point(179, 105);
            this.BBegin.Name = "BBegin";
            this.BBegin.Size = new System.Drawing.Size(141, 57);
            this.BBegin.TabIndex = 2;
            this.BBegin.Text = "Почати";
            this.BBegin.UseVisualStyleBackColor = true;
            this.BBegin.Click += new System.EventHandler(this.BBegin_Click);
            // 
            // BExit
            // 
            this.BExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BExit.Location = new System.Drawing.Point(326, 105);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(141, 57);
            this.BExit.TabIndex = 3;
            this.BExit.Text = "Вихід";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // FMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 174);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BBegin);
            this.Controls.Add(this.BConnectDB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Налаштування";
            this.Load += new System.EventHandler(this.FMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BConnectDB;
        private System.Windows.Forms.Button BBegin;
        private System.Windows.Forms.Button BExit;
    }
}

