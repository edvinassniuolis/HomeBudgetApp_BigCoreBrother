namespace HomeBudgetApp_BigCoreBrother
{
    partial class mainForm
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
            this.productTxtBox = new System.Windows.Forms.TextBox();
            this.productExpensesTxtBox = new System.Windows.Forms.TextBox();
            this.addProductBttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productLbl = new System.Windows.Forms.Label();
            this.productExpensesLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productTxtBox
            // 
            this.productTxtBox.Location = new System.Drawing.Point(62, 6);
            this.productTxtBox.Name = "productTxtBox";
            this.productTxtBox.Size = new System.Drawing.Size(100, 20);
            this.productTxtBox.TabIndex = 0;
            // 
            // productExpensesTxtBox
            // 
            this.productExpensesTxtBox.Location = new System.Drawing.Point(62, 29);
            this.productExpensesTxtBox.Name = "productExpensesTxtBox";
            this.productExpensesTxtBox.Size = new System.Drawing.Size(100, 20);
            this.productExpensesTxtBox.TabIndex = 1;
            // 
            // addProductBttn
            // 
            this.addProductBttn.Location = new System.Drawing.Point(62, 55);
            this.addProductBttn.Name = "addProductBttn";
            this.addProductBttn.Size = new System.Drawing.Size(100, 23);
            this.addProductBttn.TabIndex = 2;
            this.addProductBttn.Text = "Add";
            this.addProductBttn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productExpensesLbl);
            this.panel1.Controls.Add(this.productLbl);
            this.panel1.Controls.Add(this.productTxtBox);
            this.panel1.Controls.Add(this.addProductBttn);
            this.panel1.Controls.Add(this.productExpensesTxtBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 85);
            this.panel1.TabIndex = 3;
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Location = new System.Drawing.Point(3, 13);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(47, 13);
            this.productLbl.TabIndex = 4;
            this.productLbl.Text = "Product:";
            // 
            // productExpensesLbl
            // 
            this.productExpensesLbl.AutoSize = true;
            this.productExpensesLbl.Location = new System.Drawing.Point(3, 32);
            this.productExpensesLbl.Name = "productExpensesLbl";
            this.productExpensesLbl.Size = new System.Drawing.Size(56, 13);
            this.productExpensesLbl.TabIndex = 5;
            this.productExpensesLbl.Text = "Expenses:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 261);
            this.Controls.Add(this.panel1);
            this.Name = "mainForm";
            this.Text = "HomeBudgetApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox productTxtBox;
        private System.Windows.Forms.TextBox productExpensesTxtBox;
        private System.Windows.Forms.Button addProductBttn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Label productExpensesLbl;
    }
}

