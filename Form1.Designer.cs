namespace Demo1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnStart = new Button();
            button1 = new Button();
            btnInfo = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(196, 82);
            label1.Name = "label1";
            label1.Size = new Size(420, 54);
            label1.TabIndex = 0;
            label1.Text = "HEARTS GAME";
            // 
            // btnStart
            // 
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.ForeColor = Color.Transparent;
            btnStart.Image = Properties.Resources.game_gaming_controller_play_tools_elements_gold_button_icon_262406__1_;
            btnStart.Location = new Point(79, 219);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(81, 77);
            btnStart.TabIndex = 1;
            btnStart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._1486504817_delete_minus_cancel_exit_remove_81373;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(607, 216);
            button1.Name = "button1";
            button1.Size = new Size(74, 77);
            button1.TabIndex = 2;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackgroundImage = Properties.Resources.info_yellow_button_icon_227840;
            btnInfo.BackgroundImageLayout = ImageLayout.Center;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.ForeColor = Color.Transparent;
            btnInfo.Location = new Point(257, 220);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(66, 74);
            btnInfo.TabIndex = 3;
            btnInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.settingstoolswheel_115840_115789;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(427, 220);
            button3.Name = "button3";
            button3.Size = new Size(79, 68);
            button3.TabIndex = 4;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(btnInfo);
            Controls.Add(button1);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hearts Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStart;
        private Button button1;
        private Button btnInfo;
        private Button button3;
    }
}