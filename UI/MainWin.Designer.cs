namespace UI
{
    partial class MainWin
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
            this.tabsMain = new System.Windows.Forms.TabControl();
            this.tabVault = new System.Windows.Forms.TabPage();
            this.tlpVault = new System.Windows.Forms.TableLayoutPanel();
            this.pVault = new System.Windows.Forms.PropertyGrid();
            this.btnEnableAwsAuth = new System.Windows.Forms.Button();
            this.btnDisableAwsAuth = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnSetConfig = new System.Windows.Forms.Button();
            this.btnGetAwsConfig = new System.Windows.Forms.Button();
            this.tabConsul = new System.Windows.Forms.TabPage();
            this.tabsMain.SuspendLayout();
            this.tabVault.SuspendLayout();
            this.tlpVault.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsMain
            // 
            this.tabsMain.Controls.Add(this.tabVault);
            this.tabsMain.Controls.Add(this.tabConsul);
            this.tabsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsMain.Location = new System.Drawing.Point(0, 0);
            this.tabsMain.Name = "tabsMain";
            this.tabsMain.SelectedIndex = 0;
            this.tabsMain.Size = new System.Drawing.Size(800, 450);
            this.tabsMain.TabIndex = 0;
            // 
            // tabVault
            // 
            this.tabVault.Controls.Add(this.tlpVault);
            this.tabVault.Location = new System.Drawing.Point(4, 24);
            this.tabVault.Name = "tabVault";
            this.tabVault.Padding = new System.Windows.Forms.Padding(3);
            this.tabVault.Size = new System.Drawing.Size(792, 422);
            this.tabVault.TabIndex = 0;
            this.tabVault.Text = "Vault";
            this.tabVault.UseVisualStyleBackColor = true;
            // 
            // tlpVault
            // 
            this.tlpVault.ColumnCount = 3;
            this.tlpVault.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVault.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVault.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpVault.Controls.Add(this.pVault, 2, 0);
            this.tlpVault.Controls.Add(this.btnEnableAwsAuth, 0, 0);
            this.tlpVault.Controls.Add(this.btnDisableAwsAuth, 1, 0);
            this.tlpVault.Controls.Add(this.txtMessage, 0, 2);
            this.tlpVault.Controls.Add(this.btnSetConfig, 0, 1);
            this.tlpVault.Controls.Add(this.btnGetAwsConfig, 1, 1);
            this.tlpVault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVault.Location = new System.Drawing.Point(3, 3);
            this.tlpVault.Name = "tlpVault";
            this.tlpVault.RowCount = 4;
            this.tlpVault.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpVault.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpVault.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVault.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVault.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVault.Size = new System.Drawing.Size(786, 416);
            this.tlpVault.TabIndex = 0;
            // 
            // pVault
            // 
            this.pVault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pVault.Location = new System.Drawing.Point(489, 3);
            this.pVault.Name = "pVault";
            this.tlpVault.SetRowSpan(this.pVault, 3);
            this.pVault.Size = new System.Drawing.Size(294, 390);
            this.pVault.TabIndex = 1;
            // 
            // btnEnableAwsAuth
            // 
            this.btnEnableAwsAuth.Location = new System.Drawing.Point(3, 3);
            this.btnEnableAwsAuth.Name = "btnEnableAwsAuth";
            this.btnEnableAwsAuth.Size = new System.Drawing.Size(237, 24);
            this.btnEnableAwsAuth.TabIndex = 2;
            this.btnEnableAwsAuth.Text = "Enable AWS Authentication";
            this.btnEnableAwsAuth.UseVisualStyleBackColor = true;
            this.btnEnableAwsAuth.Click += new System.EventHandler(this.OnEnableAwsAuth);
            // 
            // btnDisableAwsAuth
            // 
            this.btnDisableAwsAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisableAwsAuth.Location = new System.Drawing.Point(246, 3);
            this.btnDisableAwsAuth.Name = "btnDisableAwsAuth";
            this.btnDisableAwsAuth.Size = new System.Drawing.Size(237, 24);
            this.btnDisableAwsAuth.TabIndex = 3;
            this.btnDisableAwsAuth.Text = "Disable AWS Authentication";
            this.btnDisableAwsAuth.UseVisualStyleBackColor = true;
            this.btnDisableAwsAuth.Click += new System.EventHandler(this.OnDisableAwsAuth);
            // 
            // txtMessage
            // 
            this.tlpVault.SetColumnSpan(this.txtMessage, 2);
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(3, 63);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(480, 330);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "";
            // 
            // btnSetConfig
            // 
            this.btnSetConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetConfig.Location = new System.Drawing.Point(3, 33);
            this.btnSetConfig.Name = "btnSetConfig";
            this.btnSetConfig.Size = new System.Drawing.Size(237, 24);
            this.btnSetConfig.TabIndex = 5;
            this.btnSetConfig.Text = "Set AWS Configuration";
            this.btnSetConfig.UseVisualStyleBackColor = true;
            this.btnSetConfig.Click += new System.EventHandler(this.OnSetAwsConfiguration);
            // 
            // btnGetAwsConfig
            // 
            this.btnGetAwsConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetAwsConfig.Location = new System.Drawing.Point(246, 33);
            this.btnGetAwsConfig.Name = "btnGetAwsConfig";
            this.btnGetAwsConfig.Size = new System.Drawing.Size(237, 24);
            this.btnGetAwsConfig.TabIndex = 6;
            this.btnGetAwsConfig.Text = "Read AWS Configuration";
            this.btnGetAwsConfig.UseVisualStyleBackColor = true;
            this.btnGetAwsConfig.Click += new System.EventHandler(this.OnGetAwsConfiguration);
            // 
            // tabConsul
            // 
            this.tabConsul.Location = new System.Drawing.Point(4, 24);
            this.tabConsul.Name = "tabConsul";
            this.tabConsul.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsul.Size = new System.Drawing.Size(792, 422);
            this.tabConsul.TabIndex = 1;
            this.tabConsul.Text = "Consul";
            this.tabConsul.UseVisualStyleBackColor = true;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabsMain);
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zero-Trust Prototype";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnUnload);
            this.Load += new System.EventHandler(this.OnLoad);
            this.tabsMain.ResumeLayout(false);
            this.tabVault.ResumeLayout(false);
            this.tlpVault.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabsMain;
        private TabPage tabVault;
        private TabPage tabConsul;
        private TableLayoutPanel tlpVault;
        private PropertyGrid pVault;
        private Button btnEnableAwsAuth;
        private Button btnDisableAwsAuth;
        private RichTextBox txtMessage;
        private Button btnSetConfig;
        private Button btnGetAwsConfig;
    }
}