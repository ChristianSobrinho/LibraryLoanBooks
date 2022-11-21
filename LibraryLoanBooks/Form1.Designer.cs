namespace LibraryLoanBooks
{
    partial class frmPrincipal
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
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.tabPageAuthor = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPagePublishingCompany = new System.Windows.Forms.TabPage();
            this.tabPageTheme = new System.Windows.Forms.TabPage();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.groupBoxSearchAuthor = new System.Windows.Forms.GroupBox();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.cmbAuthorNationalitySearch = new System.Windows.Forms.ComboBox();
            this.lblAuthorNationalitySearch = new System.Windows.Forms.Label();
            this.lblAuthorNameSearch = new System.Windows.Forms.Label();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewAuthor = new System.Windows.Forms.Button();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.groupBoxSearchPublishingCompany = new System.Windows.Forms.GroupBox();
            this.lblPublishingSearch = new System.Windows.Forms.Label();
            this.textPublishingSearch = new System.Windows.Forms.TextBox();
            this.btnPublishingSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAddPublishing = new System.Windows.Forms.Button();
            this.btnEditPublishing = new System.Windows.Forms.Button();
            this.btnDeletePublishing = new System.Windows.Forms.Button();
            this.groupBoxTheme = new System.Windows.Forms.GroupBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.btnSearchTheme = new System.Windows.Forms.Button();
            this.panelTheme = new System.Windows.Forms.Panel();
            this.tabPrincipal.SuspendLayout();
            this.tabPageAuthor.SuspendLayout();
            this.tabPagePublishingCompany.SuspendLayout();
            this.tabPageTheme.SuspendLayout();
            this.groupBoxSearchAuthor.SuspendLayout();
            this.pnlAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSearchPublishingCompany.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBoxTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPagePrincipal);
            this.tabPrincipal.Controls.Add(this.tabPageAuthor);
            this.tabPrincipal.Controls.Add(this.tabPagePublishingCompany);
            this.tabPrincipal.Controls.Add(this.tabPageTheme);
            this.tabPrincipal.Controls.Add(this.tabPageBooks);
            this.tabPrincipal.Controls.Add(this.tabPageClient);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1214, 711);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 24);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(1206, 683);
            this.tabPagePrincipal.TabIndex = 0;
            this.tabPagePrincipal.Text = "Principal";
            this.tabPagePrincipal.UseVisualStyleBackColor = true;
            // 
            // tabPageAuthor
            // 
            this.tabPageAuthor.Controls.Add(this.pnlAuthor);
            this.tabPageAuthor.Controls.Add(this.groupBoxSearchAuthor);
            this.tabPageAuthor.Location = new System.Drawing.Point(4, 24);
            this.tabPageAuthor.Name = "tabPageAuthor";
            this.tabPageAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthor.Size = new System.Drawing.Size(1206, 683);
            this.tabPageAuthor.TabIndex = 1;
            this.tabPageAuthor.Text = "Autores";
            this.tabPageAuthor.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1214, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabPagePublishingCompany
            // 
            this.tabPagePublishingCompany.Controls.Add(this.panel1);
            this.tabPagePublishingCompany.Controls.Add(this.groupBoxSearchPublishingCompany);
            this.tabPagePublishingCompany.Location = new System.Drawing.Point(4, 24);
            this.tabPagePublishingCompany.Name = "tabPagePublishingCompany";
            this.tabPagePublishingCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePublishingCompany.Size = new System.Drawing.Size(1206, 683);
            this.tabPagePublishingCompany.TabIndex = 2;
            this.tabPagePublishingCompany.Text = "Editora";
            this.tabPagePublishingCompany.UseVisualStyleBackColor = true;
            // 
            // tabPageTheme
            // 
            this.tabPageTheme.Controls.Add(this.panelTheme);
            this.tabPageTheme.Controls.Add(this.groupBoxTheme);
            this.tabPageTheme.Location = new System.Drawing.Point(4, 24);
            this.tabPageTheme.Name = "tabPageTheme";
            this.tabPageTheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTheme.Size = new System.Drawing.Size(1206, 683);
            this.tabPageTheme.TabIndex = 3;
            this.tabPageTheme.Text = "Temas";
            this.tabPageTheme.UseVisualStyleBackColor = true;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Location = new System.Drawing.Point(4, 24);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(1253, 622);
            this.tabPageBooks.TabIndex = 4;
            this.tabPageBooks.Text = "Livros";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // tabPageClient
            // 
            this.tabPageClient.Location = new System.Drawing.Point(4, 24);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(1253, 622);
            this.tabPageClient.TabIndex = 5;
            this.tabPageClient.Text = "Clientes";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchAuthor
            // 
            this.groupBoxSearchAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchAuthor.Controls.Add(this.btnSearchAuthor);
            this.groupBoxSearchAuthor.Controls.Add(this.txtAuthorName);
            this.groupBoxSearchAuthor.Controls.Add(this.cmbAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNameSearch);
            this.groupBoxSearchAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchAuthor.Location = new System.Drawing.Point(8, 6);
            this.groupBoxSearchAuthor.Name = "groupBoxSearchAuthor";
            this.groupBoxSearchAuthor.Size = new System.Drawing.Size(1190, 175);
            this.groupBoxSearchAuthor.TabIndex = 5;
            this.groupBoxSearchAuthor.TabStop = false;
            this.groupBoxSearchAuthor.Text = "Consulta";
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Search;
            this.btnSearchAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchAuthor.Location = new System.Drawing.Point(401, 47);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnSearchAuthor.TabIndex = 9;
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(6, 59);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(175, 29);
            this.txtAuthorName.TabIndex = 8;
            // 
            // cmbAuthorNationalitySearch
            // 
            this.cmbAuthorNationalitySearch.FormattingEnabled = true;
            this.cmbAuthorNationalitySearch.Location = new System.Drawing.Point(199, 59);
            this.cmbAuthorNationalitySearch.Name = "cmbAuthorNationalitySearch";
            this.cmbAuthorNationalitySearch.Size = new System.Drawing.Size(180, 29);
            this.cmbAuthorNationalitySearch.TabIndex = 7;
            // 
            // lblAuthorNationalitySearch
            // 
            this.lblAuthorNationalitySearch.AutoSize = true;
            this.lblAuthorNationalitySearch.Location = new System.Drawing.Point(198, 35);
            this.lblAuthorNationalitySearch.Name = "lblAuthorNationalitySearch";
            this.lblAuthorNationalitySearch.Size = new System.Drawing.Size(122, 21);
            this.lblAuthorNationalitySearch.TabIndex = 6;
            this.lblAuthorNationalitySearch.Text = "Nacionalidade";
            // 
            // lblAuthorNameSearch
            // 
            this.lblAuthorNameSearch.AutoSize = true;
            this.lblAuthorNameSearch.Location = new System.Drawing.Point(6, 35);
            this.lblAuthorNameSearch.Name = "lblAuthorNameSearch";
            this.lblAuthorNameSearch.Size = new System.Drawing.Size(128, 21);
            this.lblAuthorNameSearch.TabIndex = 5;
            this.lblAuthorNameSearch.Text = "Nome do Autor";
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAuthor.BackColor = System.Drawing.Color.Plum;
            this.pnlAuthor.Controls.Add(this.btnDeleteAuthor);
            this.pnlAuthor.Controls.Add(this.btnEditAuthor);
            this.pnlAuthor.Controls.Add(this.btnNewAuthor);
            this.pnlAuthor.Controls.Add(this.dataGridView1);
            this.pnlAuthor.Location = new System.Drawing.Point(8, 187);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(1190, 504);
            this.pnlAuthor.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNewAuthor
            // 
            this.btnNewAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Add;
            this.btnNewAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewAuthor.Location = new System.Drawing.Point(6, 20);
            this.btnNewAuthor.Name = "btnNewAuthor";
            this.btnNewAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnNewAuthor.TabIndex = 1;
            this.btnNewAuthor.UseVisualStyleBackColor = true;
            this.btnNewAuthor.Click += new System.EventHandler(this.btnNewAuthor_Click);
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Edit;
            this.btnEditAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditAuthor.Location = new System.Drawing.Point(62, 20);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnEditAuthor.TabIndex = 2;
            this.btnEditAuthor.UseVisualStyleBackColor = true;
            this.btnEditAuthor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Delete;
            this.btnDeleteAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(118, 20);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteAuthor.TabIndex = 3;
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchPublishingCompany
            // 
            this.groupBoxSearchPublishingCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchPublishingCompany.Controls.Add(this.btnPublishingSearch);
            this.groupBoxSearchPublishingCompany.Controls.Add(this.textPublishingSearch);
            this.groupBoxSearchPublishingCompany.Controls.Add(this.lblPublishingSearch);
            this.groupBoxSearchPublishingCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchPublishingCompany.Location = new System.Drawing.Point(8, 6);
            this.groupBoxSearchPublishingCompany.Name = "groupBoxSearchPublishingCompany";
            this.groupBoxSearchPublishingCompany.Size = new System.Drawing.Size(1190, 161);
            this.groupBoxSearchPublishingCompany.TabIndex = 0;
            this.groupBoxSearchPublishingCompany.TabStop = false;
            this.groupBoxSearchPublishingCompany.Text = "Consulta";
            // 
            // lblPublishingSearch
            // 
            this.lblPublishingSearch.AutoSize = true;
            this.lblPublishingSearch.Location = new System.Drawing.Point(19, 34);
            this.lblPublishingSearch.Name = "lblPublishingSearch";
            this.lblPublishingSearch.Size = new System.Drawing.Size(65, 21);
            this.lblPublishingSearch.TabIndex = 0;
            this.lblPublishingSearch.Text = "Editora";
            // 
            // textPublishingSearch
            // 
            this.textPublishingSearch.Location = new System.Drawing.Point(19, 58);
            this.textPublishingSearch.Name = "textPublishingSearch";
            this.textPublishingSearch.Size = new System.Drawing.Size(168, 29);
            this.textPublishingSearch.TabIndex = 1;
            // 
            // btnPublishingSearch
            // 
            this.btnPublishingSearch.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Search;
            this.btnPublishingSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPublishingSearch.Location = new System.Drawing.Point(204, 46);
            this.btnPublishingSearch.Name = "btnPublishingSearch";
            this.btnPublishingSearch.Size = new System.Drawing.Size(50, 50);
            this.btnPublishingSearch.TabIndex = 2;
            this.btnPublishingSearch.UseVisualStyleBackColor = true;
            this.btnPublishingSearch.Click += new System.EventHandler(this.btnPublishingSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.btnDeletePublishing);
            this.panel1.Controls.Add(this.btnEditPublishing);
            this.panel1.Controls.Add(this.btnAddPublishing);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(8, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 489);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1146, 404);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnAddPublishing
            // 
            this.btnAddPublishing.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Add;
            this.btnAddPublishing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPublishing.Location = new System.Drawing.Point(19, 26);
            this.btnAddPublishing.Name = "btnAddPublishing";
            this.btnAddPublishing.Size = new System.Drawing.Size(50, 50);
            this.btnAddPublishing.TabIndex = 1;
            this.btnAddPublishing.UseVisualStyleBackColor = true;
            // 
            // btnEditPublishing
            // 
            this.btnEditPublishing.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Edit;
            this.btnEditPublishing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditPublishing.Location = new System.Drawing.Point(75, 26);
            this.btnEditPublishing.Name = "btnEditPublishing";
            this.btnEditPublishing.Size = new System.Drawing.Size(50, 50);
            this.btnEditPublishing.TabIndex = 2;
            this.btnEditPublishing.UseVisualStyleBackColor = true;
            this.btnEditPublishing.Click += new System.EventHandler(this.btnEditPublishing_Click);
            // 
            // btnDeletePublishing
            // 
            this.btnDeletePublishing.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Delete;
            this.btnDeletePublishing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePublishing.Location = new System.Drawing.Point(137, 26);
            this.btnDeletePublishing.Name = "btnDeletePublishing";
            this.btnDeletePublishing.Size = new System.Drawing.Size(50, 50);
            this.btnDeletePublishing.TabIndex = 3;
            this.btnDeletePublishing.UseVisualStyleBackColor = true;
            this.btnDeletePublishing.Click += new System.EventHandler(this.btnDeletePublishing_Click);
            // 
            // groupBoxTheme
            // 
            this.groupBoxTheme.Controls.Add(this.btnSearchTheme);
            this.groupBoxTheme.Controls.Add(this.txtTheme);
            this.groupBoxTheme.Controls.Add(this.lblTheme);
            this.groupBoxTheme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxTheme.Location = new System.Drawing.Point(11, 10);
            this.groupBoxTheme.Name = "groupBoxTheme";
            this.groupBoxTheme.Size = new System.Drawing.Size(1187, 162);
            this.groupBoxTheme.TabIndex = 0;
            this.groupBoxTheme.TabStop = false;
            this.groupBoxTheme.Text = "Consulta";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(22, 41);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(58, 21);
            this.lblTheme.TabIndex = 0;
            this.lblTheme.Text = "Temas";
            // 
            // txtTheme
            // 
            this.txtTheme.Location = new System.Drawing.Point(22, 65);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.Size = new System.Drawing.Size(144, 29);
            this.txtTheme.TabIndex = 1;
            // 
            // btnSearchTheme
            // 
            this.btnSearchTheme.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Search;
            this.btnSearchTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchTheme.Location = new System.Drawing.Point(185, 53);
            this.btnSearchTheme.Name = "btnSearchTheme";
            this.btnSearchTheme.Size = new System.Drawing.Size(50, 50);
            this.btnSearchTheme.TabIndex = 2;
            this.btnSearchTheme.UseVisualStyleBackColor = true;
            // 
            // panelTheme
            // 
            this.panelTheme.BackColor = System.Drawing.Color.Plum;
            this.panelTheme.Location = new System.Drawing.Point(23, 204);
            this.panelTheme.Name = "panelTheme";
            this.panelTheme.Size = new System.Drawing.Size(1175, 458);
            this.panelTheme.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 711);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageAuthor.ResumeLayout(false);
            this.tabPagePublishingCompany.ResumeLayout(false);
            this.tabPageTheme.ResumeLayout(false);
            this.groupBoxSearchAuthor.ResumeLayout(false);
            this.groupBoxSearchAuthor.PerformLayout();
            this.pnlAuthor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSearchPublishingCompany.ResumeLayout(false);
            this.groupBoxSearchPublishingCompany.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBoxTheme.ResumeLayout(false);
            this.groupBoxTheme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabPrincipal;
        private TabPage tabPagePrincipal;
        private TabPage tabPageAuthor;
        private Panel pnlAuthor;
        private Button btnEditAuthor;
        private Button btnNewAuthor;
        private DataGridView dataGridView1;
        private GroupBox groupBoxSearchAuthor;
        private Button btnSearchAuthor;
        private TextBox txtAuthorName;
        private ComboBox cmbAuthorNationalitySearch;
        private Label lblAuthorNationalitySearch;
        private Label lblAuthorNameSearch;
        private TabPage tabPagePublishingCompany;
        private TabPage tabPageTheme;
        private TabPage tabPageBooks;
        private TabPage tabPageClient;
        private StatusStrip statusStrip1;
        private Button btnDeleteAuthor;
        private GroupBox groupBoxSearchPublishingCompany;
        private Button btnPublishingSearch;
        private TextBox textPublishingSearch;
        private Label lblPublishingSearch;
        private Panel panel1;
        private Button btnDeletePublishing;
        private Button btnEditPublishing;
        private Button btnAddPublishing;
        private DataGridView dataGridView2;
        private Panel panelTheme;
        private GroupBox groupBoxTheme;
        private Button btnSearchTheme;
        private TextBox txtTheme;
        private Label lblTheme;
    }
}