namespace TestWindowsFormUI {
    partial class MitekToolsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MitekToolsForm));
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRestEndor = new System.Windows.Forms.Button();
            this.btnImageSearch = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.pbFooter = new System.Windows.Forms.PictureBox();
            this.pnlLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooter)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(217)))));
            this.pnlLeftMenu.Controls.Add(this.button3);
            this.pnlLeftMenu.Controls.Add(this.btnRestEndor);
            this.pnlLeftMenu.Controls.Add(this.btnImageSearch);
            this.pnlLeftMenu.Controls.Add(this.btnHelp);
            this.pnlLeftMenu.Controls.Add(this.btnHome);
            this.pnlLeftMenu.Controls.Add(this.pnlSelect);
            this.pnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 75);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(185, 425);
            this.pnlLeftMenu.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(10, 140);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "   Option 4";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnRestEndor
            // 
            this.btnRestEndor.FlatAppearance.BorderSize = 0;
            this.btnRestEndor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestEndor.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestEndor.ForeColor = System.Drawing.Color.White;
            this.btnRestEndor.Image = ((System.Drawing.Image)(resources.GetObject("btnRestEndor.Image")));
            this.btnRestEndor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestEndor.Location = new System.Drawing.Point(10, 105);
            this.btnRestEndor.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestEndor.Name = "btnRestEndor";
            this.btnRestEndor.Size = new System.Drawing.Size(175, 30);
            this.btnRestEndor.TabIndex = 8;
            this.btnRestEndor.Text = "   Endorsement";
            this.btnRestEndor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestEndor.UseVisualStyleBackColor = true;
            this.btnRestEndor.Click += new System.EventHandler(this.btnRestEndor_Click);
            // 
            // btnImageSearch
            // 
            this.btnImageSearch.FlatAppearance.BorderSize = 0;
            this.btnImageSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageSearch.ForeColor = System.Drawing.Color.White;
            this.btnImageSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnImageSearch.Image")));
            this.btnImageSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImageSearch.Location = new System.Drawing.Point(10, 70);
            this.btnImageSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnImageSearch.Name = "btnImageSearch";
            this.btnImageSearch.Size = new System.Drawing.Size(175, 30);
            this.btnImageSearch.TabIndex = 7;
            this.btnImageSearch.Text = "   Image Search";
            this.btnImageSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImageSearch.UseVisualStyleBackColor = true;
            this.btnImageSearch.Click += new System.EventHandler(this.btnImageSearch_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(12, 374);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(35, 35);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(10, 35);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(175, 30);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "   Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.pnlSelect.Location = new System.Drawing.Point(0, 35);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(10, 30);
            this.pnlSelect.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(227, 75);
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTop.Controls.Add(this.btnMin);
            this.pnlTop.Controls.Add(this.pbLogo);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(900, 75);
            this.pnlTop.TabIndex = 1;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.Black;
            this.btnMin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMin.Location = new System.Drawing.Point(829, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(31, 26);
            this.btnMin.TabIndex = 10;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(381, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Mitek Tools Version 1.0";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(866, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 26);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BackColor = System.Drawing.Color.Transparent;
            this.lblResults.Location = new System.Drawing.Point(190, 477);
            this.lblResults.Margin = new System.Windows.Forms.Padding(3);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(597, 13);
            this.lblResults.TabIndex = 2;
            this.lblResults.Text = "This is the Reslut of an action.  This is the Reslut of an action.  This is the R" +
    "eslut of an action.  This is the Reslut of an action.";
            // 
            // pbFooter
            // 
            this.pbFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFooter.BackgroundImage")));
            this.pbFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFooter.Location = new System.Drawing.Point(0, 490);
            this.pbFooter.Name = "pbFooter";
            this.pbFooter.Size = new System.Drawing.Size(900, 10);
            this.pbFooter.TabIndex = 3;
            this.pbFooter.TabStop = false;
            // 
            // MitekToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pnlLeftMenu);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.pbFooter);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MitekToolsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlLeftMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRestEndor;
        private System.Windows.Forms.Button btnImageSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.PictureBox pbFooter;
        private System.Windows.Forms.Button btnMin;
    }
}

