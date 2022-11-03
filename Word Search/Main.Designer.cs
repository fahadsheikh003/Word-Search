namespace Word_Search
{
    partial class SearchWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AlgorithmEntry = new System.Windows.Forms.ComboBox();
            this.AlgorithmLabel = new System.Windows.Forms.Label();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindEntry = new System.Windows.Forms.TextBox();
            this.CaseEntry = new System.Windows.Forms.CheckBox();
            this.WordEntry = new System.Windows.Forms.CheckBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathEntry = new System.Windows.Forms.TextBox();
            this.PathButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlgorithmEntry
            // 
            this.AlgorithmEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgorithmEntry.FormattingEnabled = true;
            this.AlgorithmEntry.Items.AddRange(new object[] {
            "Brute-Force",
            "Rabin-Karp",
            "Knuth–Morris–Pratt"});
            this.AlgorithmEntry.Location = new System.Drawing.Point(142, 16);
            this.AlgorithmEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AlgorithmEntry.MaxDropDownItems = 5;
            this.AlgorithmEntry.Name = "AlgorithmEntry";
            this.AlgorithmEntry.Size = new System.Drawing.Size(230, 23);
            this.AlgorithmEntry.TabIndex = 0;
            this.AlgorithmEntry.SelectedIndex = 0;
            // 
            // AlgorithmLabel
            // 
            this.AlgorithmLabel.AutoSize = true;
            this.AlgorithmLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlgorithmLabel.Location = new System.Drawing.Point(29, 18);
            this.AlgorithmLabel.Name = "AlgorithmLabel";
            this.AlgorithmLabel.Size = new System.Drawing.Size(63, 15);
            this.AlgorithmLabel.TabIndex = 1;
            this.AlgorithmLabel.Text = "Algorithm";
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FindLabel.Location = new System.Drawing.Point(29, 82);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(63, 15);
            this.FindLabel.TabIndex = 2;
            this.FindLabel.Text = "Find What";
            // 
            // FindEntry
            // 
            this.FindEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FindEntry.Location = new System.Drawing.Point(142, 80);
            this.FindEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindEntry.Name = "FindEntry";
            this.FindEntry.Size = new System.Drawing.Size(230, 23);
            this.FindEntry.TabIndex = 3;
            // 
            // CaseEntry
            // 
            this.CaseEntry.AutoSize = true;
            this.CaseEntry.Location = new System.Drawing.Point(29, 117);
            this.CaseEntry.Name = "CaseEntry";
            this.CaseEntry.Size = new System.Drawing.Size(88, 19);
            this.CaseEntry.TabIndex = 4;
            this.CaseEntry.Text = "Match Case";
            this.CaseEntry.UseVisualStyleBackColor = true;
            // 
            // WordEntry
            // 
            this.WordEntry.AutoSize = true;
            this.WordEntry.Location = new System.Drawing.Point(123, 117);
            this.WordEntry.Name = "WordEntry";
            this.WordEntry.Size = new System.Drawing.Size(129, 19);
            this.WordEntry.TabIndex = 5;
            this.WordEntry.Text = "Match Whole Word";
            this.WordEntry.UseVisualStyleBackColor = true;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PathLabel.Location = new System.Drawing.Point(29, 50);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(32, 15);
            this.PathLabel.TabIndex = 6;
            this.PathLabel.Text = "Path";
            // 
            // PathEntry
            // 
            this.PathEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathEntry.Location = new System.Drawing.Point(142, 48);
            this.PathEntry.Name = "PathEntry";
            this.PathEntry.Size = new System.Drawing.Size(171, 23);
            this.PathEntry.TabIndex = 7;
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(315, 48);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(57, 23);
            this.PathButton.TabIndex = 8;
            this.PathButton.Text = "Browse";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FindButton.Location = new System.Drawing.Point(297, 141);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 27);
            this.FindButton.TabIndex = 9;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 183);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.PathEntry);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.WordEntry);
            this.Controls.Add(this.CaseEntry);
            this.Controls.Add(this.FindEntry);
            this.Controls.Add(this.FindLabel);
            this.Controls.Add(this.AlgorithmLabel);
            this.Controls.Add(this.AlgorithmEntry);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SearchWindow";
            this.Text = "Word Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox AlgorithmEntry;
        private Label AlgorithmLabel;
        private Label FindLabel;
        private TextBox FindEntry;
        private CheckBox CaseEntry;
        private CheckBox WordEntry;
        private Label PathLabel;
        private TextBox PathEntry;
        private Button PathButton;
        private Button FindButton;
    }
}