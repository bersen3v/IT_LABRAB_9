namespace IT_LABRAB_9
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.IsStandart = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.TextBox();
            this.AnnualProductionVolume = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Является ли типовым";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Примечание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Годовой объем выпуска";
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(231, 21);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(201, 26);
            this.Code.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(231, 68);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(201, 26);
            this.Name.TabIndex = 6;
            // 
            // IsStandart
            // 
            this.IsStandart.Location = new System.Drawing.Point(231, 119);
            this.IsStandart.Name = "IsStandart";
            this.IsStandart.Size = new System.Drawing.Size(201, 26);
            this.IsStandart.TabIndex = 7;
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(231, 174);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(201, 26);
            this.Note.TabIndex = 8;
            // 
            // AnnualProductionVolume
            // 
            this.AnnualProductionVolume.Location = new System.Drawing.Point(231, 230);
            this.AnnualProductionVolume.Name = "AnnualProductionVolume";
            this.AnnualProductionVolume.Size = new System.Drawing.Size(201, 26);
            this.AnnualProductionVolume.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(16, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(416, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить изделие";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnnualProductionVolume);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.IsStandart);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Text = "Добавление изделия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Code;
        public System.Windows.Forms.TextBox Name;
        public System.Windows.Forms.TextBox IsStandart;
        public System.Windows.Forms.TextBox Note;
        public System.Windows.Forms.TextBox AnnualProductionVolume;
        public System.Windows.Forms.Button button1;
    }
}