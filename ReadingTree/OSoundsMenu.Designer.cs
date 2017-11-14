namespace ReadingTree
{
    partial class OSoundsMenu
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
            this.btnOWasOSnow = new System.Windows.Forms.Button();
            this.btnOI = new System.Windows.Forms.Button();
            this.btnOE = new System.Windows.Forms.Button();
            this.btnOA = new System.Windows.Forms.Button();
            this.OSoundsPromptLabel = new System.Windows.Forms.Label();
            this.OSoundslabel = new System.Windows.Forms.Label();
            this.btnOE2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(326, 346);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(125, 70);
            this.btnMainMenu.TabIndex = 35;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnOWasOSnow
            // 
            this.btnOWasOSnow.Location = new System.Drawing.Point(390, 230);
            this.btnOWasOSnow.Name = "btnOWasOSnow";
            this.btnOWasOSnow.Size = new System.Drawing.Size(125, 70);
            this.btnOWasOSnow.TabIndex = 34;
            this.btnOWasOSnow.Text = "ow as /O/ (snow)";
            this.btnOWasOSnow.UseVisualStyleBackColor = true;
            this.btnOWasOSnow.Click += new System.EventHandler(this.btnIasECalcium_Click);
            // 
            // btnOI
            // 
            this.btnOI.Location = new System.Drawing.Point(261, 230);
            this.btnOI.Name = "btnOI";
            this.btnOI.Size = new System.Drawing.Size(125, 70);
            this.btnOI.TabIndex = 33;
            this.btnOI.Text = "oi";
            this.btnOI.UseVisualStyleBackColor = true;
            this.btnOI.Click += new System.EventHandler(this.btnIGH_Click);
            // 
            // btnOE
            // 
            this.btnOE.Location = new System.Drawing.Point(326, 154);
            this.btnOE.Name = "btnOE";
            this.btnOE.Size = new System.Drawing.Size(125, 70);
            this.btnOE.TabIndex = 32;
            this.btnOE.Text = "oe";
            this.btnOE.UseVisualStyleBackColor = true;
            this.btnOE.Click += new System.EventHandler(this.btnIEasIPie_Click);
            // 
            // btnOA
            // 
            this.btnOA.Location = new System.Drawing.Point(197, 154);
            this.btnOA.Name = "btnOA";
            this.btnOA.Size = new System.Drawing.Size(125, 70);
            this.btnOA.TabIndex = 31;
            this.btnOA.Text = "oa";
            this.btnOA.UseVisualStyleBackColor = true;
            this.btnOA.Click += new System.EventHandler(this.btnIE_Click);
            // 
            // OSoundsPromptLabel
            // 
            this.OSoundsPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OSoundsPromptLabel.AutoSize = true;
            this.OSoundsPromptLabel.Location = new System.Drawing.Point(232, 88);
            this.OSoundsPromptLabel.Name = "OSoundsPromptLabel";
            this.OSoundsPromptLabel.Size = new System.Drawing.Size(313, 20);
            this.OSoundsPromptLabel.TabIndex = 30;
            this.OSoundsPromptLabel.Text = "Please select a category below to continue!";
            // 
            // OSoundslabel
            // 
            this.OSoundslabel.AutoSize = true;
            this.OSoundslabel.Location = new System.Drawing.Point(352, 41);
            this.OSoundslabel.Name = "OSoundslabel";
            this.OSoundslabel.Size = new System.Drawing.Size(80, 20);
            this.OSoundslabel.TabIndex = 29;
            this.OSoundslabel.Text = "O Sounds";
            // 
            // btnOE2
            // 
            this.btnOE2.Location = new System.Drawing.Point(457, 154);
            this.btnOE2.Name = "btnOE2";
            this.btnOE2.Size = new System.Drawing.Size(125, 70);
            this.btnOE2.TabIndex = 36;
            this.btnOE2.Text = "o-e";
            this.btnOE2.UseVisualStyleBackColor = true;
            this.btnOE2.Click += new System.EventHandler(this.button1_Click);
            // 
            // OSoundsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnOE2);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnOWasOSnow);
            this.Controls.Add(this.btnOI);
            this.Controls.Add(this.btnOE);
            this.Controls.Add(this.btnOA);
            this.Controls.Add(this.OSoundsPromptLabel);
            this.Controls.Add(this.OSoundslabel);
            this.Name = "OSoundsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnOWasOSnow;
        private System.Windows.Forms.Button btnOI;
        private System.Windows.Forms.Button btnOE;
        private System.Windows.Forms.Button btnOA;
        private System.Windows.Forms.Label OSoundsPromptLabel;
        private System.Windows.Forms.Label OSoundslabel;
        private System.Windows.Forms.Button btnOE2;
    }
}