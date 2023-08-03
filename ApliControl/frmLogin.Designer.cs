namespace ApliControl
{
    partial class FormImagen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImagen));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.elDivider1 = new Klik.Windows.Forms.v1.EntryLib.ELDivider();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsu = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txtPass = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.elButton1 = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label8 = new System.Windows.Forms.Label();
            this.elDivider2 = new Klik.Windows.Forms.v1.EntryLib.ELDivider();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.elDivider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elDivider2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(760, 30);
            this.panelTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(107, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "TimeSync";
            // 
            // elDivider1
            // 
            this.elDivider1.FadeStyle = Klik.Windows.Forms.v1.EntryLib.DividerFadeStyles.Center;
            this.elDivider1.LineColor = System.Drawing.Color.Gainsboro;
            this.elDivider1.Location = new System.Drawing.Point(45, 138);
            this.elDivider1.Name = "elDivider1";
            this.elDivider1.Size = new System.Drawing.Size(278, 23);
            this.elDivider1.TabIndex = 4;
            this.elDivider1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(39, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Asistencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(127, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inteligente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(215, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = ", Siempre Contigo";
            // 
            // txtUsu
            // 
            this.txtUsu.CaptionStyle.CaptionSize = 0;
            this.txtUsu.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txtUsu.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txtUsu.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txtUsu.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.txtUsu.CaptionStyle.TextStyle.Text = "elEntryBox1";
            this.txtUsu.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.txtUsu.EditBoxStyle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.EditBoxStyle.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsu.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txtUsu.EditBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUsu.Location = new System.Drawing.Point(18, 220);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(312, 38);
            this.txtUsu.TabIndex = 1;
            this.txtUsu.ValidationStyle.PasswordChar = '\0';
            this.txtUsu.Value = "";
            this.txtUsu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsu_KeyDown);
            // 
            // txtPass
            // 
            this.txtPass.CaptionStyle.CaptionSize = 0;
            this.txtPass.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txtPass.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txtPass.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txtPass.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.txtPass.CaptionStyle.TextStyle.Text = "elEntryBox1";
            this.txtPass.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.txtPass.EditBoxStyle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.EditBoxStyle.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txtPass.EditBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPass.Location = new System.Drawing.Point(18, 285);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(312, 38);
            this.txtPass.TabIndex = 2;
            this.txtPass.ValidationStyle.PasswordChar = '\0';
            this.txtPass.ValidationStyle.UseSystemPasswordChar = true;
            this.txtPass.Value = "";
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::ApliControl.Properties.Resources.apagar;
            this.btnCerrar.Location = new System.Drawing.Point(344, 36);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 26);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label7
            // 
            this.label7.Image = global::ApliControl.Properties.Resources.pass;
            this.label7.Location = new System.Drawing.Point(24, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 25);
            this.label7.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Image = global::ApliControl.Properties.Resources.usuario;
            this.label6.Location = new System.Drawing.Point(24, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 25);
            this.label6.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(8, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 33);
            this.label2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApliControl.Properties.Resources.logito;
            this.pictureBox1.Location = new System.Drawing.Point(131, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(376, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 411);
            this.panel1.TabIndex = 1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitulo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // elButton1
            // 
            this.elButton1.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elButton1.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.elButton1.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.elButton1.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elButton1.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.elButton1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton1.Location = new System.Drawing.Point(65, 342);
            this.elButton1.Name = "elButton1";
            this.elButton1.Size = new System.Drawing.Size(205, 38);
            this.elButton1.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.YellowGreen;
            this.elButton1.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.YellowGreen;
            this.elButton1.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.YellowGreen;
            this.elButton1.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.YellowGreen;
            this.elButton1.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elButton1.TabIndex = 3;
            this.elButton1.TextStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elButton1.TextStyle.ForeColor = System.Drawing.Color.White;
            this.elButton1.TextStyle.Text = "Aceptar";
            this.elButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton1.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.elButton1.Click += new System.EventHandler(this.elButton1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(24, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "TimeSync @ 2023";
            // 
            // elDivider2
            // 
            this.elDivider2.FadeStyle = Klik.Windows.Forms.v1.EntryLib.DividerFadeStyles.Center;
            this.elDivider2.LineColor = System.Drawing.Color.Black;
            this.elDivider2.Location = new System.Drawing.Point(158, 409);
            this.elDivider2.Name = "elDivider2";
            this.elDivider2.Orientation = Klik.Windows.Forms.v1.EntryLib.DividerOrientations.Vertical;
            this.elDivider2.Size = new System.Drawing.Size(10, 32);
            this.elDivider2.TabIndex = 12;
            this.elDivider2.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(207, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Version 1.0 Orginal";
            // 
            // FormImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 441);
            this.Controls.Add(this.elDivider2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.elButton1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.elDivider1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elDivider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elDivider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELDivider elDivider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txtUsu;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txtPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton elButton1;
        private System.Windows.Forms.Label label8;
        private Klik.Windows.Forms.v1.EntryLib.ELDivider elDivider2;
        private System.Windows.Forms.Label label9;
    }
}

