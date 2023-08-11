namespace AsyncTask
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
            this.btnCalistir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnCalistirASYNC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalistir
            // 
            this.btnCalistir.Location = new System.Drawing.Point(12, 43);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(137, 86);
            this.btnCalistir.TabIndex = 0;
            this.btnCalistir.Text = "Çalıştır";
            this.btnCalistir.UseVisualStyleBackColor = true;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(12, 264);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(137, 23);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(182, 43);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(223, 244);
            this.listBox.TabIndex = 2;
            // 
            // btnCalistirASYNC
            // 
            this.btnCalistirASYNC.Location = new System.Drawing.Point(12, 148);
            this.btnCalistirASYNC.Name = "btnCalistirASYNC";
            this.btnCalistirASYNC.Size = new System.Drawing.Size(137, 86);
            this.btnCalistirASYNC.TabIndex = 3;
            this.btnCalistirASYNC.Text = "Çalıştır-ASYNC";
            this.btnCalistirASYNC.UseVisualStyleBackColor = true;
            this.btnCalistirASYNC.Click += new System.EventHandler(this.btnCalistirASYNC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 323);
            this.Controls.Add(this.btnCalistirASYNC);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnCalistir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCalistir;
        private Button btnTemizle;
        private ListBox listBox;
        private Button btnCalistirASYNC;
    }
}