namespace GUI_Exercise
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisRec = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxFrstNme = new System.Windows.Forms.TextBox();
            this.txtBoxLstNme = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnClr = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 381);
            this.listBox1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 395);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 43);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnDisRec);
            this.flowLayoutPanel1.Controls.Add(this.btnClr);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 37);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisRec
            // 
            this.btnDisRec.Location = new System.Drawing.Point(99, 3);
            this.btnDisRec.Name = "btnDisRec";
            this.btnDisRec.Size = new System.Drawing.Size(90, 34);
            this.btnDisRec.TabIndex = 2;
            this.btnDisRec.Text = "Display All Records";
            this.btnDisRec.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.78759F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.21241F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxFrstNme, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxLstNme, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxAge, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(369, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(419, 125);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBoxFrstNme
            // 
            this.txtBoxFrstNme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxFrstNme.Location = new System.Drawing.Point(132, 3);
            this.txtBoxFrstNme.Name = "txtBoxFrstNme";
            this.txtBoxFrstNme.Size = new System.Drawing.Size(284, 20);
            this.txtBoxFrstNme.TabIndex = 3;
            this.txtBoxFrstNme.TextChanged += new System.EventHandler(this.txtBoxFrstNme_TextChanged);
            // 
            // txtBoxLstNme
            // 
            this.txtBoxLstNme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxLstNme.Location = new System.Drawing.Point(132, 44);
            this.txtBoxLstNme.Name = "txtBoxLstNme";
            this.txtBoxLstNme.Size = new System.Drawing.Size(284, 20);
            this.txtBoxLstNme.TabIndex = 4;
            this.txtBoxLstNme.TextChanged += new System.EventHandler(this.txtBoxLstNme_TextChanged);
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxAge.Location = new System.Drawing.Point(132, 85);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(284, 20);
            this.txtBoxAge.TabIndex = 5;
            this.txtBoxAge.TextChanged += new System.EventHandler(this.txtBoxAge_TextChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(574, 360);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Output";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(195, 3);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(90, 34);
            this.btnClr.TabIndex = 3;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisRec;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxFrstNme;
        private System.Windows.Forms.TextBox txtBoxLstNme;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label lblOutput;
    }
}

