namespace MovieCollection
{
    partial class MovieCollection
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
            this.listViewMovies = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.groupBoxSteelbook = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSortTitle = new System.Windows.Forms.Button();
            this.buttonSortYear = new System.Windows.Forms.Button();
            this.buttonSortDir = new System.Windows.Forms.Button();
            this.groupBoxSteelbook.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMovies
            // 
            this.listViewMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitle});
            this.listViewMovies.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewMovies.HideSelection = false;
            this.listViewMovies.Location = new System.Drawing.Point(29, 92);
            this.listViewMovies.Name = "listViewMovies";
            this.listViewMovies.Size = new System.Drawing.Size(142, 379);
            this.listViewMovies.TabIndex = 0;
            this.listViewMovies.UseCompatibleStateImageBehavior = false;
            this.listViewMovies.View = System.Windows.Forms.View.Details;
            this.listViewMovies.Click += new System.EventHandler(this.listViewMovies_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(188, 337);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(254, 92);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TITLE";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(254, 119);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 4;
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(254, 146);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(100, 20);
            this.textBoxDir.TabIndex = 5;
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(254, 173);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFormat.TabIndex = 6;
            // 
            // groupBoxSteelbook
            // 
            this.groupBoxSteelbook.Controls.Add(this.radioButtonNo);
            this.groupBoxSteelbook.Controls.Add(this.radioButtonYes);
            this.groupBoxSteelbook.Location = new System.Drawing.Point(254, 200);
            this.groupBoxSteelbook.Name = "groupBoxSteelbook";
            this.groupBoxSteelbook.Size = new System.Drawing.Size(100, 57);
            this.groupBoxSteelbook.TabIndex = 7;
            this.groupBoxSteelbook.TabStop = false;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(6, 32);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(41, 17);
            this.radioButtonNo.TabIndex = 1;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "NO";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(6, 9);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(46, 17);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "YES";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "YEAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DIRECTOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "FORMAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "MOVIE COLLECTION";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(188, 448);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(279, 448);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 13;
            this.buttonLoad.Text = "LOAD";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "STEELBOOK";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(188, 396);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(188, 367);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            this.columnTitle.Width = 138;
            // 
            // buttonSortTitle
            // 
            this.buttonSortTitle.Location = new System.Drawing.Point(279, 337);
            this.buttonSortTitle.Name = "buttonSortTitle";
            this.buttonSortTitle.Size = new System.Drawing.Size(75, 23);
            this.buttonSortTitle.TabIndex = 17;
            this.buttonSortTitle.Text = "SORT (title)";
            this.buttonSortTitle.UseVisualStyleBackColor = true;
            this.buttonSortTitle.Click += new System.EventHandler(this.buttonSortTitle_Click);
            // 
            // buttonSortYear
            // 
            this.buttonSortYear.Location = new System.Drawing.Point(279, 367);
            this.buttonSortYear.Name = "buttonSortYear";
            this.buttonSortYear.Size = new System.Drawing.Size(75, 23);
            this.buttonSortYear.TabIndex = 18;
            this.buttonSortYear.Text = "SORT (year)";
            this.buttonSortYear.UseVisualStyleBackColor = true;
            this.buttonSortYear.Click += new System.EventHandler(this.buttonSortYear_Click);
            // 
            // buttonSortDir
            // 
            this.buttonSortDir.Location = new System.Drawing.Point(279, 397);
            this.buttonSortDir.Name = "buttonSortDir";
            this.buttonSortDir.Size = new System.Drawing.Size(75, 23);
            this.buttonSortDir.TabIndex = 19;
            this.buttonSortDir.Text = "SORT (dir.)";
            this.buttonSortDir.UseVisualStyleBackColor = true;
            this.buttonSortDir.Click += new System.EventHandler(this.buttonSortDir_Click);
            // 
            // MovieCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 520);
            this.Controls.Add(this.buttonSortDir);
            this.Controls.Add(this.buttonSortYear);
            this.Controls.Add(this.buttonSortTitle);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxSteelbook);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.textBoxDir);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewMovies);
            this.Name = "MovieCollection";
            this.Text = "Movie Collection";
            this.groupBoxSteelbook.ResumeLayout(false);
            this.groupBoxSteelbook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMovies;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.GroupBox groupBoxSteelbook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.Button buttonSortTitle;
        private System.Windows.Forms.Button buttonSortYear;
        private System.Windows.Forms.Button buttonSortDir;
    }
}

