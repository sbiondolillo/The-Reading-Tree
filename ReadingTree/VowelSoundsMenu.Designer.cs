namespace ReadingTree
{
    partial class VowelSoundsMenu
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
            this.VowelSoundslabel = new System.Windows.Forms.Label();
            this.VowelSoundsPromptLabel = new System.Windows.Forms.Label();
            this.btnYSounds = new System.Windows.Forms.Button();
            this.btnUSounds = new System.Windows.Forms.Button();
            this.btnOSounds = new System.Windows.Forms.Button();
            this.btnISounds = new System.Windows.Forms.Button();
            this.btnESounds = new System.Windows.Forms.Button();
            this.btnASounds = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VowelSoundslabel
            // 
            this.VowelSoundslabel.AutoSize = true;
            this.VowelSoundslabel.Location = new System.Drawing.Point(334, 28);
            this.VowelSoundslabel.Name = "VowelSoundslabel";
            this.VowelSoundslabel.Size = new System.Drawing.Size(111, 20);
            this.VowelSoundslabel.TabIndex = 0;
            this.VowelSoundslabel.Text = "Vowel Sounds";
            this.VowelSoundslabel.Click += new System.EventHandler(this.VoweSoundslabel_Click);
            // 
            // VowelSoundsPromptLabel
            // 
            this.VowelSoundsPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VowelSoundsPromptLabel.AutoSize = true;
            this.VowelSoundsPromptLabel.Location = new System.Drawing.Point(233, 75);
            this.VowelSoundsPromptLabel.Name = "VowelSoundsPromptLabel";
            this.VowelSoundsPromptLabel.Size = new System.Drawing.Size(313, 20);
            this.VowelSoundsPromptLabel.TabIndex = 2;
            this.VowelSoundsPromptLabel.Text = "Please select a category below to continue!";
            this.VowelSoundsPromptLabel.Click += new System.EventHandler(this.VowelSoundsPromptLabel_Click);
            // 
            // btnYSounds
            // 
            this.btnYSounds.Location = new System.Drawing.Point(391, 306);
            this.btnYSounds.Name = "btnYSounds";
            this.btnYSounds.Size = new System.Drawing.Size(125, 70);
            this.btnYSounds.TabIndex = 18;
            this.btnYSounds.Text = "Y Sounds";
            this.btnYSounds.UseVisualStyleBackColor = true;
            this.btnYSounds.Click += new System.EventHandler(this.btnYSounds_Click);
            // 
            // btnUSounds
            // 
            this.btnUSounds.Location = new System.Drawing.Point(262, 306);
            this.btnUSounds.Name = "btnUSounds";
            this.btnUSounds.Size = new System.Drawing.Size(125, 70);
            this.btnUSounds.TabIndex = 17;
            this.btnUSounds.Text = "U Sounds";
            this.btnUSounds.UseVisualStyleBackColor = true;
            this.btnUSounds.Click += new System.EventHandler(this.btnUSounds_Click);
            // 
            // btnOSounds
            // 
            this.btnOSounds.Location = new System.Drawing.Point(391, 217);
            this.btnOSounds.Name = "btnOSounds";
            this.btnOSounds.Size = new System.Drawing.Size(125, 70);
            this.btnOSounds.TabIndex = 16;
            this.btnOSounds.Text = "O Sounds";
            this.btnOSounds.UseVisualStyleBackColor = true;
            this.btnOSounds.Click += new System.EventHandler(this.btnOSounds_Click);
            // 
            // btnISounds
            // 
            this.btnISounds.Location = new System.Drawing.Point(262, 217);
            this.btnISounds.Name = "btnISounds";
            this.btnISounds.Size = new System.Drawing.Size(125, 70);
            this.btnISounds.TabIndex = 15;
            this.btnISounds.Text = "I Sounds";
            this.btnISounds.UseVisualStyleBackColor = true;
            this.btnISounds.Click += new System.EventHandler(this.btnISounds_Click);
            // 
            // btnESounds
            // 
            this.btnESounds.Location = new System.Drawing.Point(391, 134);
            this.btnESounds.Name = "btnESounds";
            this.btnESounds.Size = new System.Drawing.Size(125, 70);
            this.btnESounds.TabIndex = 14;
            this.btnESounds.Text = "E Sounds";
            this.btnESounds.UseVisualStyleBackColor = true;
            this.btnESounds.Click += new System.EventHandler(this.btnESounds_Click);
            // 
            // btnASounds
            // 
            this.btnASounds.Location = new System.Drawing.Point(262, 134);
            this.btnASounds.Name = "btnASounds";
            this.btnASounds.Size = new System.Drawing.Size(125, 70);
            this.btnASounds.TabIndex = 13;
            this.btnASounds.Text = "A Sounds";
            this.btnASounds.UseVisualStyleBackColor = true;
            this.btnASounds.Click += new System.EventHandler(this.btnASounds_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(327, 425);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(125, 70);
            this.btnMainMenu.TabIndex = 19;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // VowelSoundsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnYSounds);
            this.Controls.Add(this.btnUSounds);
            this.Controls.Add(this.btnOSounds);
            this.Controls.Add(this.btnISounds);
            this.Controls.Add(this.btnESounds);
            this.Controls.Add(this.btnASounds);
            this.Controls.Add(this.VowelSoundsPromptLabel);
            this.Controls.Add(this.VowelSoundslabel);
            this.Name = "VowelSoundsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VowelSoundslabel;
        private System.Windows.Forms.Label VowelSoundsPromptLabel;
        private System.Windows.Forms.Button btnYSounds;
        private System.Windows.Forms.Button btnUSounds;
        private System.Windows.Forms.Button btnOSounds;
        private System.Windows.Forms.Button btnISounds;
        private System.Windows.Forms.Button btnESounds;
        private System.Windows.Forms.Button btnASounds;
        private System.Windows.Forms.Button btnMainMenu;
    }
}