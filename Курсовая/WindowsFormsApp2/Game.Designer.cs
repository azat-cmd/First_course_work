
namespace WindowsFormsApp2
{
    partial class Game_form
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
            this.components = new System.ComponentModel.Container();
            this.Chronos = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pause_panel = new System.Windows.Forms.Panel();
            this.return_to_start_button = new System.Windows.Forms.Button();
            this.game_over_button = new System.Windows.Forms.Button();
            this.Continue_button = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.Pause_button = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Pause_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chronos
            // 
            this.Chronos.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.Pause_panel);
            this.panel1.Location = new System.Drawing.Point(7, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 419);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mcl);
            // 
            // Pause_panel
            // 
            this.Pause_panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pause_panel.Controls.Add(this.return_to_start_button);
            this.Pause_panel.Controls.Add(this.game_over_button);
            this.Pause_panel.Controls.Add(this.Continue_button);
            this.Pause_panel.Location = new System.Drawing.Point(166, 43);
            this.Pause_panel.Name = "Pause_panel";
            this.Pause_panel.Size = new System.Drawing.Size(326, 274);
            this.Pause_panel.TabIndex = 0;
            this.Pause_panel.Visible = false;
            // 
            // return_to_start_button
            // 
            this.return_to_start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_to_start_button.Location = new System.Drawing.Point(90, 161);
            this.return_to_start_button.Name = "return_to_start_button";
            this.return_to_start_button.Size = new System.Drawing.Size(146, 32);
            this.return_to_start_button.TabIndex = 5;
            this.return_to_start_button.Text = "Начальное окно";
            this.return_to_start_button.UseVisualStyleBackColor = true;
            this.return_to_start_button.Visible = false;
            this.return_to_start_button.Click += new System.EventHandler(this.return_to_start_button_Click);
            // 
            // game_over_button
            // 
            this.game_over_button.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.game_over_button.Location = new System.Drawing.Point(90, 120);
            this.game_over_button.Name = "game_over_button";
            this.game_over_button.Size = new System.Drawing.Size(146, 35);
            this.game_over_button.TabIndex = 4;
            this.game_over_button.Text = "Закончить игру";
            this.game_over_button.UseVisualStyleBackColor = true;
            this.game_over_button.Visible = false;
            this.game_over_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Continue_button
            // 
            this.Continue_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Continue_button.Location = new System.Drawing.Point(90, 82);
            this.Continue_button.Name = "Continue_button";
            this.Continue_button.Size = new System.Drawing.Size(146, 32);
            this.Continue_button.TabIndex = 3;
            this.Continue_button.Text = "Продолжить";
            this.Continue_button.UseVisualStyleBackColor = true;
            this.Continue_button.Visible = false;
            this.Continue_button.Click += new System.EventHandler(this.Continue_button_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(635, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(13, 13);
            this.Score.TabIndex = 1;
            this.Score.Text = "0";
            this.Score.Click += new System.EventHandler(this.label3_Click);
            // 
            // Pause_button
            // 
            this.Pause_button.Location = new System.Drawing.Point(22, 6);
            this.Pause_button.Name = "Pause_button";
            this.Pause_button.Size = new System.Drawing.Size(49, 20);
            this.Pause_button.TabIndex = 2;
            this.Pause_button.Text = "Pause";
            this.Pause_button.UseVisualStyleBackColor = true;
            this.Pause_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(378, 6);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(13, 13);
            this.time_label.TabIndex = 3;
            this.time_label.Text = "0";
            // 
            // Game_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.Pause_button);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Game_form";
            this.Text = "Game";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.Pause_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Chronos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button Pause_button;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Panel Pause_panel;
        private System.Windows.Forms.Button return_to_start_button;
        private System.Windows.Forms.Button game_over_button;
        private System.Windows.Forms.Button Continue_button;
    }
}

