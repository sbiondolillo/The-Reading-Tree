namespace ReadingTree
{
    partial class RsMenu
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
            this.RsPromptlabel = new System.Windows.Forms.Label();
            this.Rslabel = new System.Windows.Forms.Label();
            this.btnUR = new System.Windows.Forms.Button();
            this.btnOR = new System.Windows.Forms.Button();
            this.btnIR = new System.Windows.Forms.Button();
            this.btnER = new System.Windows.Forms.Button();
            this.btnAR = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RsPromptlabel
            // 
            this.RsPromptlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RsPromptlabel.AutoSize = true;
            this.RsPromptlabel.Location = new System.Drawing.Point(233, 84);
            this.RsPromptlabel.Name = "RsPromptlabel";
            this.RsPromptlabel.Size = new System.Drawing.Size(313, 20);
            this.RsPromptlabel.TabIndex = 6;
            this.RsPromptlabel.Text = "Please select a category below to continue!";
            // 
            // Rslabel
            // 
            this.Rslabel.AutoSize = true;
            this.Rslabel.Location = new System.Drawing.Point(375, 37);
            this.Rslabel.Name = "Rslabel";
            this.Rslabel.Size = new System.Drawing.Size(29, 20);
            this.Rslabel.TabIndex = 5;
            this.Rslabel.Text = "Rs";
            // 
            // btnUR
            // 
            this.btnUR.Location = new System.Drawing.Point(393, 222);
            this.btnUR.Name = "btnUR";
            this.btnUR.Size = new System.Drawing.Size(125, 70);
            this.btnUR.TabIndex = 26;
            this.btnUR.Text = "ur";
            this.btnUR.UseVisualStyleBackColor = true;
            this.btnUR.Click += new System.EventHandler(this.btnUR_Click);
            // 
            // btnOR
            // 
            this.btnOR.Location = new System.Drawing.Point(262, 222);
            this.btnOR.Name = "btnOR";
            this.btnOR.Size = new System.Drawing.Size(125, 70);
            this.btnOR.TabIndex = 25;
            this.btnOR.Text = "or";
            this.btnOR.UseVisualStyleBackColor = true;
            this.btnOR.Click += new System.EventHandler(this.btnOR_Click);
            // 
            // btnIR
            // 
            this.btnIR.Location = new System.Drawing.Point(456, 146);
            this.btnIR.Name = "btnIR";
            this.btnIR.Size = new System.Drawing.Size(125, 70);
            this.btnIR.TabIndex = 24;
            this.btnIR.Text = "ir";
            this.btnIR.UseVisualStyleBackColor = true;
            this.btnIR.Click += new System.EventHandler(this.btnIR_Click);
            // 
            // btnER
            // 
            this.btnER.Location = new System.Drawing.Point(327, 146);
            this.btnER.Name = "btnER";
            this.btnER.Size = new System.Drawing.Size(125, 70);
            this.btnER.TabIndex = 23;
            this.btnER.Text = "er";
            this.btnER.UseVisualStyleBackColor = true;
            this.btnER.Click += new System.EventHandler(this.btnER_Click);
            // 
            // btnAR
            // 
            this.btnAR.Location = new System.Drawing.Point(198, 146);
            this.btnAR.Name = "btnAR";
            this.btnAR.Size = new System.Drawing.Size(125, 70);
            this.btnAR.TabIndex = 22;
            this.btnAR.Text = "ar";
            this.btnAR.UseVisualStyleBackColor = true;
            this.btnAR.Click += new System.EventHandler(this.btnAR_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(327, 314);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(125, 70);
            this.btnMainMenu.TabIndex = 27;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // RsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnUR);
            this.Controls.Add(this.btnOR);
            this.Controls.Add(this.btnIR);
            this.Controls.Add(this.btnER);
            this.Controls.Add(this.btnAR);
            this.Controls.Add(this.RsPromptlabel);
            this.Controls.Add(this.Rslabel);
            this.Name = "RsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RsPromptlabel;
        private System.Windows.Forms.Label Rslabel;
        private System.Windows.Forms.Button btnUR;
        private System.Windows.Forms.Button btnOR;
        private System.Windows.Forms.Button btnIR;
        private System.Windows.Forms.Button btnER;
        private System.Windows.Forms.Button btnAR;
        private System.Windows.Forms.Button btnMainMenu;
    }
}