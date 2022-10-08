namespace CrudApiWinForm
{
    partial class UserCrudFrm
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
            this.GetAllData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchById = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetAllData
            // 
            this.GetAllData.BackColor = System.Drawing.Color.DodgerBlue;
            this.GetAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GetAllData.Location = new System.Drawing.Point(163, 174);
            this.GetAllData.Name = "GetAllData";
            this.GetAllData.Size = new System.Drawing.Size(137, 36);
            this.GetAllData.TabIndex = 0;
            this.GetAllData.Text = "Verileri Göster";
            this.GetAllData.UseVisualStyleBackColor = false;
            this.GetAllData.Click += new System.EventHandler(this.GetAllData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 146);
            this.dataGridView1.TabIndex = 1;
            // 
            // SearchById
            // 
            this.SearchById.BackColor = System.Drawing.Color.DodgerBlue;
            this.SearchById.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchById.Location = new System.Drawing.Point(24, 66);
            this.SearchById.Name = "SearchById";
            this.SearchById.Size = new System.Drawing.Size(118, 31);
            this.SearchById.TabIndex = 2;
            this.SearchById.Text = "Kullanıcı Ara";
            this.SearchById.UseVisualStyleBackColor = false;
            this.SearchById.Click += new System.EventHandler(this.SearchById_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(349, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(349, 64);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(24, 42);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(118, 22);
            this.txtId.TabIndex = 7;
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.SpringGreen;
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Insert.Location = new System.Drawing.Point(292, 92);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(157, 31);
            this.Insert.TabIndex = 8;
            this.Insert.Text = "Kullanıcı Ekle";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Delete.Location = new System.Drawing.Point(24, 103);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 31);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Kullanıcı Sil";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kullanıcı Id Girin:";
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Orange;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Update.Location = new System.Drawing.Point(292, 129);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(157, 31);
            this.Update.TabIndex = 11;
            this.Update.Text = "Kullanıcı Güncelle";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // UserCrudFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 362);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchById);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GetAllData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserCrudFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserCrudForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetAllData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchById;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Update;
    }
}

