
namespace Futur_s
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p_menu = new System.Windows.Forms.Panel();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_noti = new System.Windows.Forms.Button();
            this.btn_reporting = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_others = new System.Windows.Forms.Button();
            this.btn_produits = new System.Windows.Forms.Button();
            this.p_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.p_titlebar = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btnclosechildform = new System.Windows.Forms.Button();
            this.lb_home = new System.Windows.Forms.Label();
            this.p_desktoppan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p_menu.SuspendLayout();
            this.p_logo.SuspendLayout();
            this.p_titlebar.SuspendLayout();
            this.p_desktoppan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // p_menu
            // 
            this.p_menu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.p_menu.Controls.Add(this.btn_set);
            this.p_menu.Controls.Add(this.btn_noti);
            this.p_menu.Controls.Add(this.btn_reporting);
            this.p_menu.Controls.Add(this.btn_customers);
            this.p_menu.Controls.Add(this.btn_others);
            this.p_menu.Controls.Add(this.btn_produits);
            this.p_menu.Controls.Add(this.p_logo);
            this.p_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_menu.Location = new System.Drawing.Point(0, 0);
            this.p_menu.Name = "p_menu";
            this.p_menu.Size = new System.Drawing.Size(220, 460);
            this.p_menu.TabIndex = 0;
            // 
            // btn_set
            // 
            this.btn_set.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_set.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_set.Location = new System.Drawing.Point(0, 400);
            this.btn_set.Name = "btn_set";
            this.btn_set.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_set.Size = new System.Drawing.Size(220, 28);
            this.btn_set.TabIndex = 6;
            this.btn_set.Text = "Settings";
            this.btn_set.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_set.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_noti
            // 
            this.btn_noti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_noti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_noti.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_noti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_noti.Location = new System.Drawing.Point(0, 340);
            this.btn_noti.Name = "btn_noti";
            this.btn_noti.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_noti.Size = new System.Drawing.Size(220, 60);
            this.btn_noti.TabIndex = 5;
            this.btn_noti.Text = "notifications";
            this.btn_noti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_noti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_noti.UseVisualStyleBackColor = true;
            this.btn_noti.Click += new System.EventHandler(this.btn_noti_Click);
            // 
            // btn_reporting
            // 
            this.btn_reporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_reporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reporting.Location = new System.Drawing.Point(0, 280);
            this.btn_reporting.Name = "btn_reporting";
            this.btn_reporting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_reporting.Size = new System.Drawing.Size(220, 60);
            this.btn_reporting.TabIndex = 4;
            this.btn_reporting.Text = "Reporting";
            this.btn_reporting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reporting.UseVisualStyleBackColor = true;
            this.btn_reporting.Click += new System.EventHandler(this.btn_reporting_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customers.Location = new System.Drawing.Point(0, 220);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_customers.Size = new System.Drawing.Size(220, 60);
            this.btn_customers.TabIndex = 3;
            this.btn_customers.Text = "Customers";
            this.btn_customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_others
            // 
            this.btn_others.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_others.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_others.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_others.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_others.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_others.Location = new System.Drawing.Point(0, 160);
            this.btn_others.Name = "btn_others";
            this.btn_others.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_others.Size = new System.Drawing.Size(220, 60);
            this.btn_others.TabIndex = 2;
            this.btn_others.Text = "Others";
            this.btn_others.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_others.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_others.UseVisualStyleBackColor = true;
            this.btn_others.Click += new System.EventHandler(this.btn_others_Click);
            // 
            // btn_produits
            // 
            this.btn_produits.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_produits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produits.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_produits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_produits.Location = new System.Drawing.Point(0, 100);
            this.btn_produits.Name = "btn_produits";
            this.btn_produits.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_produits.Size = new System.Drawing.Size(220, 60);
            this.btn_produits.TabIndex = 1;
            this.btn_produits.Text = "Products";
            this.btn_produits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_produits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_produits.UseVisualStyleBackColor = true;
            this.btn_produits.Click += new System.EventHandler(this.btn_produits_Click);
            // 
            // p_logo
            // 
            this.p_logo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p_logo.Controls.Add(this.label1);
            this.p_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_logo.Location = new System.Drawing.Point(0, 0);
            this.p_logo.Name = "p_logo";
            this.p_logo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.p_logo.Size = new System.Drawing.Size(220, 100);
            this.p_logo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUTUR@S";
            // 
            // p_titlebar
            // 
            this.p_titlebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_titlebar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.p_titlebar.Controls.Add(this.btn_minimize);
            this.p_titlebar.Controls.Add(this.btn_maximize);
            this.p_titlebar.Controls.Add(this.btn_close);
            this.p_titlebar.Controls.Add(this.btnclosechildform);
            this.p_titlebar.Controls.Add(this.lb_home);
            this.p_titlebar.Location = new System.Drawing.Point(220, 0);
            this.p_titlebar.Name = "p_titlebar";
            this.p_titlebar.Size = new System.Drawing.Size(580, 100);
            this.p_titlebar.TabIndex = 1;
            this.p_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_titlebar_MouseDown);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_minimize.Location = new System.Drawing.Point(469, 25);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 23);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.Text = "o";
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.FlatAppearance.BorderSize = 0;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maximize.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_maximize.Location = new System.Drawing.Point(507, 25);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(32, 23);
            this.btn_maximize.TabIndex = 2;
            this.btn_maximize.Text = "o";
            this.btn_maximize.UseVisualStyleBackColor = true;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_close.Location = new System.Drawing.Point(545, 25);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "o";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btnclosechildform
            // 
            this.btnclosechildform.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnclosechildform.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnclosechildform.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnclosechildform.FlatAppearance.BorderSize = 0;
            this.btnclosechildform.Image = ((System.Drawing.Image)(resources.GetObject("btnclosechildform.Image")));
            this.btnclosechildform.Location = new System.Drawing.Point(0, 0);
            this.btnclosechildform.Name = "btnclosechildform";
            this.btnclosechildform.Size = new System.Drawing.Size(33, 100);
            this.btnclosechildform.TabIndex = 1;
            this.btnclosechildform.UseVisualStyleBackColor = false;
            this.btnclosechildform.Click += new System.EventHandler(this.btnclosechildform_Click);
            // 
            // lb_home
            // 
            this.lb_home.AutoSize = true;
            this.lb_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_home.Location = new System.Drawing.Point(270, 40);
            this.lb_home.Name = "lb_home";
            this.lb_home.Size = new System.Drawing.Size(72, 25);
            this.lb_home.TabIndex = 0;
            this.lb_home.Text = "HOME";
            // 
            // p_desktoppan
            // 
            this.p_desktoppan.Controls.Add(this.label2);
            this.p_desktoppan.Controls.Add(this.pictureBox1);
            this.p_desktoppan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_desktoppan.Location = new System.Drawing.Point(220, 100);
            this.p_desktoppan.Name = "p_desktoppan";
            this.p_desktoppan.Size = new System.Drawing.Size(581, 360);
            this.p_desktoppan.TabIndex = 2;
            this.p_desktoppan.Paint += new System.Windows.Forms.PaintEventHandler(this.p_desktoppan_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(262, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "FUTUR@S";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 460);
            this.Controls.Add(this.p_desktoppan);
            this.Controls.Add(this.p_titlebar);
            this.Controls.Add(this.p_menu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p_menu.ResumeLayout(false);
            this.p_logo.ResumeLayout(false);
            this.p_logo.PerformLayout();
            this.p_titlebar.ResumeLayout(false);
            this.p_titlebar.PerformLayout();
            this.p_desktoppan.ResumeLayout(false);
            this.p_desktoppan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_menu;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_noti;
        private System.Windows.Forms.Button btn_reporting;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_others;
        private System.Windows.Forms.Button btn_produits;
        private System.Windows.Forms.Panel p_logo;
        private System.Windows.Forms.Panel p_titlebar;
        private System.Windows.Forms.Label lb_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p_desktoppan;
        private System.Windows.Forms.Button btnclosechildform;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
    }
}

