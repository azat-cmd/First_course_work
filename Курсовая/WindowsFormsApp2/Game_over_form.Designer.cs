namespace WindowsFormsApp2
{
    partial class Final_form
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
            this.rezult_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваш результат:";
            // 
            // rezult_label
            // 
            this.rezult_label.AutoSize = true;
            this.rezult_label.Location = new System.Drawing.Point(210, 68);
            this.rezult_label.Name = "rezult_label";
            this.rezult_label.Size = new System.Drawing.Size(13, 13);
            this.rezult_label.TabIndex = 1;
            this.rezult_label.Text = "0";
            // 
            // Final_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 266);
            this.Controls.Add(this.rezult_label);
            this.Controls.Add(this.label1);
            this.Name = "Final_form";
            this.Text = "Final";
            this.Load += new System.EventHandler(this.Final_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rezult_label;
    }
}