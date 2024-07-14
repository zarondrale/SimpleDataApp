namespace SimpleDataApp
{
    partial class NewCustomer
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
            label2 = new Label();
            label1 = new Label();
            txtCustomerName = new TextBox();
            txtCustomerID = new TextBox();
            label3 = new Label();
            btnCreateAccount = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numOrderAmount = new NumericUpDown();
            dtpOrderDate = new DateTimePicker();
            btnPlaceOrder = new Button();
            btnAddAnotherAccount = new Button();
            btnAddFinish = new Button();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 20);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 0;
            label2.Text = "Добавление учетной записи";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 64);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "Имя заказчика:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(155, 57);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(125, 27);
            txtCustomerName.TabIndex = 2;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(201, 108);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(79, 27);
            txtCustomerID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 115);
            label3.Name = "label3";
            label3.Size = new Size(184, 20);
            label3.TabIndex = 4;
            label3.Text = "Идентификатор клиента: ";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(303, 106);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(195, 29);
            btnCreateAccount.TabIndex = 5;
            btnCreateAccount.Text = "Создать учетную запись";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 184);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 6;
            label4.Text = "Создание заказа";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 232);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 7;
            label5.Text = "Сумма заказа:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 277);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 8;
            label6.Text = "Дата заказа:";
            // 
            // numOrderAmount
            // 
            numOrderAmount.Location = new Point(155, 230);
            numOrderAmount.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numOrderAmount.Name = "numOrderAmount";
            numOrderAmount.Size = new Size(125, 27);
            numOrderAmount.TabIndex = 9;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(155, 277);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(125, 27);
            dtpOrderDate.TabIndex = 10;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(303, 273);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(195, 29);
            btnPlaceOrder.TabIndex = 11;
            btnPlaceOrder.Text = "Разместить заказ";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnAddAnotherAccount
            // 
            btnAddAnotherAccount.Location = new Point(243, 371);
            btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            btnAddAnotherAccount.Size = new Size(255, 29);
            btnAddAnotherAccount.TabIndex = 12;
            btnAddAnotherAccount.Text = "Добавить другую учетную запись";
            btnAddAnotherAccount.UseVisualStyleBackColor = true;
            btnAddAnotherAccount.Click += btnAddAnotherAccount_Click;
            // 
            // btnAddFinish
            // 
            btnAddFinish.Location = new Point(66, 371);
            btnAddFinish.Name = "btnAddFinish";
            btnAddFinish.Size = new Size(68, 29);
            btnAddFinish.TabIndex = 13;
            btnAddFinish.Text = "Готово";
            btnAddFinish.UseVisualStyleBackColor = true;
            btnAddFinish.Click += btnAddFinish_Click;
            // 
            // NewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 450);
            Controls.Add(btnAddFinish);
            Controls.Add(btnAddAnotherAccount);
            Controls.Add(btnPlaceOrder);
            Controls.Add(dtpOrderDate);
            Controls.Add(numOrderAmount);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCreateAccount);
            Controls.Add(label3);
            Controls.Add(txtCustomerID);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "NewCustomer";
            Text = "Новая учетная запись и заказ";
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtCustomerName;
        private TextBox txtCustomerID;
        private Label label3;
        private Button btnCreateAccount;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numOrderAmount;
        private DateTimePicker dtpOrderDate;
        private Button btnPlaceOrder;
        private Button btnAddAnotherAccount;
        private Button btnAddFinish;
    }
}