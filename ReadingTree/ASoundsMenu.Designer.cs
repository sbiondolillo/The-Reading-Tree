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
            this.btnAYSounds = new System.Windows.Forms.Button();
            this.btnAUSounds = new System.Windows.Forms.Button();
            this.btnAISounds = new System.Windows.Forms.Button();
            this.btnAESounds = new System.Windows.Forms.Button();
            this.ASoundsPromptLabel = new System.Windows.Forms.Label();
            this.ASoundsLabel = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAYSounds
            // 
            this.btnAYSounds.Location = new System.Drawing.Point(392, 223);
            this.btnAYSounds.Name = "btnAYSounds";
            this.btnAYSounds.Size = new System.Drawing.Size(124, 69);
            this.btnAYSounds.TabIndex = 22;
            this.btnAYSounds.Text = "A-Y Sounds";
            this.btnAYSounds.UseVisualStyleBackColor = true;
            this.btnAYSounds.Click += new System.EventHandler(this.btnAYSounds_Click);
            // 
            // btnAUSounds
            // 
            this.btnAUSounds.Location = new System.Drawing.Point(262, 223);
            this.btnAUSounds.Name = "btnAUSounds";
            this.btnAUSounds.Size = new System.Drawing.Size(124, 69);
            this.btnAUSounds.TabIndex = 21;
            this.btnAUSounds.Text = "A-U Sounds";
            this.btnAUSounds.UseVisualStyleBackColor = true;
            this.btnAUSounds.Click += new System.EventHandler(this.btnAUSounds_Click);
            // 
            // btnAISounds
            // 
            this.btnAISounds.Location = new System.Drawing.Point(392, 140);
            this.btnAISounds.Name = "btnAISounds";
            this.btnAISounds.Size = new System.Drawing.Size(124, 69);
            this.btnAISounds.TabIndex = 20;
            this.btnAISounds.Text = "A-I Sounds";
            this.btnAISounds.UseVisualStyleBackColor = true;
            this.btnAISounds.Click += new System.EventHandler(this.btnAISounds_Click);
            // 
            // btnAESounds
            // 
            this.btnAESounds.Location = new System.Drawing.Point(262, 140);
            this.btnAESounds.Name = "btnAESounds";
            this.btnAESounds.Size = new System.Drawing.Size(124, 69);
            this.btnAESounds.TabIndex = 19;
            this.btnAESounds.Text = "A-E Sounds";
            this.btnAESounds.UseVisualStyleBackColor = true;
            this.btnAESounds.Click += new System.EventHandler(this.btnAESounds_Click);
            // 
            // ASoundsPromptLabel
            // 
            this.ASoundsPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ASoundsPromptLabel.AutoSize = true;
            this.ASoundsPromptLabel.Location = new System.Drawing.Point(232, 82);
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
            this.btnMainMenu.Location = new System.Drawing.Point(507, 477);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(124, 51);
            this.btnMainMenu.TabIndex = 23;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(638, 477);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(124, 51);
            this.btn_back.TabIndex = 24;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ASoundsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 545);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAYSounds);
            this.Controls.Add(this.btnAUSounds);
            this.Controls.Add(this.btnAISounds);
            this.Controls.Add(this.btnAESounds);
            this.Controls.Add(this.ASoundsPromptLabel);
            this.Controls.Add(this.ASoundsLabel);
            this.MaximizeBox = false;
            this.Name = "ASoundsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ASoundsMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAYSounds;
        private System.Windows.Forms.Button btnAUSounds;
        private System.Windows.Forms.Button btnAISounds;
        private System.Windows.Forms.Button btnAESounds;
        private System.Windows.Forms.Label ASoundsPromptLabel;
        private System.Windows.Forms.Label ASoundsLabel;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btn_back;
    }
}