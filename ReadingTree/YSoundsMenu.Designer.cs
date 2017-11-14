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
            this.SuspendLayout();
            // 
            // YSoundsLabel
            // 
            this.YSoundsLabel.AutoSize = true;
            this.YSoundsLabel.Location = new System.Drawing.Point(350, 46);
            this.YSoundsLabel.Name = "YSoundsLabel";
            this.YSoundsLabel.Size = new System.Drawing.Size(79, 20);
            this.YSoundsLabel.TabIndex = 0;
            this.YSoundsLabel.Text = "Y Sounds";
            // 
            // YSoundsPromptLabel
            // 
            this.YSoundsPromptLabel.AutoSize = true;
            this.YSoundsPromptLabel.Location = new System.Drawing.Point(233, 88);
            this.YSoundsPromptLabel.Name = "YSoundsPromptLabel";
            this.YSoundsPromptLabel.Size = new System.Drawing.Size(313, 20);
            this.YSoundsPromptLabel.TabIndex = 1;
            this.YSoundsPromptLabel.Text = "Please select a category below to conitnue!";
            // 
            // btnYasECandy
            // 
            this.btnYasECandy.Location = new System.Drawing.Point(261, 156);
            this.btnYasECandy.Name = "btnYasECandy";
            this.btnYasECandy.Size = new System.Drawing.Size(125, 70);
            this.btnYasECandy.TabIndex = 2;
            this.btnYasECandy.Text = "y as /E/ (candy)";
            this.btnYasECandy.UseVisualStyleBackColor = true;
            this.btnYasECandy.Click += new System.EventHandler(this.btnYasECandy_Click);
            // 
            // btnYasIMy
            // 
            this.btnYasIMy.Location = new System.Drawing.Point(392, 156);
            this.btnYasIMy.Name = "btnYasIMy";
            this.btnYasIMy.Size = new System.Drawing.Size(125, 70);
            this.btnYasIMy.TabIndex = 3;
            this.btnYasIMy.Text = "y as /I/ (my)";
            this.btnYasIMy.UseVisualStyleBackColor = true;
            this.btnYasIMy.Click += new System.EventHandler(this.btnYasIMy_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(327, 271);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(125, 70);
            this.btnMainMenu.TabIndex = 4;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // YSoundsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnYasIMy);
            this.Controls.Add(this.btnYasECandy);
            this.Controls.Add(this.YSoundsPromptLabel);
            this.Controls.Add(this.YSoundsLabel);
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
    }
}