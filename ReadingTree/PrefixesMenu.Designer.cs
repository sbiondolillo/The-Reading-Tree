namespace ReadingTree
{
    partial class PrefixesMenu
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
            this.LB_Prefix = new System.Windows.Forms.Label();
            this.LB_Select = new System.Windows.Forms.Label();
            this.BTN_NP = new System.Windows.Forms.Button();
            this.BTN_LP = new System.Windows.Forms.Button();
            this.BTN_LCP = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Prefix
            // 
            this.LB_Prefix.AutoSize = true;
            this.LB_Prefix.Location = new System.Drawing.Point(189, 20);
            this.LB_Prefix.Name = "LB_Prefix";
            this.LB_Prefix.Size = new System.Drawing.Size(44, 13);
            this.LB_Prefix.TabIndex = 0;
            this.LB_Prefix.Text = "Prefixes";
            // 
            // LB_Select
            // 
            this.LB_Select.AutoSize = true;
            this.LB_Select.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LB_Select.Location = new System.Drawing.Point(107, 61);
            this.LB_Select.Name = "LB_Select";
            this.LB_Select.Size = new System.Drawing.Size(213, 13);
            this.LB_Select.TabIndex = 1;
            this.LB_Select.Text = "Please select a category below to continue!";
            this.LB_Select.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BTN_NP
            // 
            this.BTN_NP.Location = new System.Drawing.Point(63, 110);
            this.BTN_NP.Name = "BTN_NP";
            this.BTN_NP.Size = new System.Drawing.Size(83, 55);
            this.BTN_NP.TabIndex = 2;
            this.BTN_NP.Text = "Normally Prefixes";
            this.BTN_NP.UseVisualStyleBackColor = true;
            this.BTN_NP.Click += new System.EventHandler(this.BTN_NP_Click);
            // 
            // BTN_LP
            // 
            this.BTN_LP.Location = new System.Drawing.Point(170, 110);
            this.BTN_LP.Name = "BTN_LP";
            this.BTN_LP.Size = new System.Drawing.Size(83, 55);
            this.BTN_LP.TabIndex = 3;
            this.BTN_LP.Text = "Latin Prefixes";
            this.BTN_LP.UseVisualStyleBackColor = true;
            this.BTN_LP.Click += new System.EventHandler(this.BTN_LP_Click);
            // 
            // BTN_LCP
            // 
            this.BTN_LCP.Location = new System.Drawing.Point(271, 110);
            this.BTN_LCP.Name = "BTN_LCP";
            this.BTN_LCP.Size = new System.Drawing.Size(83, 55);
            this.BTN_LCP.TabIndex = 4;
            this.BTN_LCP.Text = "Latin Chameleon Prefixes";
            this.BTN_LCP.UseVisualStyleBackColor = true;
            this.BTN_LCP.Click += new System.EventHandler(this.BTN_LCP_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(170, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "Main Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PrefixesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 276);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTN_LCP);
            this.Controls.Add(this.BTN_LP);
            this.Controls.Add(this.BTN_NP);
            this.Controls.Add(this.LB_Select);
            this.Controls.Add(this.LB_Prefix);
            this.Name = "PrefixesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Prefix;
        private System.Windows.Forms.Label LB_Select;
        private System.Windows.Forms.Button BTN_NP;
        private System.Windows.Forms.Button BTN_LP;
        private System.Windows.Forms.Button BTN_LCP;
        private System.Windows.Forms.Button button4;
    }
}