namespace ReadingTree
{
    partial class MiscMenu
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
            this.BTN_Compound = new System.Windows.Forms.Button();
            this.BTN_syllable_division = new System.Windows.Forms.Button();
            this.BTN_MainMenu = new System.Windows.Forms.Button();
            this.LB_Title = new System.Windows.Forms.Label();
            this.LB_Select = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Compound
            // 
            this.BTN_Compound.Location = new System.Drawing.Point(173, 118);
            this.BTN_Compound.Name = "BTN_Compound";
            this.BTN_Compound.Size = new System.Drawing.Size(83, 45);
            this.BTN_Compound.TabIndex = 0;
            this.BTN_Compound.Text = "Compound Words";
            this.BTN_Compound.UseVisualStyleBackColor = true;
            this.BTN_Compound.Click += new System.EventHandler(this.BTN_Compound_Click);
            // 
            // BTN_syllable_division
            // 
            this.BTN_syllable_division.Location = new System.Drawing.Point(262, 118);
            this.BTN_syllable_division.Name = "BTN_syllable_division";
            this.BTN_syllable_division.Size = new System.Drawing.Size(83, 45);
            this.BTN_syllable_division.TabIndex = 1;
            this.BTN_syllable_division.Text = "V/V syllable division";
            this.BTN_syllable_division.UseVisualStyleBackColor = true;
            this.BTN_syllable_division.Click += new System.EventHandler(this.BTN_Crete_Click);
            // 
            // BTN_MainMenu
            // 
            this.BTN_MainMenu.Location = new System.Drawing.Point(337, 309);
            this.BTN_MainMenu.Name = "BTN_MainMenu";
            this.BTN_MainMenu.Size = new System.Drawing.Size(83, 33);
            this.BTN_MainMenu.TabIndex = 2;
            this.BTN_MainMenu.Text = "Main Menu";
            this.BTN_MainMenu.UseVisualStyleBackColor = true;
            this.BTN_MainMenu.Click += new System.EventHandler(this.BTN_MainMenu_Click);
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.Location = new System.Drawing.Point(244, 42);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(29, 13);
            this.LB_Title.TabIndex = 3;
            this.LB_Title.Text = "Misc";
            // 
            // LB_Select
            // 
            this.LB_Select.AutoSize = true;
            this.LB_Select.Location = new System.Drawing.Point(154, 69);
            this.LB_Select.Name = "LB_Select";
            this.LB_Select.Size = new System.Drawing.Size(213, 13);
            this.LB_Select.TabIndex = 4;
            this.LB_Select.Text = "Please select a category below to continue!";
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
            // MiscMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.LB_Select);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.BTN_MainMenu);
            this.Controls.Add(this.BTN_syllable_division);
            this.Controls.Add(this.BTN_Compound);
            this.Name = "MiscMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Compound;
        private System.Windows.Forms.Button BTN_syllable_division;
        private System.Windows.Forms.Button BTN_MainMenu;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.Label LB_Select;
        private System.Windows.Forms.Button btn_back;
    }
}