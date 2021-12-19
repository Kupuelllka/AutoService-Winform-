
namespace AutoService_Winform_
{
    partial class Main
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receipt_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInstallDetals = new System.Windows.Forms.Button();
            this.buttonDetals = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.labelOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonChangeOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Mobile_number,
            this.Mark,
            this.Model,
            this.Receipt_date});
            this.dataGridViewOrders.Location = new System.Drawing.Point(201, 48);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(716, 434);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия ";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            // 
            // Mobile_number
            // 
            this.Mobile_number.HeaderText = "Номер телефона";
            this.Mobile_number.Name = "Mobile_number";
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Марка";
            this.Mark.Name = "Mark";
            // 
            // Model
            // 
            this.Model.HeaderText = "Модель";
            this.Model.Name = "Model";
            // 
            // Receipt_date
            // 
            this.Receipt_date.HeaderText = "Дата сдачи";
            this.Receipt_date.Name = "Receipt_date";
            this.Receipt_date.Width = 150;
            // 
            // buttonInstallDetals
            // 
            this.buttonInstallDetals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInstallDetals.Location = new System.Drawing.Point(14, 168);
            this.buttonInstallDetals.Name = "buttonInstallDetals";
            this.buttonInstallDetals.Size = new System.Drawing.Size(148, 39);
            this.buttonInstallDetals.TabIndex = 2;
            this.buttonInstallDetals.Text = "Прайс-лист";
            this.buttonInstallDetals.UseVisualStyleBackColor = true;
            this.buttonInstallDetals.Click += new System.EventHandler(this.buttonInstallDetals_Click);
            // 
            // buttonDetals
            // 
            this.buttonDetals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDetals.Location = new System.Drawing.Point(14, 92);
            this.buttonDetals.Name = "buttonDetals";
            this.buttonDetals.Size = new System.Drawing.Size(148, 36);
            this.buttonDetals.TabIndex = 4;
            this.buttonDetals.Text = "Запчасти";
            this.buttonDetals.UseVisualStyleBackColor = true;
            this.buttonDetals.Click += new System.EventHandler(this.buttonDetals_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(14, 486);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(148, 36);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEmployees.Location = new System.Drawing.Point(14, 246);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(148, 36);
            this.buttonEmployees.TabIndex = 6;
            this.buttonEmployees.Text = "Сотрудники";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrders.Location = new System.Drawing.Point(476, 9);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(108, 31);
            this.labelOrders.TabIndex = 7;
            this.labelOrders.Text = "Заказы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Меню";
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddOrder.Location = new System.Drawing.Point(548, 501);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(148, 36);
            this.buttonAddOrder.TabIndex = 9;
            this.buttonAddOrder.Text = "Добавить";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonChangeOrder
            // 
            this.buttonChangeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeOrder.Location = new System.Drawing.Point(741, 501);
            this.buttonChangeOrder.Name = "buttonChangeOrder";
            this.buttonChangeOrder.Size = new System.Drawing.Size(148, 36);
            this.buttonChangeOrder.TabIndex = 10;
            this.buttonChangeOrder.Text = "Изменить";
            this.buttonChangeOrder.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 549);
            this.Controls.Add(this.buttonChangeOrder);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDetals);
            this.Controls.Add(this.buttonInstallDetals);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "Main";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonInstallDetals;
        private System.Windows.Forms.Button buttonDetals;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receipt_date;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonChangeOrder;
    }
}

