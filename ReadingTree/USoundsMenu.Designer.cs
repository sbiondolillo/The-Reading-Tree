﻿namespace ReadingTree
{
    partial class USoundsMenu
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnUEJune = new System.Windows.Forms.Button();
            this.btnUECute = new System.Windows.Forms.Button();
            this.btnUE = new System.Windows.Forms.Button();
            this.btnSUE = new System.Windows.Forms.Button();
            this.USoundsPromptLabel = new System.Windows.Forms.Label();
            this.USoundsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(218, 227);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(83, 45);
            this.btnMainMenu.TabIndex = 30;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnUEJune
            // 
            this.btnUEJune.Location = new System.Drawing.Point(261, 149);
            this.btnUEJune.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUEJune.Name = "btnUEJune";
            this.btnUEJune.Size = new System.Drawing.Size(83, 45);
            this.btnUEJune.TabIndex = 29;
            this.btnUEJune.Text = "u-e (June)";
            this.btnUEJune.UseVisualStyleBackColor = true;
            this.btnUEJune.Click += new System.EventHandler(this.btnUEJune_Click);
            // 
            // btnUECute
            // 
            this.btnUECute.Location = new System.Drawing.Point(175, 149);
            this.btnUECute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUECute.Name = "btnUECute";
            this.btnUECute.Size = new System.Drawing.Size(83, 45);
            this.btnUECute.TabIndex = 28;
            this.btnUECute.Text = "u-e (cute)";
            this.btnUECute.UseVisualStyleBackColor = true;
            this.btnUECute.Click += new System.EventHandler(this.btnUECute_Click);
            // 
            // btnUE
            // 
            this.btnUE.Location = new System.Drawing.Point(261, 96);
            this.btnUE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUE.Name = "btnUE";
            this.btnUE.Size = new System.Drawing.Size(83, 45);
            this.btnUE.TabIndex = 27;
            this.btnUE.Text = "ue";
            this.btnUE.UseVisualStyleBackColor = true;
            this.btnUE.Click += new System.EventHandler(this.btnUE_Click);
            // 
            // btnSUE
            // 
            this.btnSUE.Location = new System.Drawing.Point(175, 96);
            this.btnSUE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSUE.Name = "btnSUE";
            this.btnSUE.Size = new System.Drawing.Size(83, 45);
            this.btnSUE.TabIndex = 26;
            this.btnSUE.Text = "sue";
            this.btnSUE.UseVisualStyleBackColor = true;
            this.btnSUE.Click += new System.EventHandler(this.btnSUE_Click);
            // 
            // USoundsPromptLabel
            // 
            this.USoundsPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.USoundsPromptLabel.AutoSize = true;
            this.USoundsPromptLabel.Location = new System.Drawing.Point(155, 57);
            this.USoundsPromptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.USoundsPromptLabel.Name = "USoundsPromptLabel";
            this.USoundsPromptLabel.Size = new System.Drawing.Size(213, 13);
            this.USoundsPromptLabel.TabIndex = 25;
            this.USoundsPromptLabel.Text = "Please select a category below to continue!";
            // 
            // USoundsLabel
            // 
            this.USoundsLabel.AutoSize = true;
            this.USoundsLabel.Location = new System.Drawing.Point(233, 27);
            this.USoundsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.USoundsLabel.Name = "USoundsLabel";
            this.USoundsLabel.Size = new System.Drawing.Size(54, 13);
            this.USoundsLabel.TabIndex = 24;
            this.USoundsLabel.Text = "U Sounds";
            // 
            // USoundsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnUEJune);
            this.Controls.Add(this.btnUECute);
            this.Controls.Add(this.btnUE);
            this.Controls.Add(this.btnSUE);
            this.Controls.Add(this.USoundsPromptLabel);
            this.Controls.Add(this.USoundsLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "USoundsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnUEJune;
        private System.Windows.Forms.Button btnUECute;
        private System.Windows.Forms.Button btnUE;
        private System.Windows.Forms.Button btnSUE;
        private System.Windows.Forms.Label USoundsPromptLabel;
        private System.Windows.Forms.Label USoundsLabel;
    }
}