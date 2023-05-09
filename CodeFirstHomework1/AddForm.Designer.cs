namespace CodeFirstHomework1
{
    partial class AddForm
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
            btnAdd = new Button();
            label1 = new Label();
            txtCompanyName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtContactName = new TextBox();
            txtContactTitle = new TextBox();
            txtAddress = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(233, 221);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 65);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(204, 62);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(258, 23);
            txtCompanyName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 95);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Contact Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 129);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 1;
            label3.Text = "Contact Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 164);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 1;
            label4.Text = "Address:";
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(204, 92);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(258, 23);
            txtContactName.TabIndex = 2;
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(204, 126);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(258, 23);
            txtContactTitle.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(204, 161);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(258, 23);
            txtAddress.TabIndex = 2;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(551, 301);
            Controls.Add(txtAddress);
            Controls.Add(txtContactTitle);
            Controls.Add(txtContactName);
            Controls.Add(txtCompanyName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private TextBox txtCompanyName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtContactName;
        private TextBox txtContactTitle;
        private TextBox txtAddress;
    }
}