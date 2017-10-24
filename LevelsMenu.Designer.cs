namespace ReadingTree
{
    partial class LevelsMenu
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
            this.level1Box = new System.Windows.Forms.ListBox();
            this.level1Label = new System.Windows.Forms.Label();
            this.level2Label = new System.Windows.Forms.Label();
            this.level4Label = new System.Windows.Forms.Label();
            this.level5label = new System.Windows.Forms.Label();
            this.level3Label = new System.Windows.Forms.Label();
            this.level2Box = new System.Windows.Forms.ListBox();
            this.level3Box = new System.Windows.Forms.ListBox();
            this.level4Box = new System.Windows.Forms.ListBox();
            this.level5Box = new System.Windows.Forms.ListBox();
            this.headerName = new System.Windows.Forms.GroupBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.printlistButton = new System.Windows.Forms.Button();
            this.scrambleButton = new System.Windows.Forms.Button();
            this.wordsList = new System.Windows.Forms.ListBox();
            this.wordList = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.headerName.SuspendLayout();
            this.SuspendLayout();
            // 
            // level1Box
            // 
            this.level1Box.FormattingEnabled = true;
            this.level1Box.Location = new System.Drawing.Point(37, 40);
            this.level1Box.Name = "level1Box";
            this.level1Box.Size = new System.Drawing.Size(73, 121);
            this.level1Box.TabIndex = 0;
            // 
            // level1Label
            // 
            this.level1Label.AutoSize = true;
            this.level1Label.Location = new System.Drawing.Point(34, 24);
            this.level1Label.Name = "level1Label";
            this.level1Label.Size = new System.Drawing.Size(76, 13);
            this.level1Label.TabIndex = 1;
            this.level1Label.Text = "Level 1 Words";
            // 
            // level2Label
            // 
            this.level2Label.AutoSize = true;
            this.level2Label.Location = new System.Drawing.Point(115, 24);
            this.level2Label.Name = "level2Label";
            this.level2Label.Size = new System.Drawing.Size(76, 13);
            this.level2Label.TabIndex = 2;
            this.level2Label.Text = "Level 2 Words";
            // 
            // level4Label
            // 
            this.level4Label.AutoSize = true;
            this.level4Label.Location = new System.Drawing.Point(277, 24);
            this.level4Label.Name = "level4Label";
            this.level4Label.Size = new System.Drawing.Size(76, 13);
            this.level4Label.TabIndex = 3;
            this.level4Label.Text = "Level 4 Words";
            // 
            // level5label
            // 
            this.level5label.AutoSize = true;
            this.level5label.Location = new System.Drawing.Point(358, 24);
            this.level5label.Name = "level5label";
            this.level5label.Size = new System.Drawing.Size(76, 13);
            this.level5label.TabIndex = 4;
            this.level5label.Text = "Level 5 Words";
            // 
            // level3Label
            // 
            this.level3Label.AutoSize = true;
            this.level3Label.Location = new System.Drawing.Point(196, 24);
            this.level3Label.Name = "level3Label";
            this.level3Label.Size = new System.Drawing.Size(76, 13);
            this.level3Label.TabIndex = 5;
            this.level3Label.Text = "Level 3 Words";
            this.level3Label.Click += new System.EventHandler(this.label4_Click);
            // 
            // level2Box
            // 
            this.level2Box.FormattingEnabled = true;
            this.level2Box.Location = new System.Drawing.Point(118, 40);
            this.level2Box.Name = "level2Box";
            this.level2Box.Size = new System.Drawing.Size(73, 121);
            this.level2Box.TabIndex = 6;
            // 
            // level3Box
            // 
            this.level3Box.FormattingEnabled = true;
            this.level3Box.Location = new System.Drawing.Point(199, 40);
            this.level3Box.Name = "level3Box";
            this.level3Box.Size = new System.Drawing.Size(73, 121);
            this.level3Box.TabIndex = 7;
            // 
            // level4Box
            // 
            this.level4Box.FormattingEnabled = true;
            this.level4Box.Location = new System.Drawing.Point(280, 40);
            this.level4Box.Name = "level4Box";
            this.level4Box.Size = new System.Drawing.Size(73, 121);
            this.level4Box.TabIndex = 8;
            // 
            // level5Box
            // 
            this.level5Box.FormattingEnabled = true;
            this.level5Box.Location = new System.Drawing.Point(361, 40);
            this.level5Box.Name = "level5Box";
            this.level5Box.Size = new System.Drawing.Size(73, 121);
            this.level5Box.TabIndex = 9;
            // 
            // headerName
            // 
            this.headerName.Controls.Add(this.addButton);
            this.headerName.Controls.Add(this.deleteButton);
            this.headerName.Controls.Add(this.level5Box);
            this.headerName.Controls.Add(this.level4Box);
            this.headerName.Controls.Add(this.level3Box);
            this.headerName.Controls.Add(this.level2Box);
            this.headerName.Controls.Add(this.level3Label);
            this.headerName.Controls.Add(this.level5label);
            this.headerName.Controls.Add(this.level4Label);
            this.headerName.Controls.Add(this.level2Label);
            this.headerName.Controls.Add(this.level1Label);
            this.headerName.Controls.Add(this.level1Box);
            this.headerName.Location = new System.Drawing.Point(22, 12);
            this.headerName.Name = "headerName";
            this.headerName.Size = new System.Drawing.Size(476, 219);
            this.headerName.TabIndex = 10;
            this.headerName.TabStop = false;
            this.headerName.Text = "Change this to applicable header title";
            this.headerName.Enter += new System.EventHandler(this.headerName_Enter);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(425, 298);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(83, 45);
            this.btnMainMenu.TabIndex = 20;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(151, 166);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 45);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Add Word";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(238, 166);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(83, 45);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "Delete Word";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // printlistButton
            // 
            this.printlistButton.Location = new System.Drawing.Point(425, 249);
            this.printlistButton.Margin = new System.Windows.Forms.Padding(2);
            this.printlistButton.Name = "printlistButton";
            this.printlistButton.Size = new System.Drawing.Size(83, 45);
            this.printlistButton.TabIndex = 23;
            this.printlistButton.Text = "Print List";
            this.printlistButton.UseVisualStyleBackColor = true;
            // 
            // scrambleButton
            // 
            this.scrambleButton.Location = new System.Drawing.Point(11, 249);
            this.scrambleButton.Margin = new System.Windows.Forms.Padding(2);
            this.scrambleButton.Name = "scrambleButton";
            this.scrambleButton.Size = new System.Drawing.Size(83, 45);
            this.scrambleButton.TabIndex = 24;
            this.scrambleButton.Text = "Scramble List";
            this.scrambleButton.UseVisualStyleBackColor = true;
            // 
            // wordsList
            // 
            this.wordsList.FormattingEnabled = true;
            this.wordsList.Location = new System.Drawing.Point(99, 260);
            this.wordsList.MultiColumn = true;
            this.wordsList.Name = "wordsList";
            this.wordsList.Size = new System.Drawing.Size(321, 82);
            this.wordsList.TabIndex = 25;
            // 
            // wordList
            // 
            this.wordList.AutoSize = true;
            this.wordList.Location = new System.Drawing.Point(96, 244);
            this.wordList.Name = "wordList";
            this.wordList.Size = new System.Drawing.Size(72, 13);
            this.wordList.TabIndex = 26;
            this.wordList.Text = "Words Added";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(11, 298);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(83, 45);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Clear List";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // LevelsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.wordList);
            this.Controls.Add(this.wordsList);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.headerName);
            this.Controls.Add(this.printlistButton);
            this.Controls.Add(this.scrambleButton);
            this.Name = "LevelsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select words";
            this.Load += new System.EventHandler(this.LevelsMenu_Load);
            this.headerName.ResumeLayout(false);
            this.headerName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox level1Box;
        private System.Windows.Forms.Label level1Label;
        private System.Windows.Forms.Label level2Label;
        private System.Windows.Forms.Label level4Label;
        private System.Windows.Forms.Label level5label;
        private System.Windows.Forms.Label level3Label;
        private System.Windows.Forms.ListBox level2Box;
        private System.Windows.Forms.ListBox level3Box;
        private System.Windows.Forms.ListBox level4Box;
        private System.Windows.Forms.ListBox level5Box;
        private System.Windows.Forms.GroupBox headerName;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button printlistButton;
        private System.Windows.Forms.Button scrambleButton;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.ListBox wordsList;
        private System.Windows.Forms.Label wordList;
        private System.Windows.Forms.Button clearButton;
    }
}