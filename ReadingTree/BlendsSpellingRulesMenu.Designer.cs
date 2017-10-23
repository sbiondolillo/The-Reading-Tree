namespace ReadingTree
{
    partial class BlendsSpellingRulesMenu
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
            this.btn211SpellingRule = new System.Windows.Forms.Button();
            this.btn111SpellingRule = new System.Windows.Forms.Button();
            this.BlendsSpellingRulesPromptlabel = new System.Windows.Forms.Label();
            this.BlendsSpellingRuleslabel = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn211SpellingRule
            // 
            this.btn211SpellingRule.Location = new System.Drawing.Point(391, 152);
            this.btn211SpellingRule.Name = "btn211SpellingRule";
            this.btn211SpellingRule.Size = new System.Drawing.Size(125, 70);
            this.btn211SpellingRule.TabIndex = 24;
            this.btn211SpellingRule.Text = "2-1-1 Spelling Rule";
            this.btn211SpellingRule.UseVisualStyleBackColor = true;
            this.btn211SpellingRule.Click += new System.EventHandler(this.btn211SpellingRule_Click);
            // 
            // btn111SpellingRule
            // 
            this.btn111SpellingRule.Location = new System.Drawing.Point(262, 152);
            this.btn111SpellingRule.Name = "btn111SpellingRule";
            this.btn111SpellingRule.Size = new System.Drawing.Size(125, 70);
            this.btn111SpellingRule.TabIndex = 23;
            this.btn111SpellingRule.Text = "1-1-1 Spelling Rule";
            this.btn111SpellingRule.UseVisualStyleBackColor = true;
            this.btn111SpellingRule.Click += new System.EventHandler(this.btn111SpellingRule_Click);
            // 
            // BlendsSpellingRulesPromptlabel
            // 
            this.BlendsSpellingRulesPromptlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlendsSpellingRulesPromptlabel.AutoSize = true;
            this.BlendsSpellingRulesPromptlabel.Location = new System.Drawing.Point(233, 94);
            this.BlendsSpellingRulesPromptlabel.Name = "BlendsSpellingRulesPromptlabel";
            this.BlendsSpellingRulesPromptlabel.Size = new System.Drawing.Size(313, 20);
            this.BlendsSpellingRulesPromptlabel.TabIndex = 22;
            this.BlendsSpellingRulesPromptlabel.Text = "Please select a category below to continue!";
            // 
            // BlendsSpellingRuleslabel
            // 
            this.BlendsSpellingRuleslabel.AutoSize = true;
            this.BlendsSpellingRuleslabel.Location = new System.Drawing.Point(306, 47);
            this.BlendsSpellingRuleslabel.Name = "BlendsSpellingRuleslabel";
            this.BlendsSpellingRuleslabel.Size = new System.Drawing.Size(167, 20);
            this.BlendsSpellingRuleslabel.TabIndex = 21;
            this.BlendsSpellingRuleslabel.Text = "Blends, Spelling Rules";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(327, 254);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(125, 70);
            this.btnMainMenu.TabIndex = 25;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // BlendsSpellingRulesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btn211SpellingRule);
            this.Controls.Add(this.btn111SpellingRule);
            this.Controls.Add(this.BlendsSpellingRulesPromptlabel);
            this.Controls.Add(this.BlendsSpellingRuleslabel);
            this.Name = "BlendsSpellingRulesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn211SpellingRule;
        private System.Windows.Forms.Button btn111SpellingRule;
        private System.Windows.Forms.Label BlendsSpellingRulesPromptlabel;
        private System.Windows.Forms.Label BlendsSpellingRuleslabel;
        private System.Windows.Forms.Button btnMainMenu;
    }
}