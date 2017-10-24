namespace ReadingTree
{
    partial class CVCMenu
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
            this.btnCVCu = new System.Windows.Forms.Button();
            this.btnCVCo = new System.Windows.Forms.Button();
            this.btnCVCi = new System.Windows.Forms.Button();
            this.btnCVCe = new System.Windows.Forms.Button();
            this.btnCVCa = new System.Windows.Forms.Button();
            this.CVCPromptlabel = new System.Windows.Forms.Label();
            this.CVClabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(327, 309);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(125, 70);
            this.btnMainMenu.TabIndex = 35;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnCVCu
            // 
            this.btnCVCu.Location = new System.Drawing.Point(393, 217);
            this.btnCVCu.Name = "btnCVCu";
            this.btnCVCu.Size = new System.Drawing.Size(125, 70);
            this.btnCVCu.TabIndex = 34;
            this.btnCVCu.Text = "CVC u";
            this.btnCVCu.UseVisualStyleBackColor = true;
            this.btnCVCu.Click += new System.EventHandler(this.btnCVCu_Click);
            // 
            // btnCVCo
            // 
            this.btnCVCo.Location = new System.Drawing.Point(262, 217);
            this.btnCVCo.Name = "btnCVCo";
            this.btnCVCo.Size = new System.Drawing.Size(125, 70);
            this.btnCVCo.TabIndex = 33;
            this.btnCVCo.Text = "CVC o";
            this.btnCVCo.UseVisualStyleBackColor = true;
            this.btnCVCo.Click += new System.EventHandler(this.btnCVCo_Click);
            // 
            // btnCVCi
            // 
            this.btnCVCi.Location = new System.Drawing.Point(456, 141);
            this.btnCVCi.Name = "btnCVCi";
            this.btnCVCi.Size = new System.Drawing.Size(125, 70);
            this.btnCVCi.TabIndex = 32;
            this.btnCVCi.Text = "CVC i";
            this.btnCVCi.UseVisualStyleBackColor = true;
            this.btnCVCi.Click += new System.EventHandler(this.btnCVCi_Click);
            // 
            // btnCVCe
            // 
            this.btnCVCe.Location = new System.Drawing.Point(327, 141);
            this.btnCVCe.Name = "btnCVCe";
            this.btnCVCe.Size = new System.Drawing.Size(125, 70);
            this.btnCVCe.TabIndex = 31;
            this.btnCVCe.Text = "CVC e";
            this.btnCVCe.UseVisualStyleBackColor = true;
            this.btnCVCe.Click += new System.EventHandler(this.btnCVCe_Click);
            // 
            // btnCVCa
            // 
            this.btnCVCa.Location = new System.Drawing.Point(198, 141);
            this.btnCVCa.Name = "btnCVCa";
            this.btnCVCa.Size = new System.Drawing.Size(125, 70);
            this.btnCVCa.TabIndex = 30;
            this.btnCVCa.Text = "CVC a";
            this.btnCVCa.UseVisualStyleBackColor = true;
            this.btnCVCa.Click += new System.EventHandler(this.btnCVCa_Click);
            // 
            // CVCPromptlabel
            // 
            this.CVCPromptlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CVCPromptlabel.AutoSize = true;
            this.CVCPromptlabel.Location = new System.Drawing.Point(233, 79);
            this.CVCPromptlabel.Name = "CVCPromptlabel";
            this.CVCPromptlabel.Size = new System.Drawing.Size(313, 20);
            this.CVCPromptlabel.TabIndex = 29;
            this.CVCPromptlabel.Text = "Please select a category below to continue!";
            // 
            // CVClabel
            // 
            this.CVClabel.AutoSize = true;
            this.CVClabel.Location = new System.Drawing.Point(368, 32);
            this.CVClabel.Name = "CVClabel";
            this.CVClabel.Size = new System.Drawing.Size(42, 20);
            this.CVClabel.TabIndex = 28;
            this.CVClabel.Text = "CVC";
            // 
            // CVCMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnCVCu);
            this.Controls.Add(this.btnCVCo);
            this.Controls.Add(this.btnCVCi);
            this.Controls.Add(this.btnCVCe);
            this.Controls.Add(this.btnCVCa);
            this.Controls.Add(this.CVCPromptlabel);
            this.Controls.Add(this.CVClabel);
            this.Name = "CVCMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnCVCu;
        private System.Windows.Forms.Button btnCVCo;
        private System.Windows.Forms.Button btnCVCi;
        private System.Windows.Forms.Button btnCVCe;
        private System.Windows.Forms.Button btnCVCa;
        private System.Windows.Forms.Label CVCPromptlabel;
        private System.Windows.Forms.Label CVClabel;
    }
}