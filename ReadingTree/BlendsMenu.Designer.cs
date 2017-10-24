namespace ReadingTree
{
    partial class BlendsMenu
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
            this.BlendsPromptLabel = new System.Windows.Forms.Label();
            this.Blendslabel = new System.Windows.Forms.Label();
            this.btnPhonics = new System.Windows.Forms.Button();
            this.btnSpellingRules = new System.Windows.Forms.Button();
            this.btnLetterBlends = new System.Windows.Forms.Button();
            this.btnBlendsFinalDigraph = new System.Windows.Forms.Button();
            this.btnBlendsInitial = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BlendsPromptLabel
            // 
            this.BlendsPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlendsPromptLabel.AutoSize = true;
            this.BlendsPromptLabel.Location = new System.Drawing.Point(233, 93);
            this.BlendsPromptLabel.Name = "BlendsPromptLabel";
            this.BlendsPromptLabel.Size = new System.Drawing.Size(313, 20);
            this.BlendsPromptLabel.TabIndex = 4;
            this.BlendsPromptLabel.Text = "Please select a category below to continue!";
            // 
            // Blendslabel
            // 
            this.Blendslabel.AutoSize = true;
            this.Blendslabel.Location = new System.Drawing.Point(360, 46);
            this.Blendslabel.Name = "Blendslabel";
            this.Blendslabel.Size = new System.Drawing.Size(58, 20);
            this.Blendslabel.TabIndex = 3;
            this.Blendslabel.Text = "Blends";
            // 
            // btnPhonics
            // 
            this.btnPhonics.Location = new System.Drawing.Point(392, 223);
            this.btnPhonics.Name = "btnPhonics";
            this.btnPhonics.Size = new System.Drawing.Size(125, 70);
            this.btnPhonics.TabIndex = 23;
            this.btnPhonics.Text = "Phonics";
            this.btnPhonics.UseVisualStyleBackColor = true;
            this.btnPhonics.Click += new System.EventHandler(this.btnPhonics_Click);
            // 
            // btnSpellingRules
            // 
            this.btnSpellingRules.Location = new System.Drawing.Point(261, 223);
            this.btnSpellingRules.Name = "btnSpellingRules";
            this.btnSpellingRules.Size = new System.Drawing.Size(125, 70);
            this.btnSpellingRules.TabIndex = 22;
            this.btnSpellingRules.Text = "Spelling Rules";
            this.btnSpellingRules.UseVisualStyleBackColor = true;
            this.btnSpellingRules.Click += new System.EventHandler(this.btnSpellingRules_Click);
            // 
            // btnLetterBlends
            // 
            this.btnLetterBlends.Location = new System.Drawing.Point(457, 147);
            this.btnLetterBlends.Name = "btnLetterBlends";
            this.btnLetterBlends.Size = new System.Drawing.Size(125, 70);
            this.btnLetterBlends.TabIndex = 21;
            this.btnLetterBlends.Text = "Letter Blends";
            this.btnLetterBlends.UseVisualStyleBackColor = true;
            this.btnLetterBlends.Click += new System.EventHandler(this.btnLetterBlends_Click);
            // 
            // btnBlendsFinalDigraph
            // 
            this.btnBlendsFinalDigraph.Location = new System.Drawing.Point(326, 147);
            this.btnBlendsFinalDigraph.Name = "btnBlendsFinalDigraph";
            this.btnBlendsFinalDigraph.Size = new System.Drawing.Size(125, 70);
            this.btnBlendsFinalDigraph.TabIndex = 20;
            this.btnBlendsFinalDigraph.Text = "Final, Digraph";
            this.btnBlendsFinalDigraph.UseVisualStyleBackColor = true;
            this.btnBlendsFinalDigraph.Click += new System.EventHandler(this.btnBlendsFinalDigraph_Click);
            // 
            // btnBlendsInitial
            // 
            this.btnBlendsInitial.Location = new System.Drawing.Point(197, 147);
            this.btnBlendsInitial.Name = "btnBlendsInitial";
            this.btnBlendsInitial.Size = new System.Drawing.Size(125, 70);
            this.btnBlendsInitial.TabIndex = 19;
            this.btnBlendsInitial.Text = "Initial";
            this.btnBlendsInitial.UseVisualStyleBackColor = true;
            this.btnBlendsInitial.Click += new System.EventHandler(this.btnBlendsInitial_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(326, 311);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(125, 70);
            this.btnMainMenu.TabIndex = 24;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // BlendsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnPhonics);
            this.Controls.Add(this.btnSpellingRules);
            this.Controls.Add(this.btnLetterBlends);
            this.Controls.Add(this.btnBlendsFinalDigraph);
            this.Controls.Add(this.btnBlendsInitial);
            this.Controls.Add(this.BlendsPromptLabel);
            this.Controls.Add(this.Blendslabel);
            this.Name = "BlendsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BlendsPromptLabel;
        private System.Windows.Forms.Label Blendslabel;
        private System.Windows.Forms.Button btnPhonics;
        private System.Windows.Forms.Button btnSpellingRules;
        private System.Windows.Forms.Button btnLetterBlends;
        private System.Windows.Forms.Button btnBlendsFinalDigraph;
        private System.Windows.Forms.Button btnBlendsInitial;
        private System.Windows.Forms.Button btnMainMenu;
    }
}