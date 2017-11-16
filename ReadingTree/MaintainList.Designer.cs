namespace ReadingTree
{
    partial class MaintainList
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.ListBox();
            this.GroupLbl = new System.Windows.Forms.Label();
            this.Inputbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(21, 464);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 48);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add Word";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(133, 464);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(100, 48);
            this.DelBtn.TabIndex = 1;
            this.DelBtn.Text = "Delete Word";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(246, 464);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(100, 48);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Return";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.FormattingEnabled = true;
            this.GroupBox.Location = new System.Drawing.Point(21, 53);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(325, 368);
            this.GroupBox.TabIndex = 3;
            // 
            // GroupLbl
            // 
            this.GroupLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GroupLbl.AutoSize = true;
            this.GroupLbl.Location = new System.Drawing.Point(150, 19);
            this.GroupLbl.Name = "GroupLbl";
            this.GroupLbl.Size = new System.Drawing.Size(66, 13);
            this.GroupLbl.TabIndex = 4;
            this.GroupLbl.Text = "group_name";
            this.GroupLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inputbox
            // 
            this.Inputbox.Location = new System.Drawing.Point(108, 431);
            this.Inputbox.Name = "Inputbox";
            this.Inputbox.Size = new System.Drawing.Size(151, 20);
            this.Inputbox.TabIndex = 5;
            // 
            // MaintainList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 530);
            this.Controls.Add(this.Inputbox);
            this.Controls.Add(this.GroupLbl);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "MaintainList";
            this.Text = "MaintainList";
            this.Load += new System.EventHandler(this.MaintainList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ListBox GroupBox;
        private System.Windows.Forms.Label GroupLbl;
        private System.Windows.Forms.TextBox Inputbox;
    }
}