namespace ReadingTree
{
    partial class YSoundsMenu
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
            this.YSoundsLabel = new System.Windows.Forms.Label();
            this.YSoundsPromptLabel = new System.Windows.Forms.Label();
            this.btnYasECandy = new System.Windows.Forms.Button();
            this.btnYasIMy = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YSoundsLabel
            // 
            this.YSoundsLabel.AutoSize = true;
            this.YSoundsLabel.Location = new System.Drawing.Point(233, 30);
            this.YSoundsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YSoundsLabel.Name = "YSoundsLabel";
            this.YSoundsLabel.Size = new System.Drawing.Size(53, 13);
            this.YSoundsLabel.TabIndex = 0;
            this.YSoundsLabel.Text = "Y Sounds";
            // 
            // YSoundsPromptLabel
            // 
            this.YSoundsPromptLabel.AutoSize = true;
            this.YSoundsPromptLabel.Location = new System.Drawing.Point(155, 57);
            this.YSoundsPromptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YSoundsPromptLabel.Name = "YSoundsPromptLabel";
            this.YSoundsPromptLabel.Size = new System.Drawing.Size(213, 13);
            this.YSoundsPromptLabel.TabIndex = 1;
            this.YSoundsPromptLabel.Text = "Please select a category below to conitnue!";
            // 
            // btnYasECandy
            // 
            this.btnYasECandy.Location = new System.Drawing.Point(174, 101);
            this.btnYasECandy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYasECandy.Name = "btnYasECandy";
            this.btnYasECandy.Size = new System.Drawing.Size(83, 45);
            this.btnYasECandy.TabIndex = 2;
            this.btnYasECandy.Text = "y as /E/ (candy)";
            this.btnYasECandy.UseVisualStyleBackColor = true;
            this.btnYasECandy.Click += new System.EventHandler(this.btnYasECandy_Click);
            // 
            // btnYasIMy
            // 
            this.btnYasIMy.Location = new System.Drawing.Point(261, 101);
            this.btnYasIMy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYasIMy.Name = "btnYasIMy";
            this.btnYasIMy.Size = new System.Drawing.Size(83, 45);
            this.btnYasIMy.TabIndex = 3;
            this.btnYasIMy.Text = "y as /I/ (my)";
            this.btnYasIMy.UseVisualStyleBackColor = true;
            this.btnYasIMy.Click += new System.EventHandler(this.btnYasIMy_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(338, 310);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(83, 33);
            this.btnMainMenu.TabIndex = 4;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(425, 310);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(83, 33);
            this.btn_back.TabIndex = 21;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // YSoundsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnYasIMy);
            this.Controls.Add(this.btnYasECandy);
            this.Controls.Add(this.YSoundsPromptLabel);
            this.Controls.Add(this.YSoundsLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "YSoundsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YSoundsLabel;
        private System.Windows.Forms.Label YSoundsPromptLabel;
        private System.Windows.Forms.Button btnYasECandy;
        private System.Windows.Forms.Button btnYasIMy;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btn_back;
    }
}