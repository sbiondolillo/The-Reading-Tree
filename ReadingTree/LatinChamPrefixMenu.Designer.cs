namespace ReadingTree
{
    partial class LatinChamPrefixMenu
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
            this.BTN_MainMenu = new System.Windows.Forms.Button();
            this.LB_Select = new System.Windows.Forms.Label();
            this.LB_Title = new System.Windows.Forms.Label();
            this.BTN_Con = new System.Windows.Forms.Button();
            this.BTN_Di = new System.Windows.Forms.Button();
            this.BTN_In = new System.Windows.Forms.Button();
            this.BTN_Sub = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_MainMenu
            // 
            this.BTN_MainMenu.Location = new System.Drawing.Point(337, 309);
            this.BTN_MainMenu.Name = "BTN_MainMenu";
            this.BTN_MainMenu.Size = new System.Drawing.Size(83, 33);
            this.BTN_MainMenu.TabIndex = 14;
            this.BTN_MainMenu.Text = "Main Menu";
            this.BTN_MainMenu.UseVisualStyleBackColor = true;
            this.BTN_MainMenu.Click += new System.EventHandler(this.BTN_MainMenu_Click);
            // 
            // LB_Select
            // 
            this.LB_Select.AutoSize = true;
            this.LB_Select.Location = new System.Drawing.Point(150, 88);
            this.LB_Select.Name = "LB_Select";
            this.LB_Select.Size = new System.Drawing.Size(213, 13);
            this.LB_Select.TabIndex = 15;
            this.LB_Select.Text = "Please select a category below to continue!";
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.Location = new System.Drawing.Point(203, 53);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(115, 13);
            this.LB_Title.TabIndex = 16;
            this.LB_Title.Text = "Latin Chameleon Prefix";
            // 
            // BTN_Con
            // 
            this.BTN_Con.Location = new System.Drawing.Point(140, 131);
            this.BTN_Con.Name = "BTN_Con";
            this.BTN_Con.Size = new System.Drawing.Size(103, 45);
            this.BTN_Con.TabIndex = 17;
            this.BTN_Con.Text = "Con/Com/Col/Cor";
            this.BTN_Con.UseVisualStyleBackColor = true;
            this.BTN_Con.Click += new System.EventHandler(this.BTN_Con_Click);
            // 
            // BTN_Di
            // 
            this.BTN_Di.Location = new System.Drawing.Point(249, 131);
            this.BTN_Di.Name = "BTN_Di";
            this.BTN_Di.Size = new System.Drawing.Size(114, 45);
            this.BTN_Di.TabIndex = 18;
            this.BTN_Di.Text = "Di/Dif/Dis";
            this.BTN_Di.UseVisualStyleBackColor = true;
            this.BTN_Di.Click += new System.EventHandler(this.BTN_Di_Click);
            // 
            // BTN_In
            // 
            this.BTN_In.Location = new System.Drawing.Point(140, 182);
            this.BTN_In.Name = "BTN_In";
            this.BTN_In.Size = new System.Drawing.Size(99, 45);
            this.BTN_In.TabIndex = 19;
            this.BTN_In.Text = "In/Im/Il/Ir";
            this.BTN_In.UseVisualStyleBackColor = true;
            this.BTN_In.Click += new System.EventHandler(this.BTN_In_Click);
            // 
            // BTN_Sub
            // 
            this.BTN_Sub.Location = new System.Drawing.Point(245, 182);
            this.BTN_Sub.Name = "BTN_Sub";
            this.BTN_Sub.Size = new System.Drawing.Size(118, 45);
            this.BTN_Sub.TabIndex = 20;
            this.BTN_Sub.Text = "Sub/Sus/Sur/Suc/ Suf/Sum/Sup";
            this.BTN_Sub.UseVisualStyleBackColor = true;
            this.BTN_Sub.Click += new System.EventHandler(this.BTN_Sub_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(425, 310);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(83, 33);
            this.btn_back.TabIndex = 31;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // LatinChamPrefixMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.BTN_Sub);
            this.Controls.Add(this.BTN_In);
            this.Controls.Add(this.BTN_Di);
            this.Controls.Add(this.BTN_Con);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.LB_Select);
            this.Controls.Add(this.BTN_MainMenu);
            this.Name = "LatinChamPrefixMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_MainMenu;
        private System.Windows.Forms.Label LB_Select;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.Button BTN_Con;
        private System.Windows.Forms.Button BTN_Di;
        private System.Windows.Forms.Button BTN_In;
        private System.Windows.Forms.Button BTN_Sub;
        private System.Windows.Forms.Button btn_back;
    }
}