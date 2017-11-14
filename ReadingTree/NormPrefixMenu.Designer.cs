namespace ReadingTree
{
    partial class NormPrefixMenu
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
            this.LB_Title = new System.Windows.Forms.Label();
            this.LB_Select = new System.Windows.Forms.Label();
            this.BTN_Mis = new System.Windows.Forms.Button();
            this.BTN_Non = new System.Windows.Forms.Button();
            this.BTN_Dis = new System.Windows.Forms.Button();
            this.BTN_Sub = new System.Windows.Forms.Button();
            this.BTN_Un = new System.Windows.Forms.Button();
            this.BTN_MainMenu = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.Location = new System.Drawing.Point(163, 29);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(76, 13);
            this.LB_Title.TabIndex = 4;
            this.LB_Title.Text = "Normally Prefix";
            // 
            // LB_Select
            // 
            this.LB_Select.AutoSize = true;
            this.LB_Select.Location = new System.Drawing.Point(99, 61);
            this.LB_Select.Name = "LB_Select";
            this.LB_Select.Size = new System.Drawing.Size(213, 13);
            this.LB_Select.TabIndex = 5;
            this.LB_Select.Text = "Please select a category below to continue!";
            // 
            // BTN_Mis
            // 
            this.BTN_Mis.Location = new System.Drawing.Point(53, 97);
            this.BTN_Mis.Name = "BTN_Mis";
            this.BTN_Mis.Size = new System.Drawing.Size(83, 45);
            this.BTN_Mis.TabIndex = 6;
            this.BTN_Mis.Text = "Mis-";
            this.BTN_Mis.UseVisualStyleBackColor = true;
            this.BTN_Mis.Click += new System.EventHandler(this.BTN_Mis_Click);
            // 
            // BTN_Non
            // 
            this.BTN_Non.Location = new System.Drawing.Point(156, 97);
            this.BTN_Non.Name = "BTN_Non";
            this.BTN_Non.Size = new System.Drawing.Size(83, 45);
            this.BTN_Non.TabIndex = 7;
            this.BTN_Non.Text = "Non-";
            this.BTN_Non.UseVisualStyleBackColor = true;
            this.BTN_Non.Click += new System.EventHandler(this.BTN_Non_Click);
            // 
            // BTN_Dis
            // 
            this.BTN_Dis.Location = new System.Drawing.Point(261, 97);
            this.BTN_Dis.Name = "BTN_Dis";
            this.BTN_Dis.Size = new System.Drawing.Size(83, 45);
            this.BTN_Dis.TabIndex = 8;
            this.BTN_Dis.Text = "Dis-";
            this.BTN_Dis.UseVisualStyleBackColor = true;
            this.BTN_Dis.Click += new System.EventHandler(this.BTN_Dis_Click);
            // 
            // BTN_Sub
            // 
            this.BTN_Sub.Location = new System.Drawing.Point(102, 165);
            this.BTN_Sub.Name = "BTN_Sub";
            this.BTN_Sub.Size = new System.Drawing.Size(83, 45);
            this.BTN_Sub.TabIndex = 9;
            this.BTN_Sub.Text = "Sub-";
            this.BTN_Sub.UseVisualStyleBackColor = true;
            this.BTN_Sub.Click += new System.EventHandler(this.BTN_Sub_Click);
            // 
            // BTN_Un
            // 
            this.BTN_Un.Location = new System.Drawing.Point(208, 165);
            this.BTN_Un.Name = "BTN_Un";
            this.BTN_Un.Size = new System.Drawing.Size(83, 45);
            this.BTN_Un.TabIndex = 10;
            this.BTN_Un.Text = "Un-";
            this.BTN_Un.UseVisualStyleBackColor = true;
            this.BTN_Un.Click += new System.EventHandler(this.BTN_Un_Click);
            // 
            // BTN_MainMenu
            // 
            this.BTN_MainMenu.Location = new System.Drawing.Point(237, 252);
            this.BTN_MainMenu.Name = "BTN_MainMenu";
            this.BTN_MainMenu.Size = new System.Drawing.Size(83, 33);
            this.BTN_MainMenu.TabIndex = 12;
            this.BTN_MainMenu.Text = "Main Menu";
            this.BTN_MainMenu.UseVisualStyleBackColor = true;
            this.BTN_MainMenu.Click += new System.EventHandler(this.BTN_MainMenu_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(325, 252);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(83, 33);
            this.btn_back.TabIndex = 30;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // NormPrefixMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 296);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.BTN_MainMenu);
            this.Controls.Add(this.BTN_Un);
            this.Controls.Add(this.BTN_Sub);
            this.Controls.Add(this.BTN_Dis);
            this.Controls.Add(this.BTN_Non);
            this.Controls.Add(this.BTN_Mis);
            this.Controls.Add(this.LB_Select);
            this.Controls.Add(this.LB_Title);
            this.Name = "NormPrefixMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.Label LB_Select;
        private System.Windows.Forms.Button BTN_Mis;
        private System.Windows.Forms.Button BTN_Non;
        private System.Windows.Forms.Button BTN_Dis;
        private System.Windows.Forms.Button BTN_Sub;
        private System.Windows.Forms.Button BTN_Un;
        private System.Windows.Forms.Button BTN_MainMenu;
        private System.Windows.Forms.Button btn_back;
    }
}