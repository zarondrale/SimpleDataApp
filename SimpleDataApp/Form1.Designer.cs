namespace SimpleDataApp
{
    partial class Область
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnGoToAdd = new Button();
            btnGoToFillOrCancel = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 38);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Text = "Выберите действие:";
            // 
            // btnGoToAdd
            // 
            btnGoToAdd.Location = new Point(45, 81);
            btnGoToAdd.Name = "btnGoToAdd";
            btnGoToAdd.Size = new Size(216, 29);
            btnGoToAdd.TabIndex = 1;
            btnGoToAdd.Text = "Добавление учетной записи";
            btnGoToAdd.UseVisualStyleBackColor = true;
            btnGoToAdd.Click += btnGoToAdd_Click;
            // 
            // btnGoToFillOrCancel
            // 
            btnGoToFillOrCancel.Location = new Point(35, 141);
            btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
            btnGoToFillOrCancel.Size = new Size(242, 29);
            btnGoToFillOrCancel.TabIndex = 2;
            btnGoToFillOrCancel.Text = "Заполнить или отменить заказ";
            btnGoToFillOrCancel.UseVisualStyleBackColor = true;
            btnGoToFillOrCancel.Click += btnGoToFillOrCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(224, 213);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Выйти";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Область
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 257);
            Controls.Add(btnExit);
            Controls.Add(btnGoToFillOrCancel);
            Controls.Add(btnGoToAdd);
            Controls.Add(label1);
            Name = "Область";
            Text = "Приветствие";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGoToAdd;
        private Button btnGoToFillOrCancel;
        private Button btnExit;
    }
}
