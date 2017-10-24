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
            this.SuspendLayout();
            // 
            // PNPromptLabel
            // 
            this.PNPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNPromptLabel.AutoSize = true;
            this.PNPromptLabel.Location = new System.Drawing.Point(146, 87);
            this.PNPromptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PNPromptLabel.Name = "PNPromptLabel";
            this.PNPromptLabel.Size = new System.Drawing.Size(213, 13);
            this.PNPromptLabel.TabIndex = 24;
            this.PNPromptLabel.Text = "Please select a category below to continue!";
            // 
            // PNLabel
            // 
            this.PNLabel.AutoSize = true;
            this.PNLabel.Location = new System.Drawing.Point(201, 62);
            this.PNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PNLabel.Name = "PNLabel";
            this.PNLabel.Size = new System.Drawing.Size(89, 13);
            this.PNLabel.TabIndex = 23;
            this.PNLabel.Text = "Possessive Noun";
            // 
            // btnPossessivesSingular
            // 
            this.btnPossessivesSingular.Location = new System.Drawing.Point(257, 138);
            this.btnPossessivesSingular.Margin = new System.Windows.Forms.Padding(2);
            this.btnPossessivesSingular.Name = "btnPossessivesSingular";
            this.btnPossessivesSingular.Size = new System.Drawing.Size(83, 45);
            this.btnPossessivesSingular.TabIndex = 25;
            this.btnPossessivesSingular.Text = "Possessives, singular";
            this.btnPossessivesSingular.UseVisualStyleBackColor = true;
            // 
            // buttonPossessivesPlural
            // 
            this.buttonPossessivesPlural.Location = new System.Drawing.Point(170, 138);
            this.buttonPossessivesPlural.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPossessivesPlural.Name = "buttonPossessivesPlural";
            this.buttonPossessivesPlural.Size = new System.Drawing.Size(83, 45);
            this.buttonPossessivesPlural.TabIndex = 26;
            this.buttonPossessivesPlural.Text = "Possessives, plural";
            this.buttonPossessivesPlural.UseVisualStyleBackColor = true;
            // 
            // PossessiveNounMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.buttonPossessivesPlural);
            this.Controls.Add(this.btnPossessivesSingular);
            this.Controls.Add(this.PNPromptLabel);
            this.Controls.Add(this.PNLabel);
            this.Name = "PossessiveNounMenu";
            this.Text = "PossessiveNounMenu";
            this.Load += new System.EventHandler(this.PossessiveNounMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PNPromptLabel;
        private System.Windows.Forms.Label PNLabel;
        private System.Windows.Forms.Button btnPossessivesSingular;
        private System.Windows.Forms.Button buttonPossessivesPlural;
    }
}