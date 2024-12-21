namespace IT_LABRAB_9
{
    partial class AddEnterprise
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
            this.button1 = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(29, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(429, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить предприятие";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(254, 18);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(204, 26);
            this.Code.TabIndex = 1;
            this.Code.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Код предприятия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название предприятия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Адрес предприятия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Телефон предприятия";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(254, 64);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(204, 26);
            this.Name.TabIndex = 6;
            this.Name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(254, 110);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(204, 26);
            this.Adress.TabIndex = 7;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(254, 153);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(204, 26);
            this.Phone.TabIndex = 8;
            // 
            // AddEnterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 273);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.button1);
            this.Text = "Добавление предприятия";
            this.Load += new System.EventHandler(this.AddEnterprise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Code;
        public System.Windows.Forms.TextBox Name;
        public System.Windows.Forms.TextBox Adress;
        public System.Windows.Forms.TextBox Phone;
        public System.Windows.Forms.Button button1;
    }
}