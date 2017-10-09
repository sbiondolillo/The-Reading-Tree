namespace ReadingTree
{
    partial class ASoundsMenu
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
            this.btnAY = new System.Windows.Forms.Button();
            this.btnAU = new System.Windows.Forms.Button();
            this.btnAI = new System.Windows.Forms.Button();
            this.btnAE = new System.Windows.Forms.Button();
            this.ASoundsPromptLabel = new System.Windows.Forms.Label();
            this.ASoundsLabel = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAY
            // 
            this.btnAY.Location = new System.Drawing.Point(391, 223);
            this.btnAY.Name = "btnAY";
            this.btnAY.Size = new System.Drawing.Size(125, 70);
            this.btnAY.TabIndex = 22;
            this.btnAY.Text = "ay";
            this.btnAY.UseVisualStyleBackColor = true;
            this.btnAY.Click += new System.EventHandler(this.btnAYSounds_Click);
            // 
            // btnAU
            // 
            this.btnAU.Location = new System.Drawing.Point(262, 223);
            this.btnAU.Name = "btnAU";
            this.btnAU.Size = new System.Drawing.Size(125, 70);
            this.btnAU.TabIndex = 21;
            this.btnAU.Text = "au";
            this.btnAU.UseVisualStyleBackColor = true;
            this.btnAU.Click += new System.EventHandler(this.btnAUSounds_Click);
            // 
            // btnAI
            // 
            this.btnAI.Location = new System.Drawing.Point(391, 140);
            this.btnAI.Name = "btnAI";
            this.btnAI.Size = new System.Drawing.Size(125, 70);
            this.btnAI.TabIndex = 20;
            this.btnAI.Text = "ai";
            this.btnAI.UseVisualStyleBackColor = true;
            this.btnAI.Click += new System.EventHandler(this.btnAISounds_Click);
            // 
            // btnAE
            // 
            this.btnAE.Location = new System.Drawing.Point(262, 140);
            this.btnAE.Name = "btnAE";
            this.btnAE.Size = new System.Drawing.Size(125, 70);
            this.btnAE.TabIndex = 19;
            this.btnAE.Text = "a-e";
            this.btnAE.UseVisualStyleBackColor = true;
            this.btnAE.Click += new System.EventHandler(this.btnAESounds_Click);
            // 
            // ASoundsPromptLabel
            // 
            this.ASoundsPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ASoundsPromptLabel.AutoSize = true;
            this.ASoundsPromptLabel.Location = new System.Drawing.Point(233, 81);
            this.ASoundsPromptLabel.Name = "ASoundsPromptLabel";
            this.ASoundsPromptLabel.Size = new System.Drawing.Size(313, 20);
            this.ASoundsPromptLabel.TabIndex = 18;
            this.ASoundsPromptLabel.Text = "Please select a category below to continue!";
            // 
            // ASoundsLabel
            // 
            this.ASoundsLabel.AutoSize = true;
            this.ASoundsLabel.Location = new System.Drawing.Point(350, 34);
            this.ASoundsLabel.Name = "ASoundsLabel";
            this.ASoundsLabel.Size = new System.Drawing.Size(79, 20);
            this.ASoundsLabel.TabIndex = 17;
            this.ASoundsLabel.Text = "A Sounds";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(327, 342);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(125, 70);
            this.btnMainMenu.TabIndex = 23;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // ASoundsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAY);
            this.Controls.Add(this.btnAU);
            this.Controls.Add(this.btnAI);
            this.Controls.Add(this.btnAE);
            this.Controls.Add(this.ASoundsPromptLabel);
            this.Controls.Add(this.ASoundsLabel);
            this.Name = "ASoundsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAY;
        private System.Windows.Forms.Button btnAU;
        private System.Windows.Forms.Button btnAI;
        private System.Windows.Forms.Button btnAE;
        private System.Windows.Forms.Label ASoundsPromptLabel;
        private System.Windows.Forms.Label ASoundsLabel;
        private System.Windows.Forms.Button btnMainMenu;
    }
}