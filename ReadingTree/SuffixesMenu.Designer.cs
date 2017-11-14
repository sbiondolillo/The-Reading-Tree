namespace ReadingTree
{
    partial class SuffixesMenu
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
            this.SuffixLabel = new System.Windows.Forms.Label();
            this.LB_Suf = new System.Windows.Forms.Label();
            this.BTN_Suffix = new System.Windows.Forms.Button();
            this.BTN_LS = new System.Windows.Forms.Button();
            this.BTN_MainMenu = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SuffixLabel
            // 
            this.SuffixLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuffixLabel.AutoSize = true;
            this.SuffixLabel.Location = new System.Drawing.Point(142, 66);
            this.SuffixLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SuffixLabel.Name = "SuffixLabel";
            this.SuffixLabel.Size = new System.Drawing.Size(213, 13);
            this.SuffixLabel.TabIndex = 19;
            this.SuffixLabel.Text = "Please select a category below to continue!";
            // 
            // LB_Suf
            // 
            this.LB_Suf.AutoSize = true;
            this.LB_Suf.Location = new System.Drawing.Point(226, 36);
            this.LB_Suf.Name = "LB_Suf";
            this.LB_Suf.Size = new System.Drawing.Size(44, 13);
            this.LB_Suf.TabIndex = 20;
            this.LB_Suf.Text = "Suffixes";
            // 
            // BTN_Suffix
            // 
            this.BTN_Suffix.Location = new System.Drawing.Point(162, 113);
            this.BTN_Suffix.Name = "BTN_Suffix";
            this.BTN_Suffix.Size = new System.Drawing.Size(83, 45);
            this.BTN_Suffix.TabIndex = 21;
            this.BTN_Suffix.Text = "Suffix";
            this.BTN_Suffix.UseVisualStyleBackColor = true;
            this.BTN_Suffix.Click += new System.EventHandler(this.BTN_Suffix_Click);
            // 
            // BTN_LS
            // 
            this.BTN_LS.Location = new System.Drawing.Point(251, 113);
            this.BTN_LS.Name = "BTN_LS";
            this.BTN_LS.Size = new System.Drawing.Size(83, 45);
            this.BTN_LS.TabIndex = 22;
            this.BTN_LS.Text = "Latin Suffix";
            this.BTN_LS.UseVisualStyleBackColor = true;
            this.BTN_LS.Click += new System.EventHandler(this.BTN_LS_Click);
            // 
            // BTN_MainMenu
            // 
            this.BTN_MainMenu.Location = new System.Drawing.Point(337, 309);
            this.BTN_MainMenu.Name = "BTN_MainMenu";
            this.BTN_MainMenu.Size = new System.Drawing.Size(83, 33);
            this.BTN_MainMenu.TabIndex = 23;
            this.BTN_MainMenu.Text = "Main Menu";
            this.BTN_MainMenu.UseVisualStyleBackColor = true;
            this.BTN_MainMenu.Click += new System.EventHandler(this.BTN_MainMenu_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(425, 310);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(83, 33);
            this.btn_back.TabIndex = 27;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SuffixesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.BTN_MainMenu);
            this.Controls.Add(this.BTN_LS);
            this.Controls.Add(this.BTN_Suffix);
            this.Controls.Add(this.LB_Suf);
            this.Controls.Add(this.SuffixLabel);
            this.Name = "SuffixesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SuffixLabel;
        private System.Windows.Forms.Label LB_Suf;
        private System.Windows.Forms.Button BTN_Suffix;
        private System.Windows.Forms.Button BTN_LS;
        private System.Windows.Forms.Button BTN_MainMenu;
        private System.Windows.Forms.Button btn_back;
    }
}