namespace Demo1
{
    partial class InfoPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoPage));
            textBox1 = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 0, 0);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Gold;
            textBox1.Location = new Point(12, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(2000, 580);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.System;
            btnExit.Location = new Point(406, 671);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(166, 48);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // InfoPage
            // 
            AutoScaleDimensions = new SizeF(26F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1053, 758);
            Controls.Add(btnExit);
            Controls.Add(textBox1);
            Font = new Font("Engravers MT", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.Gold;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(10, 5, 10, 5);
            MaximizeBox = false;
            Name = "InfoPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Info Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnExit;
    }
}