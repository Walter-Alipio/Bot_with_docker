namespace BotDockerizado.Views
{
    partial class GoogleSearchForm
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
            SearchBox = new TextBox();
            label1 = new Label();
            BtnSearch = new Button();
            dataGridViewResults = new DataGridView();
            UrlColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(21, 53);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(553, 23);
            SearchBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 1;
            label1.Text = "What are you looking for?";
            label1.Click += label1_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(586, 53);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(106, 24);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Columns.AddRange(new DataGridViewColumn[] { UrlColumn });
            dataGridViewResults.Location = new Point(21, 97);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.Size = new Size(670, 304);
            dataGridViewResults.TabIndex = 3;
            // 
            // UrlColumn
            // 
            UrlColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UrlColumn.HeaderText = "Results";
            UrlColumn.Name = "UrlColumn";
            // 
            // GoogleSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 450);
            Controls.Add(dataGridViewResults);
            Controls.Add(BtnSearch);
            Controls.Add(label1);
            Controls.Add(SearchBox);
            Name = "GoogleSearchForm";
            Text = "GoogleSearchForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBox;
        private Label label1;
        private Button BtnSearch;
        private DataGridView dataGridViewResults;
        private DataGridViewTextBoxColumn UrlColumn;
    }
}