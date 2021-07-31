
namespace AkritKCFormApplication.Forms
{
    partial class AdminForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.reportGraphAdminForm = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.criteriaTxtBxAdminForm = new System.Windows.Forms.TextBox();
            this.criteriaAddBtnAdminForm = new System.Windows.Forms.Button();
            this.criteriaListViewAdminForm = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.removeCriteriaBtnAdminForm = new System.Windows.Forms.Button();
            this.removeCriteriaTxtBxAdminForm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxAdminForm = new System.Windows.Forms.ComboBox();
            this.generateReportBtnAdminForm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.overallRatingAdminForm = new System.Windows.Forms.Label();
            this.reportListViewAdminForm = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.reportGraphAdminForm)).BeginInit();
            this.SuspendLayout();
            // 
            // reportGraphAdminForm
            // 
            chartArea1.Name = "ChartArea1";
            this.reportGraphAdminForm.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.reportGraphAdminForm.Legends.Add(legend1);
            this.reportGraphAdminForm.Location = new System.Drawing.Point(403, 205);
            this.reportGraphAdminForm.Name = "reportGraphAdminForm";
            this.reportGraphAdminForm.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.reportGraphAdminForm.Size = new System.Drawing.Size(385, 248);
            this.reportGraphAdminForm.TabIndex = 0;
            this.reportGraphAdminForm.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Criteria:";
            // 
            // criteriaTxtBxAdminForm
            // 
            this.criteriaTxtBxAdminForm.Location = new System.Drawing.Point(460, 43);
            this.criteriaTxtBxAdminForm.Name = "criteriaTxtBxAdminForm";
            this.criteriaTxtBxAdminForm.Size = new System.Drawing.Size(125, 20);
            this.criteriaTxtBxAdminForm.TabIndex = 4;
            this.criteriaTxtBxAdminForm.TextChanged += new System.EventHandler(this.criteriaTxtBxAdminForm_TextChanged);
            // 
            // criteriaAddBtnAdminForm
            // 
            this.criteriaAddBtnAdminForm.Location = new System.Drawing.Point(492, 69);
            this.criteriaAddBtnAdminForm.Name = "criteriaAddBtnAdminForm";
            this.criteriaAddBtnAdminForm.Size = new System.Drawing.Size(75, 20);
            this.criteriaAddBtnAdminForm.TabIndex = 5;
            this.criteriaAddBtnAdminForm.Text = "Add";
            this.criteriaAddBtnAdminForm.UseVisualStyleBackColor = true;
            this.criteriaAddBtnAdminForm.Click += new System.EventHandler(this.criteriaAddBtnAdminForm_Click);
            // 
            // criteriaListViewAdminForm
            // 
            this.criteriaListViewAdminForm.HideSelection = false;
            this.criteriaListViewAdminForm.Location = new System.Drawing.Point(591, 40);
            this.criteriaListViewAdminForm.Name = "criteriaListViewAdminForm";
            this.criteriaListViewAdminForm.Size = new System.Drawing.Size(197, 126);
            this.criteriaListViewAdminForm.TabIndex = 6;
            this.criteriaListViewAdminForm.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(567, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Graph";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "List of criterias";
            // 
            // removeCriteriaBtnAdminForm
            // 
            this.removeCriteriaBtnAdminForm.Location = new System.Drawing.Point(492, 146);
            this.removeCriteriaBtnAdminForm.Name = "removeCriteriaBtnAdminForm";
            this.removeCriteriaBtnAdminForm.Size = new System.Drawing.Size(75, 20);
            this.removeCriteriaBtnAdminForm.TabIndex = 13;
            this.removeCriteriaBtnAdminForm.Text = "Remove";
            this.removeCriteriaBtnAdminForm.UseVisualStyleBackColor = true;
            this.removeCriteriaBtnAdminForm.Click += new System.EventHandler(this.removeCriteriaBtnAdminForm_Click);
            // 
            // removeCriteriaTxtBxAdminForm
            // 
            this.removeCriteriaTxtBxAdminForm.Location = new System.Drawing.Point(460, 111);
            this.removeCriteriaTxtBxAdminForm.Name = "removeCriteriaTxtBxAdminForm";
            this.removeCriteriaTxtBxAdminForm.Size = new System.Drawing.Size(125, 20);
            this.removeCriteriaTxtBxAdminForm.TabIndex = 12;
            this.removeCriteriaTxtBxAdminForm.TextChanged += new System.EventHandler(this.removeCriteriaTxtBxAdminForm_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sn:";
            // 
            // comboBoxAdminForm
            // 
            this.comboBoxAdminForm.FormattingEnabled = true;
            this.comboBoxAdminForm.Location = new System.Drawing.Point(12, 40);
            this.comboBoxAdminForm.Name = "comboBoxAdminForm";
            this.comboBoxAdminForm.Size = new System.Drawing.Size(284, 21);
            this.comboBoxAdminForm.TabIndex = 14;
            // 
            // generateReportBtnAdminForm
            // 
            this.generateReportBtnAdminForm.Location = new System.Drawing.Point(302, 40);
            this.generateReportBtnAdminForm.Name = "generateReportBtnAdminForm";
            this.generateReportBtnAdminForm.Size = new System.Drawing.Size(75, 23);
            this.generateReportBtnAdminForm.TabIndex = 15;
            this.generateReportBtnAdminForm.Text = "Generate";
            this.generateReportBtnAdminForm.UseVisualStyleBackColor = true;
            this.generateReportBtnAdminForm.Click += new System.EventHandler(this.generateReportBtnAdminForm_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Overall score:";
            // 
            // overallRatingAdminForm
            // 
            this.overallRatingAdminForm.AutoSize = true;
            this.overallRatingAdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallRatingAdminForm.Location = new System.Drawing.Point(118, 384);
            this.overallRatingAdminForm.Name = "overallRatingAdminForm";
            this.overallRatingAdminForm.Size = new System.Drawing.Size(49, 20);
            this.overallRatingAdminForm.TabIndex = 17;
            this.overallRatingAdminForm.Text = "rating";
            // 
            // reportListViewAdminForm
            // 
            this.reportListViewAdminForm.HideSelection = false;
            this.reportListViewAdminForm.Location = new System.Drawing.Point(12, 67);
            this.reportListViewAdminForm.Name = "reportListViewAdminForm";
            this.reportListViewAdminForm.Size = new System.Drawing.Size(365, 314);
            this.reportListViewAdminForm.TabIndex = 18;
            this.reportListViewAdminForm.UseCompatibleStateImageBehavior = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.reportListViewAdminForm);
            this.Controls.Add(this.overallRatingAdminForm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.generateReportBtnAdminForm);
            this.Controls.Add(this.comboBoxAdminForm);
            this.Controls.Add(this.removeCriteriaBtnAdminForm);
            this.Controls.Add(this.removeCriteriaTxtBxAdminForm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.criteriaListViewAdminForm);
            this.Controls.Add(this.criteriaAddBtnAdminForm);
            this.Controls.Add(this.criteriaTxtBxAdminForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportGraphAdminForm);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportGraphAdminForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart reportGraphAdminForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox criteriaTxtBxAdminForm;
        private System.Windows.Forms.Button criteriaAddBtnAdminForm;
        private System.Windows.Forms.ListView criteriaListViewAdminForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button removeCriteriaBtnAdminForm;
        private System.Windows.Forms.TextBox removeCriteriaTxtBxAdminForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxAdminForm;
        private System.Windows.Forms.Button generateReportBtnAdminForm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label overallRatingAdminForm;
        private System.Windows.Forms.ListView reportListViewAdminForm;
    }
}