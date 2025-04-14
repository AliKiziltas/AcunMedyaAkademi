namespace AcunmedyaOdev6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUrunleriGoster = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnUrunleriGoster
            // 
            btnUrunleriGoster.Location = new Point(315, 246);
            btnUrunleriGoster.Name = "btnUrunleriGoster";
            btnUrunleriGoster.Size = new Size(148, 29);
            btnUrunleriGoster.TabIndex = 0;
            btnUrunleriGoster.Text = "Ürünleri Göster";
            btnUrunleriGoster.UseVisualStyleBackColor = true;
            btnUrunleriGoster.Click += btnUrunleriGoster_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(137, 106);
            label1.Name = "label1";
            label1.Size = new Size(52, 22);
            label1.TabIndex = 1;
            label1.Text = "klavye";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(359, 106);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 2;
            label2.Text = "Bilgisayar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(630, 108);
            label3.Name = "label3";
            label3.Size = new Size(60, 22);
            label3.TabIndex = 3;
            label3.Text = "Telefon";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUrunleriGoster);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUrunleriGoster;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
