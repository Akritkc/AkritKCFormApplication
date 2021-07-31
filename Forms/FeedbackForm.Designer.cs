
namespace AkritKCFormApplication.Forms
{
    partial class FeedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerNameTxtBx = new System.Windows.Forms.TextBox();
            this.customerNumberTxtBx = new System.Windows.Forms.TextBox();
            this.customerEmailTxtBx = new System.Windows.Forms.TextBox();
            this.reviewCriteriaGrid = new System.Windows.Forms.DataGridView();
            this.submitBtnReviewForm = new System.Windows.Forms.Button();
            this.clearBtnReviewForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reviewCriteriaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Email:";
            // 
            // customerNameTxtBx
            // 
            this.customerNameTxtBx.Location = new System.Drawing.Point(12, 184);
            this.customerNameTxtBx.Name = "customerNameTxtBx";
            this.customerNameTxtBx.Size = new System.Drawing.Size(292, 20);
            this.customerNameTxtBx.TabIndex = 3;
            this.customerNameTxtBx.TextChanged += new System.EventHandler(this.customerNameTxtBx_TextChanged);
            // 
            // customerNumberTxtBx
            // 
            this.customerNumberTxtBx.Location = new System.Drawing.Point(14, 261);
            this.customerNumberTxtBx.Name = "customerNumberTxtBx";
            this.customerNumberTxtBx.Size = new System.Drawing.Size(292, 20);
            this.customerNumberTxtBx.TabIndex = 4;
            this.customerNumberTxtBx.TextChanged += new System.EventHandler(this.customerNumberTxtBx_TextChanged);
            // 
            // customerEmailTxtBx
            // 
            this.customerEmailTxtBx.Location = new System.Drawing.Point(14, 347);
            this.customerEmailTxtBx.Name = "customerEmailTxtBx";
            this.customerEmailTxtBx.Size = new System.Drawing.Size(292, 20);
            this.customerEmailTxtBx.TabIndex = 5;
            this.customerEmailTxtBx.TextChanged += new System.EventHandler(this.customerEmailTxtBx_TextChanged);
            // 
            // reviewCriteriaGrid
            // 
            this.reviewCriteriaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewCriteriaGrid.Location = new System.Drawing.Point(312, 106);
            this.reviewCriteriaGrid.Name = "reviewCriteriaGrid";
            this.reviewCriteriaGrid.Size = new System.Drawing.Size(476, 273);
            this.reviewCriteriaGrid.TabIndex = 6;
            this.reviewCriteriaGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reviewCriteriaGrid_CellContentClick);
            this.reviewCriteriaGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.reviewCriteriaGrid_RowEnter);
            // 
            // submitBtnReviewForm
            // 
            this.submitBtnReviewForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtnReviewForm.Location = new System.Drawing.Point(416, 407);
            this.submitBtnReviewForm.Name = "submitBtnReviewForm";
            this.submitBtnReviewForm.Size = new System.Drawing.Size(75, 31);
            this.submitBtnReviewForm.TabIndex = 7;
            this.submitBtnReviewForm.Text = "Submit";
            this.submitBtnReviewForm.UseVisualStyleBackColor = true;
            this.submitBtnReviewForm.Click += new System.EventHandler(this.submitBtnReviewForm_Click);
            // 
            // clearBtnReviewForm
            // 
            this.clearBtnReviewForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtnReviewForm.Location = new System.Drawing.Point(623, 407);
            this.clearBtnReviewForm.Name = "clearBtnReviewForm";
            this.clearBtnReviewForm.Size = new System.Drawing.Size(75, 31);
            this.clearBtnReviewForm.TabIndex = 8;
            this.clearBtnReviewForm.Text = "Clear";
            this.clearBtnReviewForm.UseVisualStyleBackColor = true;
            this.clearBtnReviewForm.Click += new System.EventHandler(this.clearBtnReviewForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Send us your Feed Back !";
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clearBtnReviewForm);
            this.Controls.Add(this.submitBtnReviewForm);
            this.Controls.Add(this.reviewCriteriaGrid);
            this.Controls.Add(this.customerEmailTxtBx);
            this.Controls.Add(this.customerNumberTxtBx);
            this.Controls.Add(this.customerNameTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "FeedbackForm";
            this.Text = "ReviewForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reviewCriteriaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerNameTxtBx;
        private System.Windows.Forms.TextBox customerNumberTxtBx;
        private System.Windows.Forms.TextBox customerEmailTxtBx;
        private System.Windows.Forms.DataGridView reviewCriteriaGrid;
        private System.Windows.Forms.Button submitBtnReviewForm;
        private System.Windows.Forms.Button clearBtnReviewForm;
        private System.Windows.Forms.Label label4;
    }
}