namespace ReadingTree
{
    partial class ContractionsMenu
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
            this.btnTch = new System.Windows.Forms.Button();
            this.btnContractionsNonPhonetic = new System.Windows.Forms.Button();
            this.buttonContractionsPhonetic = new System.Windows.Forms.Button();
            this.DigraphPromptLabel = new System.Windows.Forms.Label();
            this.DigraphLabel = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTch
            // 
            this.btnTch.Location = new System.Drawing.Point(131, 114);
            this.btnTch.Margin = new System.Windows.Forms.Padding(2);
            this.btnTch.Name = "btnTch";
            this.btnTch.Size = new System.Drawing.Size(83, 45);
            this.btnTch.TabIndex = 19;
            this.btnTch.Text = "Contractions";
            this.btnTch.UseVisualStyleBackColor = true;
            this.btnTch.Click += new System.EventHandler(this.btnTch_Click);
            // 
            // btnContractionsNonPhonetic
            // 
            this.btnContractionsNonPhonetic.Location = new System.Drawing.Point(219, 114);
            this.btnContractionsNonPhonetic.Margin = new System.Windows.Forms.Padding(2);
            this.btnContractionsNonPhonetic.Name = "btnContractionsNonPhonetic";
            this.btnContractionsNonPhonetic.Size = new System.Drawing.Size(83, 45);
            this.btnContractionsNonPhonetic.TabIndex = 20;
            this.btnContractionsNonPhonetic.Text = "Contractions non-phonetic";
            this.btnContractionsNonPhonetic.UseVisualStyleBackColor = true;
            this.btnContractionsNonPhonetic.Click += new System.EventHandler(this.btnContractionsNonPhonetic_Click);
            // 
            // buttonContractionsPhonetic
            // 
            this.buttonContractionsPhonetic.Location = new System.Drawing.Point(305, 114);
            this.buttonContractionsPhonetic.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContractionsPhonetic.Name = "buttonContractionsPhonetic";
            this.buttonContractionsPhonetic.Size = new System.Drawing.Size(83, 45);
            this.buttonContractionsPhonetic.TabIndex = 21;
            this.buttonContractionsPhonetic.Text = "Contractions phonetic";
            this.buttonContractionsPhonetic.UseVisualStyleBackColor = true;
            this.buttonContractionsPhonetic.Click += new System.EventHandler(this.buttonContractionsPhonetic_Click);
            // 
            // DigraphPromptLabel
            // 
            this.DigraphPromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DigraphPromptLabel.AutoSize = true;
            this.DigraphPromptLabel.Location = new System.Drawing.Point(155, 69);
            this.DigraphPromptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DigraphPromptLabel.Name = "DigraphPromptLabel";
            this.DigraphPromptLabel.Size = new System.Drawing.Size(213, 13);
            this.DigraphPromptLabel.TabIndex = 24;
            this.DigraphPromptLabel.Text = "Please select a category below to continue!";
            // 
            // DigraphLabel
            // 
            this.DigraphLabel.AutoSize = true;
            this.DigraphLabel.Location = new System.Drawing.Point(225, 32);
            this.DigraphLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DigraphLabel.Name = "DigraphLabel";
            this.DigraphLabel.Size = new System.Drawing.Size(69, 13);
            this.DigraphLabel.TabIndex = 23;
            this.DigraphLabel.Text = "Contractions ";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(338, 310);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(83, 33);
            this.btnMainMenu.TabIndex = 25;
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
            this.btn_back.TabIndex = 27;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ContractionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.DigraphPromptLabel);
            this.Controls.Add(this.DigraphLabel);
            this.Controls.Add(this.buttonContractionsPhonetic);
            this.Controls.Add(this.btnContractionsNonPhonetic);
            this.Controls.Add(this.btnTch);
            this.Name = "ContractionsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Reading Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTch;
        private System.Windows.Forms.Button btnContractionsNonPhonetic;
        private System.Windows.Forms.Button buttonContractionsPhonetic;
        private System.Windows.Forms.Label DigraphPromptLabel;
        private System.Windows.Forms.Label DigraphLabel;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btn_back;
    }
}