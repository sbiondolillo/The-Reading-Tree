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
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PNPromptLabel
            // 
            this.PNPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNPromptLabel.AutoSize = true;
            this.PNPromptLabel.Location = new System.Drawing.Point(155, 55);
            this.PNPromptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PNPromptLabel.Name = "PNPromptLabel";
            this.PNPromptLabel.Size = new System.Drawing.Size(213, 13);
            this.PNPromptLabel.TabIndex = 24;
            this.PNPromptLabel.Text = "Please select a category below to continue!";
            // 
            // PNLabel
            // 
            this.PNLabel.AutoSize = true;
            this.PNLabel.Location = new System.Drawing.Point(216, 30);
            this.PNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PNLabel.Name = "PNLabel";
            this.PNLabel.Size = new System.Drawing.Size(89, 13);
            this.PNLabel.TabIndex = 23;
            this.PNLabel.Text = "Possessive Noun";
            // 
            // btnPossessivesSingular
            // 
            this.btnPossessivesSingular.Location = new System.Drawing.Point(262, 106);
            this.btnPossessivesSingular.Margin = new System.Windows.Forms.Padding(2);
            this.btnPossessivesSingular.Name = "btnPossessivesSingular";
            this.btnPossessivesSingular.Size = new System.Drawing.Size(83, 45);
            this.btnPossessivesSingular.TabIndex = 25;
            this.btnPossessivesSingular.Text = "Possessives singular";
            this.btnPossessivesSingular.UseVisualStyleBackColor = true;
            this.btnPossessivesSingular.Click += new System.EventHandler(this.btnPossessivesSingular_Click);
            // 
            // buttonPossessivesPlural
            // 
            this.buttonPossessivesPlural.Location = new System.Drawing.Point(175, 106);
            this.buttonPossessivesPlural.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPossessivesPlural.Name = "buttonPossessivesPlural";
            this.buttonPossessivesPlural.Size = new System.Drawing.Size(83, 45);
            this.buttonPossessivesPlural.TabIndex = 26;
            this.buttonPossessivesPlural.Text = "Possessives plural";
            this.buttonPossessivesPlural.UseVisualStyleBackColor = true;
            this.buttonPossessivesPlural.Click += new System.EventHandler(this.buttonPossessivesPlural_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(338, 310);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(83, 33);
            this.btnMainMenu.TabIndex = 27;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(425, 310);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(83, 33);
            this.btn_back.TabIndex = 28;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // PossessiveNounMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.buttonPossessivesPlural);
            this.Controls.Add(this.btnPossessivesSingular);
            this.Controls.Add(this.PNPromptLabel);
            this.Controls.Add(this.PNLabel);
            this.Name = "PossessiveNounMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PNPromptLabel;
        private System.Windows.Forms.Label PNLabel;
        private System.Windows.Forms.Button btnPossessivesSingular;
        private System.Windows.Forms.Button buttonPossessivesPlural;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btn_back;
    }
}