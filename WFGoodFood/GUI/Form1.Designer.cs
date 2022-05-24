namespace WFGoodFood
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbPhoneuser = new System.Windows.Forms.Label();
            this.lbPasswuser = new System.Windows.Forms.Label();
            this.lbEmailuser = new System.Windows.Forms.Label();
            this.lbUserNameuser = new System.Windows.Forms.Label();
            this.lbIduser = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveAdmin = new System.Windows.Forms.Button();
            this.btnCancelAdmin = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.btnEditAdmin = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.txtPasswordAdmin = new System.Windows.Forms.TextBox();
            this.lbPasswordAdmin = new System.Windows.Forms.Label();
            this.txtLoginAdmin = new System.Windows.Forms.TextBox();
            this.lbLoginAdmin = new System.Windows.Forms.Label();
            this.txtIdAdmin = new System.Windows.Forms.TextBox();
            this.lbIdadmin = new System.Windows.Forms.Label();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(914, 561);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.lbPhoneuser);
            this.tabPage1.Controls.Add(this.lbPasswuser);
            this.tabPage1.Controls.Add(this.lbEmailuser);
            this.tabPage1.Controls.Add(this.lbUserNameuser);
            this.tabPage1.Controls.Add(this.lbIduser);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.lbPhone);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.lbPassword);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.lbEmail);
            this.tabPage1.Controls.Add(this.txtUserName);
            this.tabPage1.Controls.Add(this.lbUserName);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.lbId);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(906, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseDoubleClick);
            // 
            // lbPhoneuser
            // 
            this.lbPhoneuser.AutoSize = true;
            this.lbPhoneuser.Location = new System.Drawing.Point(586, 296);
            this.lbPhoneuser.Name = "lbPhoneuser";
            this.lbPhoneuser.Size = new System.Drawing.Size(41, 13);
            this.lbPhoneuser.TabIndex = 22;
            this.lbPhoneuser.Text = "Phone:";
            // 
            // lbPasswuser
            // 
            this.lbPasswuser.AutoSize = true;
            this.lbPasswuser.Location = new System.Drawing.Point(586, 240);
            this.lbPasswuser.Name = "lbPasswuser";
            this.lbPasswuser.Size = new System.Drawing.Size(56, 13);
            this.lbPasswuser.TabIndex = 21;
            this.lbPasswuser.Text = "Password:";
            // 
            // lbEmailuser
            // 
            this.lbEmailuser.AutoSize = true;
            this.lbEmailuser.Location = new System.Drawing.Point(586, 186);
            this.lbEmailuser.Name = "lbEmailuser";
            this.lbEmailuser.Size = new System.Drawing.Size(35, 13);
            this.lbEmailuser.TabIndex = 20;
            this.lbEmailuser.Text = "Email:";
            // 
            // lbUserNameuser
            // 
            this.lbUserNameuser.AutoSize = true;
            this.lbUserNameuser.Location = new System.Drawing.Point(586, 135);
            this.lbUserNameuser.Name = "lbUserNameuser";
            this.lbUserNameuser.Size = new System.Drawing.Size(60, 13);
            this.lbUserNameuser.TabIndex = 19;
            this.lbUserNameuser.Text = "UserName:";
            // 
            // lbIduser
            // 
            this.lbIduser.AutoSize = true;
            this.lbIduser.Location = new System.Drawing.Point(586, 76);
            this.lbIduser.Name = "lbIduser";
            this.lbIduser.Size = new System.Drawing.Size(19, 13);
            this.lbIduser.TabIndex = 18;
            this.lbIduser.Text = "Id:";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(660, 289);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(204, 20);
            this.txtPhone.TabIndex = 17;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(580, 289);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(0, 13);
            this.lbPhone.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(809, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(623, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(716, 478);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(530, 478);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(437, 478);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.txtPassword.Location = new System.Drawing.Point(660, 234);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(204, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(577, 237);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(0, 13);
            this.lbPassword.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(660, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(577, 182);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(0, 13);
            this.lbEmail.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            this.txtUserName.Location = new System.Drawing.Point(660, 128);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(204, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(577, 131);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(0, 13);
            this.lbUserName.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Id", true));
            this.txtId.Location = new System.Drawing.Point(660, 73);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(577, 76);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 13);
            this.lbId.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.userNameDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.userBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(6, 8);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(548, 428);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveAdmin);
            this.tabPage2.Controls.Add(this.btnCancelAdmin);
            this.tabPage2.Controls.Add(this.btnDeleteAdmin);
            this.tabPage2.Controls.Add(this.btnEditAdmin);
            this.tabPage2.Controls.Add(this.btnAddAdmin);
            this.tabPage2.Controls.Add(this.txtPasswordAdmin);
            this.tabPage2.Controls.Add(this.lbPasswordAdmin);
            this.tabPage2.Controls.Add(this.txtLoginAdmin);
            this.tabPage2.Controls.Add(this.lbLoginAdmin);
            this.tabPage2.Controls.Add(this.txtIdAdmin);
            this.tabPage2.Controls.Add(this.lbIdadmin);
            this.tabPage2.Controls.Add(this.dataGridViewAdmin);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabPage2_MouseDoubleClick);
            // 
            // btnSaveAdmin
            // 
            this.btnSaveAdmin.Location = new System.Drawing.Point(782, 474);
            this.btnSaveAdmin.Name = "btnSaveAdmin";
            this.btnSaveAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAdmin.TabIndex = 23;
            this.btnSaveAdmin.Text = "Save";
            this.btnSaveAdmin.UseVisualStyleBackColor = true;
            this.btnSaveAdmin.Click += new System.EventHandler(this.btnSaveAdmin_Click);
            // 
            // btnCancelAdmin
            // 
            this.btnCancelAdmin.Location = new System.Drawing.Point(596, 474);
            this.btnCancelAdmin.Name = "btnCancelAdmin";
            this.btnCancelAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAdmin.TabIndex = 22;
            this.btnCancelAdmin.Text = "Cancel";
            this.btnCancelAdmin.UseVisualStyleBackColor = true;
            this.btnCancelAdmin.Click += new System.EventHandler(this.btnCancelAdmin_Click);
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Location = new System.Drawing.Point(689, 474);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAdmin.TabIndex = 21;
            this.btnDeleteAdmin.Text = "Delete";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // btnEditAdmin
            // 
            this.btnEditAdmin.Location = new System.Drawing.Point(503, 474);
            this.btnEditAdmin.Name = "btnEditAdmin";
            this.btnEditAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnEditAdmin.TabIndex = 20;
            this.btnEditAdmin.Text = "Edit";
            this.btnEditAdmin.UseVisualStyleBackColor = true;
            this.btnEditAdmin.Click += new System.EventHandler(this.btnEditAdmin_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Location = new System.Drawing.Point(410, 474);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAddAdmin.TabIndex = 19;
            this.btnAddAdmin.Text = "Add";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "Password", true));
            this.txtPasswordAdmin.Location = new System.Drawing.Point(640, 187);
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.Size = new System.Drawing.Size(204, 20);
            this.txtPasswordAdmin.TabIndex = 18;
            // 
            // lbPasswordAdmin
            // 
            this.lbPasswordAdmin.AutoSize = true;
            this.lbPasswordAdmin.Location = new System.Drawing.Point(557, 190);
            this.lbPasswordAdmin.Name = "lbPasswordAdmin";
            this.lbPasswordAdmin.Size = new System.Drawing.Size(56, 13);
            this.lbPasswordAdmin.TabIndex = 17;
            this.lbPasswordAdmin.Text = "Password:";
            // 
            // txtLoginAdmin
            // 
            this.txtLoginAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "Login", true));
            this.txtLoginAdmin.Location = new System.Drawing.Point(640, 123);
            this.txtLoginAdmin.Name = "txtLoginAdmin";
            this.txtLoginAdmin.Size = new System.Drawing.Size(204, 20);
            this.txtLoginAdmin.TabIndex = 14;
            // 
            // lbLoginAdmin
            // 
            this.lbLoginAdmin.AutoSize = true;
            this.lbLoginAdmin.Location = new System.Drawing.Point(557, 126);
            this.lbLoginAdmin.Name = "lbLoginAdmin";
            this.lbLoginAdmin.Size = new System.Drawing.Size(36, 13);
            this.lbLoginAdmin.TabIndex = 13;
            this.lbLoginAdmin.Text = "Login:";
            // 
            // txtIdAdmin
            // 
            this.txtIdAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "Id", true));
            this.txtIdAdmin.Location = new System.Drawing.Point(640, 68);
            this.txtIdAdmin.Name = "txtIdAdmin";
            this.txtIdAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtIdAdmin.TabIndex = 12;
            // 
            // lbIdadmin
            // 
            this.lbIdadmin.AutoSize = true;
            this.lbIdadmin.Location = new System.Drawing.Point(557, 71);
            this.lbIdadmin.Name = "lbIdadmin";
            this.lbIdadmin.Size = new System.Drawing.Size(19, 13);
            this.lbIdadmin.TabIndex = 11;
            this.lbIdadmin.Text = "Id:";
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AutoGenerateColumns = false;
            this.dataGridViewAdmin.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn2});
            this.dataGridViewAdmin.DataSource = this.adminBindingSource;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(486, 419);
            this.dataGridViewAdmin.TabIndex = 0;
            this.dataGridViewAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellClick);
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(WFGoodFood.DataModel.User);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // userNameDataGridViewTextBoxColumn1
            // 
            this.userNameDataGridViewTextBoxColumn1.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn1.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn1.Name = "userNameDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn1.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataSource = typeof(WFGoodFood.DataModel.Admin);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn2
            // 
            this.passwordDataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn2.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn2.Name = "passwordDataGridViewTextBoxColumn2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.BindingSource userBindingSource;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSaveAdmin;
        private System.Windows.Forms.Button btnCancelAdmin;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Button btnEditAdmin;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.TextBox txtPasswordAdmin;
        private System.Windows.Forms.Label lbPasswordAdmin;
        private System.Windows.Forms.TextBox txtLoginAdmin;
        private System.Windows.Forms.Label lbLoginAdmin;
        private System.Windows.Forms.TextBox txtIdAdmin;
        private System.Windows.Forms.Label lbIdadmin;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lbIduser;
        private System.Windows.Forms.Label lbUserNameuser;
        private System.Windows.Forms.Label lbEmailuser;
        private System.Windows.Forms.Label lbPasswuser;
        private System.Windows.Forms.Label lbPhoneuser;
    }
}

