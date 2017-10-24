namespace ReadingTree
{
    partial class ISoundsMenu
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
            this.btnIasECalcium = new System.Windows.Forms.Button();
            this.btnIGH = new System.Windows.Forms.Button();
            this.btnIEasIPie = new System.Windows.Forms.Button();
            this.btnIE = new System.Windows.Forms.Button();
            this.ISoundsPromptLabel = new System.Windows.Forms.Label();
            this.ISoundslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(327, 344);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(125, 70);
            this.btnMainMenu.TabIndex = 28;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnIasECalcium
            // 
            this.btnIasECalcium.Location = new System.Drawing.Point(391, 228);
            this.btnIasECalcium.Name = "btnIasECalcium";
            this.btnIasECalcium.Size = new System.Drawing.Size(125, 70);
            this.btnIasECalcium.TabIndex = 25;
            this.btnIasECalcium.Text = "i as /E/ (calcium)";
            this.btnIasECalcium.UseVisualStyleBackColor = true;
            this.btnIasECalcium.Click += new System.EventHandler(this.btnIasECalcium_Click);
            // 
            // btnIGH
            // 
            this.btnIGH.Location = new System.Drawing.Point(262, 228);
            this.btnIGH.Name = "btnIGH";
            this.btnIGH.Size = new System.Drawing.Size(125, 70);
            this.btnIGH.TabIndex = 24;
            this.btnIGH.Text = "igh";
            this.btnIGH.UseVisualStyleBackColor = true;
            this.btnIGH.Click += new System.EventHandler(this.btnIGH_Click);
            // 
            // btnIEasIPie
            // 
            this.btnIEasIPie.Location = new System.Drawing.Point(391, 145);
            this.btnIEasIPie.Name = "btnIEasIPie";
            this.btnIEasIPie.Size = new System.Drawing.Size(125, 70);
            this.btnIEasIPie.TabIndex = 23;
            this.btnIEasIPie.Text = "ie as /I/ (pie)";
            this.btnIEasIPie.UseVisualStyleBackColor = true;
            this.btnIEasIPie.Click += new System.EventHandler(this.btnIEasIPie_Click);
            // 
            // btnIE
            // 
            this.btnIE.Location = new System.Drawing.Point(262, 145);
            this.btnIE.Name = "btnIE";
            this.btnIE.Size = new System.Drawing.Size(125, 70);
            this.btnIE.TabIndex = 22;
            this.btnIE.Text = "i-e";
            this.btnIE.UseVisualStyleBackColor = true;
            this.btnIE.Click += new System.EventHandler(this.btnIE_Click);
            // 
            // ISoundsPromptLabel
            // 
            this.ISoundsPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ISoundsPromptLabel.AutoSize = true;
            this.ISoundsPromptLabel.Location = new System.Drawing.Point(233, 86);
            this.ISoundsPromptLabel.Name = "ISoundsPromptLabel";
            this.ISoundsPromptLabel.Size = new System.Drawing.Size(313, 20);
            this.ISoundsPromptLabel.TabIndex = 21;
            this.ISoundsPromptLabel.Text = "Please select a category below to continue!";
            // 
            // ISoundslabel
            // 
            this.ISoundslabel.AutoSize = true;
            this.ISoundslabel.Location = new System.Drawing.Point(353, 39);
            this.ISoundslabel.Name = "ISoundslabel";
            this.ISoundslabel.Size = new System.Drawing.Size(73, 20);
            this.ISoundslabel.TabIndex = 20;
            this.ISoundslabel.Text = "I Sounds";
            // 
            // ISoundsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnIasECalcium);
            this.Controls.Add(this.btnIGH);
            this.Controls.Add(this.btnIEasIPie);
            this.Controls.Add(this.btnIE);
            this.Controls.Add(this.ISoundsPromptLabel);
            this.Controls.Add(this.ISoundslabel);
            this.Name = "ISoundsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnIasECalcium;
        private System.Windows.Forms.Button btnIGH;
        private System.Windows.Forms.Button btnIEasIPie;
        private System.Windows.Forms.Button btnIE;
        private System.Windows.Forms.Label ISoundsPromptLabel;
        private System.Windows.Forms.Label ISoundslabel;
    }
}