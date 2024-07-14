namespace SimpleDataApp
{
    partial class FillOrCancel
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
            label1 = new Label();
            label2 = new Label();
            txtOrderID = new TextBox();
            btnFindByOrderID = new Button();
            btnCancelOrder = new Button();
            btnFillOrder = new Button();
            btnFinishUpdates = new Button();
            dtpFillDate = new DateTimePicker();
            dgvCustomerOrders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 0;
            label1.Text = "Идентификатор заказа:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(357, 20);
            label2.TabIndex = 1;
            label2.Text = "При заполнении заказа укажите дату заполнения";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(210, 17);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(125, 27);
            txtOrderID.TabIndex = 2;
            // 
            // btnFindByOrderID
            // 
            btnFindByOrderID.Location = new Point(391, 17);
            btnFindByOrderID.Name = "btnFindByOrderID";
            btnFindByOrderID.Size = new Size(118, 29);
            btnFindByOrderID.TabIndex = 3;
            btnFindByOrderID.Text = "Найти заказ";
            btnFindByOrderID.UseVisualStyleBackColor = true;
            btnFindByOrderID.Click += btnFindByOrderID_Click;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(12, 274);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(129, 29);
            btnCancelOrder.TabIndex = 4;
            btnCancelOrder.Text = "Отменить заказ";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // btnFillOrder
            // 
            btnFillOrder.Location = new Point(147, 274);
            btnFillOrder.Name = "btnFillOrder";
            btnFillOrder.Size = new Size(133, 29);
            btnFillOrder.TabIndex = 5;
            btnFillOrder.Text = "Заполнить заказ";
            btnFillOrder.UseVisualStyleBackColor = true;
            btnFillOrder.Click += btnFillOrder_Click;
            // 
            // btnFinishUpdates
            // 
            btnFinishUpdates.Location = new Point(415, 274);
            btnFinishUpdates.Name = "btnFinishUpdates";
            btnFinishUpdates.Size = new Size(94, 29);
            btnFinishUpdates.TabIndex = 6;
            btnFinishUpdates.Text = "Готово";
            btnFinishUpdates.UseVisualStyleBackColor = true;
            btnFinishUpdates.Click += btnFinishUpdates_Click;
            // 
            // dtpFillDate
            // 
            dtpFillDate.Format = DateTimePickerFormat.Short;
            dtpFillDate.Location = new Point(391, 78);
            dtpFillDate.Name = "dtpFillDate";
            dtpFillDate.Size = new Size(118, 27);
            dtpFillDate.TabIndex = 7;
            // 
            // dgvCustomerOrders
            // 
            dgvCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerOrders.Location = new Point(12, 113);
            dgvCustomerOrders.Name = "dgvCustomerOrders";
            dgvCustomerOrders.ReadOnly = true;
            dgvCustomerOrders.RowHeadersVisible = false;
            dgvCustomerOrders.RowHeadersWidth = 51;
            dgvCustomerOrders.Size = new Size(497, 138);
            dgvCustomerOrders.TabIndex = 8;
            // 
            // FillOrCancel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 319);
            Controls.Add(dgvCustomerOrders);
            Controls.Add(dtpFillDate);
            Controls.Add(btnFinishUpdates);
            Controls.Add(btnFillOrder);
            Controls.Add(btnCancelOrder);
            Controls.Add(btnFindByOrderID);
            Controls.Add(txtOrderID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FillOrCancel";
            Text = "Заполнение или отмена заказа";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtOrderID;
        private Button btnFindByOrderID;
        private Button btnCancelOrder;
        private Button btnFillOrder;
        private Button btnFinishUpdates;
        private DateTimePicker dtpFillDate;
        private DataGridView dgvCustomerOrders;
    }
}