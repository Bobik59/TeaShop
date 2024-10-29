namespace TeaShop
{
    partial class EditForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTypeId = new System.Windows.Forms.TextBox();
            this.txtCountryId = new System.Windows.Forms.TextBox();
            this.txtQuantityGrams = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(330, 12);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 42);
            this.txtName.TabIndex = 0;
            // 
            // txtTypeId
            // 
            this.txtTypeId.Location = new System.Drawing.Point(330, 60);
            this.txtTypeId.Multiline = true;
            this.txtTypeId.Name = "txtTypeId";
            this.txtTypeId.Size = new System.Drawing.Size(226, 42);
            this.txtTypeId.TabIndex = 1;
            // 
            // txtCountryId
            // 
            this.txtCountryId.Location = new System.Drawing.Point(330, 108);
            this.txtCountryId.Multiline = true;
            this.txtCountryId.Name = "txtCountryId";
            this.txtCountryId.Size = new System.Drawing.Size(226, 42);
            this.txtCountryId.TabIndex = 2;
            // 
            // txtQuantityGrams
            // 
            this.txtQuantityGrams.Location = new System.Drawing.Point(330, 252);
            this.txtQuantityGrams.Multiline = true;
            this.txtQuantityGrams.Name = "txtQuantityGrams";
            this.txtQuantityGrams.Size = new System.Drawing.Size(226, 42);
            this.txtQuantityGrams.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(330, 156);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(219, 42);
            this.txtDescription.TabIndex = 3;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(330, 204);
            this.txtCostPrice.Multiline = true;
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(226, 42);
            this.txtCostPrice.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(123, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(177, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "TypeId";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(121, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "CountryId";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(100, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 42);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(117, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "CostPrice";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "QuantityGrams";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 382);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCostPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtQuantityGrams);
            this.Controls.Add(this.txtCountryId);
            this.Controls.Add(this.txtTypeId);
            this.Controls.Add(this.txtName);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTypeId;
        private System.Windows.Forms.TextBox txtCountryId;
        private System.Windows.Forms.TextBox txtQuantityGrams;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}