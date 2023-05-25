namespace CSharpSTO
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMasters = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.buttonSaveChangesMaster = new System.Windows.Forms.Button();
            this.buttonSaveChangesOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMasters
            // 
            this.dataGridViewMasters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasters.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewMasters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewMasters.Location = new System.Drawing.Point(13, 12);
            this.dataGridViewMasters.Name = "dataGridViewMasters";
            this.dataGridViewMasters.Size = new System.Drawing.Size(606, 492);
            this.dataGridViewMasters.TabIndex = 0;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(624, 12);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(722, 492);
            this.dataGridViewOrders.TabIndex = 1;
            // 
            // buttonSaveChangesMaster
            // 
            this.buttonSaveChangesMaster.Location = new System.Drawing.Point(13, 510);
            this.buttonSaveChangesMaster.Name = "buttonSaveChangesMaster";
            this.buttonSaveChangesMaster.Size = new System.Drawing.Size(607, 35);
            this.buttonSaveChangesMaster.TabIndex = 2;
            this.buttonSaveChangesMaster.Text = "Сохранить изменения в базе мастеров";
            this.buttonSaveChangesMaster.UseVisualStyleBackColor = true;
            this.buttonSaveChangesMaster.Click += new System.EventHandler(this.ButtonSaveChangesMaster_Click);
            // 
            // buttonSaveChangesOrders
            // 
            this.buttonSaveChangesOrders.Location = new System.Drawing.Point(624, 510);
            this.buttonSaveChangesOrders.Name = "buttonSaveChangesOrders";
            this.buttonSaveChangesOrders.Size = new System.Drawing.Size(722, 35);
            this.buttonSaveChangesOrders.TabIndex = 3;
            this.buttonSaveChangesOrders.Text = "Сохранить изменения в базе заказов";
            this.buttonSaveChangesOrders.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 554);
            this.Controls.Add(this.buttonSaveChangesOrders);
            this.Controls.Add(this.buttonSaveChangesMaster);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.dataGridViewMasters);
            this.Name = "Form1";
            this.Text = "СТО";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMasters;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonSaveChangesMaster;
        private System.Windows.Forms.Button buttonSaveChangesOrders;
    }
}

