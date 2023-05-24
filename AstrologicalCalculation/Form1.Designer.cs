namespace AstrologicalCalculation
{
    partial class Form1
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
            this.ListBoxOutput = new System.Windows.Forms.ListBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonMidExtreme = new System.Windows.Forms.Button();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxOutput
            // 
            this.ListBoxOutput.FormattingEnabled = true;
            this.ListBoxOutput.Location = new System.Drawing.Point(466, 41);
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.Size = new System.Drawing.Size(296, 355);
            this.ListBoxOutput.TabIndex = 0;
            this.ListBoxOutput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxOutput_MouseClick);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(156, 162);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(198, 44);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(156, 223);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(198, 44);
            this.ButtonEdit.TabIndex = 2;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(156, 288);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(198, 44);
            this.ButtonSort.TabIndex = 3;
            this.ButtonSort.Text = "Sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(110, 41);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(278, 20);
            this.TextBoxInput.TabIndex = 4;
            this.TextBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // ButtonMidExtreme
            // 
            this.ButtonMidExtreme.Location = new System.Drawing.Point(42, 358);
            this.ButtonMidExtreme.Name = "ButtonMidExtreme";
            this.ButtonMidExtreme.Size = new System.Drawing.Size(114, 37);
            this.ButtonMidExtreme.TabIndex = 5;
            this.ButtonMidExtreme.Text = "Mid-Extreme";
            this.ButtonMidExtreme.UseVisualStyleBackColor = true;
            // 
            // ButtonMode
            // 
            this.ButtonMode.Location = new System.Drawing.Point(321, 358);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(114, 37);
            this.ButtonMode.TabIndex = 6;
            this.ButtonMode.Text = "Mode";
            this.ButtonMode.UseVisualStyleBackColor = true;
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.Location = new System.Drawing.Point(42, 94);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(114, 37);
            this.ButtonAverage.TabIndex = 7;
            this.ButtonAverage.Text = "Average";
            this.ButtonAverage.UseVisualStyleBackColor = true;
            // 
            // ButtonRange
            // 
            this.ButtonRange.Location = new System.Drawing.Point(321, 94);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(114, 37);
            this.ButtonRange.TabIndex = 8;
            this.ButtonRange.Text = "Range";
            this.ButtonRange.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonRange);
            this.Controls.Add(this.ButtonAverage);
            this.Controls.Add(this.ButtonMode);
            this.Controls.Add(this.ButtonMidExtreme);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ListBoxOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxOutput;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button ButtonMidExtreme;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.Button ButtonRange;
    }
}

