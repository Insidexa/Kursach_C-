namespace Kursach
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSelectBySchoolAndBal = new System.Windows.Forms.Panel();
            this.tbBal1 = new System.Windows.Forms.TextBox();
            this.tbNumberSchool = new System.Windows.Forms.TextBox();
            this.labelBal1 = new System.Windows.Forms.Label();
            this.labelNumberSchool = new System.Windows.Forms.Label();
            this.panelChangeForm = new System.Windows.Forms.Panel();
            this.buttonSelectByBalAndSchool = new System.Windows.Forms.Button();
            this.btnSelectByBal = new System.Windows.Forms.Button();
            this.panelSelectByBal = new System.Windows.Forms.Panel();
            this.tbBal2 = new System.Windows.Forms.TextBox();
            this.labelBal2 = new System.Windows.Forms.Label();
            this.panelControlButtons = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.labelResults = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumberSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelHeaderPanels = new System.Windows.Forms.Label();
            this.panelSelectBySchoolAndBal.SuspendLayout();
            this.panelChangeForm.SuspendLayout();
            this.panelSelectByBal.SuspendLayout();
            this.panelControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelectBySchoolAndBal
            // 
            this.panelSelectBySchoolAndBal.Controls.Add(this.tbBal1);
            this.panelSelectBySchoolAndBal.Controls.Add(this.tbNumberSchool);
            this.panelSelectBySchoolAndBal.Controls.Add(this.labelBal1);
            this.panelSelectBySchoolAndBal.Controls.Add(this.labelNumberSchool);
            this.panelSelectBySchoolAndBal.Location = new System.Drawing.Point(12, 123);
            this.panelSelectBySchoolAndBal.Name = "panelSelectBySchoolAndBal";
            this.panelSelectBySchoolAndBal.Size = new System.Drawing.Size(273, 253);
            this.panelSelectBySchoolAndBal.TabIndex = 0;
            // 
            // tbBal1
            // 
            this.tbBal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBal1.Location = new System.Drawing.Point(7, 178);
            this.tbBal1.Name = "tbBal1";
            this.tbBal1.Size = new System.Drawing.Size(263, 29);
            this.tbBal1.TabIndex = 3;
            // 
            // tbNumberSchool
            // 
            this.tbNumberSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumberSchool.Location = new System.Drawing.Point(7, 80);
            this.tbNumberSchool.Name = "tbNumberSchool";
            this.tbNumberSchool.Size = new System.Drawing.Size(263, 29);
            this.tbNumberSchool.TabIndex = 2;
            // 
            // labelBal1
            // 
            this.labelBal1.AutoSize = true;
            this.labelBal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBal1.Location = new System.Drawing.Point(4, 133);
            this.labelBal1.Name = "labelBal1";
            this.labelBal1.Size = new System.Drawing.Size(62, 31);
            this.labelBal1.TabIndex = 1;
            this.labelBal1.Text = "Бал";
            // 
            // labelNumberSchool
            // 
            this.labelNumberSchool.AutoSize = true;
            this.labelNumberSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberSchool.Location = new System.Drawing.Point(4, 33);
            this.labelNumberSchool.Name = "labelNumberSchool";
            this.labelNumberSchool.Size = new System.Drawing.Size(130, 31);
            this.labelNumberSchool.TabIndex = 0;
            this.labelNumberSchool.Text = "№ Школи";
            // 
            // panelChangeForm
            // 
            this.panelChangeForm.Controls.Add(this.buttonSelectByBalAndSchool);
            this.panelChangeForm.Controls.Add(this.btnSelectByBal);
            this.panelChangeForm.Location = new System.Drawing.Point(12, 12);
            this.panelChangeForm.Name = "panelChangeForm";
            this.panelChangeForm.Size = new System.Drawing.Size(273, 50);
            this.panelChangeForm.TabIndex = 1;
            // 
            // buttonSelectByBalAndSchool
            // 
            this.buttonSelectByBalAndSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectByBalAndSchool.Location = new System.Drawing.Point(144, 3);
            this.buttonSelectByBalAndSchool.Name = "buttonSelectByBalAndSchool";
            this.buttonSelectByBalAndSchool.Size = new System.Drawing.Size(126, 44);
            this.buttonSelectByBalAndSchool.TabIndex = 1;
            this.buttonSelectByBalAndSchool.Text = "Вибірка по балу и по № школи";
            this.buttonSelectByBalAndSchool.UseVisualStyleBackColor = true;
            this.buttonSelectByBalAndSchool.Click += new System.EventHandler(this.buttonSelectByBalAndSchool_Click);
            // 
            // btnSelectByBal
            // 
            this.btnSelectByBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectByBal.Location = new System.Drawing.Point(3, 3);
            this.btnSelectByBal.Name = "btnSelectByBal";
            this.btnSelectByBal.Size = new System.Drawing.Size(135, 44);
            this.btnSelectByBal.TabIndex = 0;
            this.btnSelectByBal.Text = "Вибірка по балу";
            this.btnSelectByBal.UseVisualStyleBackColor = true;
            this.btnSelectByBal.Click += new System.EventHandler(this.btnSelectByBal_Click);
            // 
            // panelSelectByBal
            // 
            this.panelSelectByBal.Controls.Add(this.tbBal2);
            this.panelSelectByBal.Controls.Add(this.labelBal2);
            this.panelSelectByBal.Location = new System.Drawing.Point(12, 123);
            this.panelSelectByBal.Name = "panelSelectByBal";
            this.panelSelectByBal.Size = new System.Drawing.Size(276, 264);
            this.panelSelectByBal.TabIndex = 1;
            // 
            // tbBal2
            // 
            this.tbBal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBal2.Location = new System.Drawing.Point(6, 107);
            this.tbBal2.Name = "tbBal2";
            this.tbBal2.Size = new System.Drawing.Size(263, 29);
            this.tbBal2.TabIndex = 5;
            // 
            // labelBal2
            // 
            this.labelBal2.AutoSize = true;
            this.labelBal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBal2.Location = new System.Drawing.Point(3, 62);
            this.labelBal2.Name = "labelBal2";
            this.labelBal2.Size = new System.Drawing.Size(62, 31);
            this.labelBal2.TabIndex = 4;
            this.labelBal2.Text = "Бал";
            // 
            // panelControlButtons
            // 
            this.panelControlButtons.Controls.Add(this.btnSave);
            this.panelControlButtons.Controls.Add(this.btnFind);
            this.panelControlButtons.Controls.Add(this.btnResetSearch);
            this.panelControlButtons.Location = new System.Drawing.Point(12, 379);
            this.panelControlButtons.Name = "panelControlButtons";
            this.panelControlButtons.Size = new System.Drawing.Size(273, 64);
            this.panelControlButtons.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(183, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 47);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(90, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(87, 47);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Знайти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.Location = new System.Drawing.Point(3, 14);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(81, 47);
            this.btnResetSearch.TabIndex = 0;
            this.btnResetSearch.Text = "Скинути пошук";
            this.btnResetSearch.UseVisualStyleBackColor = true;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelResults.Location = new System.Drawing.Point(506, 15);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(131, 39);
            this.labelResults.TabIndex = 3;
            this.labelResults.Text = "Results";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnUserData,
            this.ColumnBal,
            this.ColumnNumberSchool});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(294, 68);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(543, 375);
            this.dataGridView.TabIndex = 4;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "№";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnUserData
            // 
            this.ColumnUserData.HeaderText = "І.П.Б.";
            this.ColumnUserData.Name = "ColumnUserData";
            this.ColumnUserData.ReadOnly = true;
            this.ColumnUserData.Width = 200;
            // 
            // ColumnBal
            // 
            this.ColumnBal.HeaderText = "Бал";
            this.ColumnBal.Name = "ColumnBal";
            this.ColumnBal.ReadOnly = true;
            // 
            // ColumnNumberSchool
            // 
            this.ColumnNumberSchool.HeaderText = "№ Школи";
            this.ColumnNumberSchool.Name = "ColumnNumberSchool";
            this.ColumnNumberSchool.ReadOnly = true;
            // 
            // labelHeaderPanels
            // 
            this.labelHeaderPanels.AutoSize = true;
            this.labelHeaderPanels.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeaderPanels.Location = new System.Drawing.Point(51, 80);
            this.labelHeaderPanels.Name = "labelHeaderPanels";
            this.labelHeaderPanels.Size = new System.Drawing.Size(193, 31);
            this.labelHeaderPanels.TabIndex = 0;
            this.labelHeaderPanels.Text = "Введіть умови";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(852, 449);
            this.Controls.Add(this.panelSelectByBal);
            this.Controls.Add(this.labelHeaderPanels);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.panelControlButtons);
            this.Controls.Add(this.panelChangeForm);
            this.Controls.Add(this.panelSelectBySchoolAndBal);
            this.Name = "Main";
            this.Text = "Main";
            this.panelSelectBySchoolAndBal.ResumeLayout(false);
            this.panelSelectBySchoolAndBal.PerformLayout();
            this.panelChangeForm.ResumeLayout(false);
            this.panelSelectByBal.ResumeLayout(false);
            this.panelSelectByBal.PerformLayout();
            this.panelControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSelectBySchoolAndBal;
        private System.Windows.Forms.Panel panelChangeForm;
        private System.Windows.Forms.Panel panelSelectByBal;
        private System.Windows.Forms.Panel panelControlButtons;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonSelectByBalAndSchool;
        private System.Windows.Forms.Button btnSelectByBal;
        private System.Windows.Forms.Label labelHeaderPanels;
        private System.Windows.Forms.TextBox tbBal1;
        private System.Windows.Forms.TextBox tbNumberSchool;
        private System.Windows.Forms.Label labelBal1;
        private System.Windows.Forms.Label labelNumberSchool;
        private System.Windows.Forms.TextBox tbBal2;
        private System.Windows.Forms.Label labelBal2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnResetSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumberSchool;
    }
}