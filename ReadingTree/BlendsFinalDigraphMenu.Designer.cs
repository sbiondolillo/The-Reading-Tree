namespace ReadingTree
{
    partial class BlendsFinalDigraphMenu
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
            this.BlendsFinalDigraphPromptLabel = new System.Windows.Forms.Label();
            this.BlendsFinalDigraphlabel = new System.Windows.Forms.Label();
            this.btnBlendsFinalDigraph = new System.Windows.Forms.Button();
            this.btnBlendsFinalMixed = new System.Windows.Forms.Button();
            this.btnBlendsDigraph = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BlendsFinalDigraphPromptLabel
            // 
            this.BlendsFinalDigraphPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlendsFinalDigraphPromptLabel.AutoSize = true;
            this.BlendsFinalDigraphPromptLabel.Location = new System.Drawing.Point(233, 97);
            this.BlendsFinalDigraphPromptLabel.Name = "BlendsFinalDigraphPromptLabel";
            this.BlendsFinalDigraphPromptLabel.Size = new System.Drawing.Size(313, 20);
            this.BlendsFinalDigraphPromptLabel.TabIndex = 28;
            this.BlendsFinalDigraphPromptLabel.Text = "Please select a category below to continue!";
            // 
            // BlendsFinalDigraphlabel
            // 
            this.BlendsFinalDigraphlabel.AutoSize = true;
            this.BlendsFinalDigraphlabel.Location = new System.Drawing.Point(307, 50);
            this.BlendsFinalDigraphlabel.Name = "BlendsFinalDigraphlabel";
            this.BlendsFinalDigraphlabel.Size = new System.Drawing.Size(164, 20);
            this.BlendsFinalDigraphlabel.TabIndex = 27;
            this.BlendsFinalDigraphlabel.Text = "Blends, Final, Digraph";
            // 
            // btnBlendsFinalDigraph
            // 
            this.btnBlendsFinalDigraph.Location = new System.Drawing.Point(456, 160);
            this.btnBlendsFinalDigraph.Name = "btnBlendsFinalDigraph";
            this.btnBlendsFinalDigraph.Size = new System.Drawing.Size(125, 70);
            this.btnBlendsFinalDigraph.TabIndex = 26;
            this.btnBlendsFinalDigraph.Text = "Final, Digraph";
            this.btnBlendsFinalDigraph.UseVisualStyleBackColor = true;
            this.btnBlendsFinalDigraph.Click += new System.EventHandler(this.btnBlendsFinalDigraph_Click);
            // 
            // btnBlendsFinalMixed
            // 
            this.btnBlendsFinalMixed.Location = new System.Drawing.Point(327, 160);
            this.btnBlendsFinalMixed.Name = "btnBlendsFinalMixed";
            this.btnBlendsFinalMixed.Size = new System.Drawing.Size(125, 70);
            this.btnBlendsFinalMixed.TabIndex = 25;
            this.btnBlendsFinalMixed.Text = "Final, Mixed";
            this.btnBlendsFinalMixed.UseVisualStyleBackColor = true;
            this.btnBlendsFinalMixed.Click += new System.EventHandler(this.btnBlendsFinalMixed_Click);
            // 
            // btnBlendsDigraph
            // 
            this.btnBlendsDigraph.Location = new System.Drawing.Point(198, 160);
            this.btnBlendsDigraph.Name = "btnBlendsDigraph";
            this.btnBlendsDigraph.Size = new System.Drawing.Size(125, 70);
            this.btnBlendsDigraph.TabIndex = 24;
            this.btnBlendsDigraph.Text = "Digraph";
            this.btnBlendsDigraph.UseVisualStyleBackColor = true;
            this.btnBlendsDigraph.Click += new System.EventHandler(this.btnBlendsDigraph_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(327, 264);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(125, 70);
            this.btnMainMenu.TabIndex = 29;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // BlendsFinalDigraphMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.BlendsFinalDigraphPromptLabel);
            this.Controls.Add(this.BlendsFinalDigraphlabel);
            this.Controls.Add(this.btnBlendsFinalDigraph);
            this.Controls.Add(this.btnBlendsFinalMixed);
            this.Controls.Add(this.btnBlendsDigraph);
            this.Name = "BlendsFinalDigraphMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BlendsFinalDigraphPromptLabel;
        private System.Windows.Forms.Label BlendsFinalDigraphlabel;
        private System.Windows.Forms.Button btnBlendsFinalDigraph;
        private System.Windows.Forms.Button btnBlendsFinalMixed;
        private System.Windows.Forms.Button btnBlendsDigraph;
        private System.Windows.Forms.Button btnMainMenu;
    }
}