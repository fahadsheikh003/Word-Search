namespace Word_Search
{
    partial class ResultWindow
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
            this.AlgorithmLabel = new System.Windows.Forms.Label();
            this.FindLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.AlgorithmEntry = new System.Windows.Forms.TextBox();
            this.PathEntry = new System.Windows.Forms.TextBox();
            this.FindEntry = new System.Windows.Forms.TextBox();
            this.ResultEntry = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.NotepadppCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // AlgorithmLabel
            // 
            this.AlgorithmLabel.AutoSize = true;
            this.AlgorithmLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlgorithmLabel.Location = new System.Drawing.Point(25, 21);
            this.AlgorithmLabel.Name = "AlgorithmLabel";
            this.AlgorithmLabel.Size = new System.Drawing.Size(81, 20);
            this.AlgorithmLabel.TabIndex = 0;
            this.AlgorithmLabel.Text = "Algorithm";
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FindLabel.Location = new System.Drawing.Point(25, 81);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(52, 20);
            this.FindLabel.TabIndex = 1;
            this.FindLabel.Text = "Query";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PathLabel.Location = new System.Drawing.Point(25, 51);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(41, 20);
            this.PathLabel.TabIndex = 2;
            this.PathLabel.Text = "Path";
            // 
            // AlgorithmEntry
            // 
            this.AlgorithmEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlgorithmEntry.Location = new System.Drawing.Point(125, 19);
            this.AlgorithmEntry.Name = "AlgorithmEntry";
            this.AlgorithmEntry.ReadOnly = true;
            this.AlgorithmEntry.Size = new System.Drawing.Size(530, 27);
            this.AlgorithmEntry.TabIndex = 3;
            // 
            // PathEntry
            // 
            this.PathEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathEntry.Location = new System.Drawing.Point(125, 49);
            this.PathEntry.Name = "PathEntry";
            this.PathEntry.ReadOnly = true;
            this.PathEntry.Size = new System.Drawing.Size(530, 27);
            this.PathEntry.TabIndex = 4;
            // 
            // FindEntry
            // 
            this.FindEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FindEntry.Location = new System.Drawing.Point(125, 79);
            this.FindEntry.Name = "FindEntry";
            this.FindEntry.ReadOnly = true;
            this.FindEntry.Size = new System.Drawing.Size(530, 27);
            this.FindEntry.TabIndex = 5;
            // 
            // ResultEntry
            // 
            this.ResultEntry.AllowUserToAddRows = false;
            this.ResultEntry.AllowUserToDeleteRows = false;
            this.ResultEntry.BackgroundColor = System.Drawing.Color.White;
            this.ResultEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Row,
            this.Column,
            this.Count});
            this.ResultEntry.Location = new System.Drawing.Point(25, 151);
            this.ResultEntry.Name = "ResultEntry";
            this.ResultEntry.RowHeadersVisible = false;
            this.ResultEntry.RowHeadersWidth = 51;
            this.ResultEntry.RowTemplate.Height = 29;
            this.ResultEntry.RowTemplate.ReadOnly = true;
            this.ResultEntry.Size = new System.Drawing.Size(630, 273);
            this.ResultEntry.TabIndex = 6;
            this.ResultEntry.CellContentClick += ResultEntry_CellContentClick;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.HeaderText = "File Name";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // Row
            // 
            this.Row.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Row.HeaderText = "Row";
            this.Row.MinimumWidth = 6;
            this.Row.Name = "Row";
            this.Row.ReadOnly = true;
            this.Row.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Row.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column
            // 
            this.Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column.HeaderText = "Column";
            this.Column.MinimumWidth = 6;
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.HeaderText = "Count in File";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(25, 123);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(65, 25);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Result";
            // 
            // NotepadppCheck
            // 
            this.NotepadppCheck.AutoSize = true;
            this.NotepadppCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NotepadppCheck.Location = new System.Drawing.Point(492, 124);
            this.NotepadppCheck.Name = "NotepadppCheck";
            this.NotepadppCheck.Size = new System.Drawing.Size(172, 24);
            this.NotepadppCheck.TabIndex = 8;
            this.NotepadppCheck.Text = "Open in Notepad++";
            this.NotepadppCheck.UseVisualStyleBackColor = true;
            // 
            // ResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.NotepadppCheck);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultEntry);
            this.Controls.Add(this.FindEntry);
            this.Controls.Add(this.PathEntry);
            this.Controls.Add(this.AlgorithmEntry);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.FindLabel);
            this.Controls.Add(this.AlgorithmLabel);
            this.MaximizeBox = false;
            this.Name = "ResultWindow";
            this.Text = "Result – Word Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ResultEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Label AlgorithmLabel;
        private Label FindLabel;
        private Label PathLabel;
        private TextBox AlgorithmEntry;
        private TextBox PathEntry;
        private TextBox FindEntry;
        private DataGridView ResultEntry;
        private Label ResultLabel;
        private DataGridViewButtonColumn FileName;
        private DataGridViewTextBoxColumn Row;
        private DataGridViewTextBoxColumn Column;
        private DataGridViewTextBoxColumn Count;
        private CheckBox NotepadppCheck;
    }
}