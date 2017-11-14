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
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RsPromptlabel
            // 
            this.RsPromptlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RsPromptlabel.AutoSize = true;
            this.RsPromptlabel.Location = new System.Drawing.Point(155, 55);
            this.RsPromptlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RsPromptlabel.Name = "RsPromptlabel";
            this.RsPromptlabel.Size = new System.Drawing.Size(213, 13);
            this.RsPromptlabel.TabIndex = 6;
            this.RsPromptlabel.Text = "Please select a category below to continue!";
            // 
            // Rslabel
            // 
            this.Rslabel.AutoSize = true;
            this.Rslabel.Location = new System.Drawing.Point(250, 24);
            this.Rslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rslabel.Name = "Rslabel";
            this.Rslabel.Size = new System.Drawing.Size(20, 13);
            this.Rslabel.TabIndex = 5;
            this.Rslabel.Text = "Rs";
            // 
            // btnUR
            // 
            this.btnUR.Location = new System.Drawing.Point(262, 144);
            this.btnUR.Margin = new System.Windows.Forms.Padding(2);
            this.btnUR.Name = "btnUR";
            this.btnUR.Size = new System.Drawing.Size(83, 45);
            this.btnUR.TabIndex = 26;
            this.btnUR.Text = "ur";
            this.btnUR.UseVisualStyleBackColor = true;
            this.btnUR.Click += new System.EventHandler(this.btnUR_Click);
            // 
            // btnOR
            // 
            this.btnOR.Location = new System.Drawing.Point(175, 144);
            this.btnOR.Margin = new System.Windows.Forms.Padding(2);
            this.btnOR.Name = "btnOR";
            this.btnOR.Size = new System.Drawing.Size(83, 45);
            this.btnOR.TabIndex = 25;
            this.btnOR.Text = "or";
            this.btnOR.UseVisualStyleBackColor = true;
            this.btnOR.Click += new System.EventHandler(this.btnOR_Click);
            // 
            // btnIR
            // 
            this.btnIR.Location = new System.Drawing.Point(304, 95);
            this.btnIR.Margin = new System.Windows.Forms.Padding(2);
            this.btnIR.Name = "btnIR";
            this.btnIR.Size = new System.Drawing.Size(83, 45);
            this.btnIR.TabIndex = 24;
            this.btnIR.Text = "ir";
            this.btnIR.UseVisualStyleBackColor = true;
            this.btnIR.Click += new System.EventHandler(this.btnIR_Click);
            // 
            // btnER
            // 
            this.btnER.Location = new System.Drawing.Point(218, 95);
            this.btnER.Margin = new System.Windows.Forms.Padding(2);
            this.btnER.Name = "btnER";
            this.btnER.Size = new System.Drawing.Size(83, 45);
            this.btnER.TabIndex = 23;
            this.btnER.Text = "er";
            this.btnER.UseVisualStyleBackColor = true;
            this.btnER.Click += new System.EventHandler(this.btnER_Click);
            // 
            // btnAR
            // 
            this.btnAR.Location = new System.Drawing.Point(132, 95);
            this.btnAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnAR.Name = "btnAR";
            this.btnAR.Size = new System.Drawing.Size(83, 45);
            this.btnAR.TabIndex = 22;
            this.btnAR.Text = "ar";
            this.btnAR.UseVisualStyleBackColor = true;
            this.btnAR.Click += new System.EventHandler(this.btnAR_Click);
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
            // RsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnUR);
            this.Controls.Add(this.btnOR);
            this.Controls.Add(this.btnIR);
            this.Controls.Add(this.btnER);
            this.Controls.Add(this.btnAR);
            this.Controls.Add(this.RsPromptlabel);
            this.Controls.Add(this.Rslabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
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
        private System.Windows.Forms.Button btn_back;
    }
}