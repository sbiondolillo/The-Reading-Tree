namespace ReadingTree
{
    partial class ChooseFromLevelDialog
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
            this.ChosenWordsPromptLabel = new System.Windows.Forms.Label();
            this.btnChooseWordsConfirm = new System.Windows.Forms.Button();
            this.btnChooseWordsCancel = new System.Windows.Forms.Button();
            this.numericUpDownChosenQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChosenQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // ChosenWordsPromptLabel
            // 
            this.ChosenWordsPromptLabel.AutoSize = true;
            this.ChosenWordsPromptLabel.Location = new System.Drawing.Point(31, 9);
            this.ChosenWordsPromptLabel.Name = "ChosenWordsPromptLabel";
            this.ChosenWordsPromptLabel.Size = new System.Drawing.Size(231, 13);
            this.ChosenWordsPromptLabel.TabIndex = 0;
            this.ChosenWordsPromptLabel.Text = "How many words would you like from this level?";
            // 
            // btnChooseWordsConfirm
            // 
            this.btnChooseWordsConfirm.Location = new System.Drawing.Point(32, 91);
            this.btnChooseWordsConfirm.Name = "btnChooseWordsConfirm";
            this.btnChooseWordsConfirm.Size = new System.Drawing.Size(111, 45);
            this.btnChooseWordsConfirm.TabIndex = 1;
            this.btnChooseWordsConfirm.Text = "Confirm";
            this.btnChooseWordsConfirm.UseVisualStyleBackColor = true;
            this.btnChooseWordsConfirm.Click += new System.EventHandler(this.btnChooseWordsConfirm_Click);
            // 
            // btnChooseWordsCancel
            // 
            this.btnChooseWordsCancel.Location = new System.Drawing.Point(149, 91);
            this.btnChooseWordsCancel.Name = "btnChooseWordsCancel";
            this.btnChooseWordsCancel.Size = new System.Drawing.Size(111, 45);
            this.btnChooseWordsCancel.TabIndex = 2;
            this.btnChooseWordsCancel.Text = "Cancel";
            this.btnChooseWordsCancel.UseVisualStyleBackColor = true;
            this.btnChooseWordsCancel.Click += new System.EventHandler(this.btnChooseWordsCancel_Click);
            // 
            // numericUpDownChosenQuantity
            // 
            this.numericUpDownChosenQuantity.Location = new System.Drawing.Point(118, 56);
            this.numericUpDownChosenQuantity.Name = "numericUpDownChosenQuantity";
            this.numericUpDownChosenQuantity.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownChosenQuantity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "(Word will be chosen at random)";
            // 
            // ChooseFromLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(293, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownChosenQuantity);
            this.Controls.Add(this.btnChooseWordsCancel);
            this.Controls.Add(this.btnChooseWordsConfirm);
            this.Controls.Add(this.ChosenWordsPromptLabel);
            this.Name = "ChooseFromLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Words";
            this.Load += new System.EventHandler(this.ChooseFromLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChosenQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChosenWordsPromptLabel;
        private System.Windows.Forms.Button btnChooseWordsConfirm;
        private System.Windows.Forms.Button btnChooseWordsCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownChosenQuantity;
        private System.Windows.Forms.Label label1;
    }
}