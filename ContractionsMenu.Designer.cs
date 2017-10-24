﻿namespace ReadingTree
{
    partial class ContractionsMenu
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
            this.btnTch = new System.Windows.Forms.Button();
            this.btnContractionsNonPhonetic = new System.Windows.Forms.Button();
            this.buttonContractionsPhonetic = new System.Windows.Forms.Button();
            this.DigraphPromptLabel = new System.Windows.Forms.Label();
            this.DigraphLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTch
            // 
            this.btnTch.Location = new System.Drawing.Point(114, 144);
            this.btnTch.Margin = new System.Windows.Forms.Padding(2);
            this.btnTch.Name = "btnTch";
            this.btnTch.Size = new System.Drawing.Size(83, 45);
            this.btnTch.TabIndex = 19;
            this.btnTch.Text = "Contractions (Omit?)";
            this.btnTch.UseVisualStyleBackColor = true;
            // 
            // btnContractionsNonPhonetic
            // 
            this.btnContractionsNonPhonetic.Location = new System.Drawing.Point(201, 144);
            this.btnContractionsNonPhonetic.Margin = new System.Windows.Forms.Padding(2);
            this.btnContractionsNonPhonetic.Name = "btnContractionsNonPhonetic";
            this.btnContractionsNonPhonetic.Size = new System.Drawing.Size(83, 45);
            this.btnContractionsNonPhonetic.TabIndex = 20;
            this.btnContractionsNonPhonetic.Text = "Contractions, non-phonetic";
            this.btnContractionsNonPhonetic.UseVisualStyleBackColor = true;
            // 
            // buttonContractionsPhonetic
            // 
            this.buttonContractionsPhonetic.Location = new System.Drawing.Point(288, 144);
            this.buttonContractionsPhonetic.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContractionsPhonetic.Name = "buttonContractionsPhonetic";
            this.buttonContractionsPhonetic.Size = new System.Drawing.Size(83, 45);
            this.buttonContractionsPhonetic.TabIndex = 21;
            this.buttonContractionsPhonetic.Text = "Contractions, phonetic";
            this.buttonContractionsPhonetic.UseVisualStyleBackColor = true;
            // 
            // DigraphPromptLabel
            // 
            this.DigraphPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DigraphPromptLabel.AutoSize = true;
            this.DigraphPromptLabel.Location = new System.Drawing.Point(143, 90);
            this.DigraphPromptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DigraphPromptLabel.Name = "DigraphPromptLabel";
            this.DigraphPromptLabel.Size = new System.Drawing.Size(213, 13);
            this.DigraphPromptLabel.TabIndex = 24;
            this.DigraphPromptLabel.Text = "Please select a category below to continue!";
            // 
            // DigraphLabel
            // 
            this.DigraphLabel.AutoSize = true;
            this.DigraphLabel.Location = new System.Drawing.Point(207, 53);
            this.DigraphLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DigraphLabel.Name = "DigraphLabel";
            this.DigraphLabel.Size = new System.Drawing.Size(69, 13);
            this.DigraphLabel.TabIndex = 23;
            this.DigraphLabel.Text = "Contractions ";
            // 
            // ContractionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.DigraphPromptLabel);
            this.Controls.Add(this.DigraphLabel);
            this.Controls.Add(this.buttonContractionsPhonetic);
            this.Controls.Add(this.btnContractionsNonPhonetic);
            this.Controls.Add(this.btnTch);
            this.Name = "ContractionsMenu";
            this.Text = "ContractionsMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTch;
        private System.Windows.Forms.Button btnContractionsNonPhonetic;
        private System.Windows.Forms.Button buttonContractionsPhonetic;
        private System.Windows.Forms.Label DigraphPromptLabel;
        private System.Windows.Forms.Label DigraphLabel;
    }
}