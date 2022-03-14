namespace WarehouseProject
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costField = new System.Windows.Forms.TextBox();
            this.supplierField = new System.Windows.Forms.TextBox();
            this.countField = new System.Windows.Forms.TextBox();
            this.typeField = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label6.Location = new System.Drawing.Point(300, 671);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(249, 71);
            label6.TabIndex = 21;
            label6.Text = "Цена:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label5.Location = new System.Drawing.Point(294, 555);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(255, 71);
            label5.TabIndex = 20;
            label5.Text = "Поставщик:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label4.Location = new System.Drawing.Point(288, 440);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(261, 71);
            label4.TabIndex = 19;
            label4.Text = "Количество:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.Location = new System.Drawing.Point(282, 329);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(267, 71);
            label3.TabIndex = 18;
            label3.Text = "Тип товара:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(62, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 236);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 83);
            this.label2.TabIndex = 1;
            this.label2.Text = "Склад";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(929, 191);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание новой записи:";
            // 
            // costField
            // 
            this.costField.Location = new System.Drawing.Point(555, 671);
            this.costField.Multiline = true;
            this.costField.Name = "costField";
            this.costField.Size = new System.Drawing.Size(433, 71);
            this.costField.TabIndex = 16;
            // 
            // supplierField
            // 
            this.supplierField.Location = new System.Drawing.Point(555, 555);
            this.supplierField.Multiline = true;
            this.supplierField.Name = "supplierField";
            this.supplierField.Size = new System.Drawing.Size(433, 71);
            this.supplierField.TabIndex = 15;
            // 
            // countField
            // 
            this.countField.Location = new System.Drawing.Point(555, 440);
            this.countField.Multiline = true;
            this.countField.Name = "countField";
            this.countField.Size = new System.Drawing.Size(433, 71);
            this.countField.TabIndex = 14;
            // 
            // typeField
            // 
            this.typeField.Location = new System.Drawing.Point(555, 329);
            this.typeField.Multiline = true;
            this.typeField.Name = "typeField";
            this.typeField.Size = new System.Drawing.Size(433, 71);
            this.typeField.TabIndex = 13;
            this.typeField.TextChanged += new System.EventHandler(this.typeField_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(471, 788);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(433, 89);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Сохранить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(471, 907);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(433, 89);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 1043);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.costField);
            this.Controls.Add(this.supplierField);
            this.Controls.Add(this.countField);
            this.Controls.Add(this.typeField);
            this.Controls.Add(this.panel1);
            this.Name = "AddForm";
            this.Text = "addForm";
            this.Load += new System.EventHandler(this.addForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costField;
        private System.Windows.Forms.TextBox supplierField;
        private System.Windows.Forms.TextBox countField;
        private System.Windows.Forms.TextBox typeField;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}