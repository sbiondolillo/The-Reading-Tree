namespace ReadingTree
{
    partial class PossessiveNounMenu
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
            this.PNPromptLabel = new System.Windows.Forms.Label();
            this.PNLabel = new System.Windows.Forms.Label();
            this.btnPossessivesSingular = new System.Windows.Forms.Button();
            this.buttonPossessivesPlural = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PNPromptLabel
            // 
            this.PNPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNPromptLabel.AutoSize = true;
            this.PNPromptLabel.Location = new System.Drawing.Point(233, 85);
            this.PNPromptLabel.Name = "PNPromptLabel";
            this.PNPromptLabel.Size = new System.Drawing.Size(313, 20);
            this.PNPromptLabel.TabIndex = 24;
            this.PNPromptLabel.Text = "Please select a category below to continue!";
            // 
            // PNLabel
            // 
            this.PNLabel.AutoSize = true;
            this.PNLabel.Location = new System.Drawing.Point(324, 46);
            this.PNLabel.Name = "PNLabel";
            this.PNLabel.Size = new System.Drawing.Size(130, 20);
            this.PNLabel.TabIndex = 23;
            this.PNLabel.Text = "Possessive Noun";
            // 
            // btnPossessivesSingular
            // 
            this.btnPossessivesSingular.Location = new System.Drawing.Point(393, 163);
            this.btnPossessivesSingular.Name = "btnPossessivesSingular";
            this.btnPossessivesSingular.Size = new System.Drawing.Size(124, 69);
            this.btnPossessivesSingular.TabIndex = 25;
            this.btnPossessivesSingular.Text = "Possessives, singular";
            this.btnPossessivesSingular.UseVisualStyleBackColor = true;
            // 
            // buttonPossessivesPlural
            // 
            this.buttonPossessivesPlural.Location = new System.Drawing.Point(262, 163);
            this.buttonPossessivesPlural.Name = "buttonPossessivesPlural";
            this.buttonPossessivesPlural.Size = new System.Drawing.Size(124, 69);
            this.buttonPossessivesPlural.TabIndex = 26;
            this.buttonPossessivesPlural.Text = "Possessives, plural";
            this.buttonPossessivesPlural.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(327, 268);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(125, 70);
            this.btnMainMenu.TabIndex = 27;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // PossessiveNounMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.buttonPossessivesPlural);
            this.Controls.Add(this.btnPossessivesSingular);
            this.Controls.Add(this.PNPromptLabel);
            this.Controls.Add(this.PNLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PossessiveNounMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.Load += new System.EventHandler(this.PossessiveNounMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PNPromptLabel;
        private System.Windows.Forms.Label PNLabel;
        private System.Windows.Forms.Button btnPossessivesSingular;
        private System.Windows.Forms.Button buttonPossessivesPlural;
        private System.Windows.Forms.Button btnMainMenu;
    }
}