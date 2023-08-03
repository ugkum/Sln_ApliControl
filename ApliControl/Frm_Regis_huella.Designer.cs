namespace ApliControl
{
    partial class Frm_Regis_huella
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GroupEvents = new System.Windows.Forms.GroupBox();
            this.ListEvents = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblIdPersonal = new System.Windows.Forms.Label();
            this.btnCancelar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label2 = new System.Windows.Forms.Label();
            this.enrollmentControl1 = new DPFP.Gui.Enrollment.EnrollmentControl();
            this.verificationControl1 = new DPFP.Gui.Verification.VerificationControl();
            this.panel1.SuspendLayout();
            this.GroupEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 30);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "REGISTRO DACTILAR DE HUELLA DEL PERSONAL";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // GroupEvents
            // 
            this.GroupEvents.Controls.Add(this.ListEvents);
            this.GroupEvents.Location = new System.Drawing.Point(4, 356);
            this.GroupEvents.Name = "GroupEvents";
            this.GroupEvents.Size = new System.Drawing.Size(495, 146);
            this.GroupEvents.TabIndex = 4;
            this.GroupEvents.TabStop = false;
            this.GroupEvents.Text = "Events";
            // 
            // ListEvents
            // 
            this.ListEvents.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ListEvents.FormattingEnabled = true;
            this.ListEvents.Location = new System.Drawing.Point(16, 19);
            this.ListEvents.Name = "ListEvents";
            this.ListEvents.Size = new System.Drawing.Size(440, 108);
            this.ListEvents.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(581, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(506, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del Personal:";
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonal.Location = new System.Drawing.Point(506, 276);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(303, 36);
            this.lblPersonal.TabIndex = 6;
            this.lblPersonal.Text = "REGISTRO DACTILAR DE HUELLA\r\nDEL PERSONAL";
            this.lblPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(506, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nro Dni:";
            // 
            // lblDni
            // 
            this.lblDni.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(506, 360);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(116, 18);
            this.lblDni.TabIndex = 6;
            this.lblDni.Text = "0";
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIdPersonal
            // 
            this.lblIdPersonal.AutoSize = true;
            this.lblIdPersonal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPersonal.Location = new System.Drawing.Point(649, 360);
            this.lblIdPersonal.Name = "lblIdPersonal";
            this.lblIdPersonal.Size = new System.Drawing.Size(19, 18);
            this.lblIdPersonal.TabIndex = 6;
            this.lblIdPersonal.Text = "0";
            this.lblIdPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderStyle.EdgeRadius = 7;
            this.btnCancelar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnCancelar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCancelar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnCancelar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnCancelar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Location = new System.Drawing.Point(572, 434);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.btnCancelar.Size = new System.Drawing.Size(171, 39);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCancelar.TextStyle.Text = "Cancelar";
            this.btnCancelar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(649, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id Personal:";
            // 
            // enrollmentControl1
            // 
            this.enrollmentControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enrollmentControl1.EnrolledFingerMask = 0;
            this.enrollmentControl1.Location = new System.Drawing.Point(4, 36);
            this.enrollmentControl1.MaxEnrollFingerCount = 10;
            this.enrollmentControl1.Name = "enrollmentControl1";
            this.enrollmentControl1.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.enrollmentControl1.Size = new System.Drawing.Size(492, 314);
            this.enrollmentControl1.TabIndex = 8;
            this.enrollmentControl1.OnEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnEnroll(this.enrollmentControl1_OnEnroll);
            this.enrollmentControl1.OnFingerTouch += new DPFP.Gui.Enrollment.EnrollmentControl._OnFingerTouch(this.enrollmentControl1_OnFingerTouch);
            this.enrollmentControl1.OnFingerRemove += new DPFP.Gui.Enrollment.EnrollmentControl._OnFingerRemove(this.enrollmentControl1_OnFingerRemove);
            this.enrollmentControl1.OnReaderConnect += new DPFP.Gui.Enrollment.EnrollmentControl._OnReaderConnect(this.enrollmentControl1_OnReaderConnect);
            this.enrollmentControl1.OnReaderDisconnect += new DPFP.Gui.Enrollment.EnrollmentControl._OnReaderDisconnect(this.enrollmentControl1_OnReaderDisconnect);
            this.enrollmentControl1.OnSampleQuality += new DPFP.Gui.Enrollment.EnrollmentControl._OnSampleQuality(this.enrollmentControl1_OnSampleQuality);
            this.enrollmentControl1.OnStartEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnStartEnroll(this.enrollmentControl1_OnStartEnroll);
            // 
            // verificationControl1
            // 
            this.verificationControl1.Active = true;
            this.verificationControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verificationControl1.Location = new System.Drawing.Point(527, 173);
            this.verificationControl1.Name = "verificationControl1";
            this.verificationControl1.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.verificationControl1.Size = new System.Drawing.Size(48, 47);
            this.verificationControl1.TabIndex = 9;
            this.verificationControl1.Visible = false;
            // 
            // Frm_Regis_huella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 509);
            this.Controls.Add(this.verificationControl1);
            this.Controls.Add(this.enrollmentControl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblIdPersonal);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblPersonal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GroupEvents);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Regis_huella";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Regis_huella";
            this.Load += new System.EventHandler(this.Frm_Regis_huella_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GroupEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox GroupEvents;
        private System.Windows.Forms.ListBox ListEvents;
        private System.Windows.Forms.Label lblIdPersonal;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnCancelar;
        private System.Windows.Forms.Label label2;
        private DPFP.Gui.Enrollment.EnrollmentControl enrollmentControl1;
        private System.Windows.Forms.Label label4;
        private DPFP.Gui.Verification.VerificationControl verificationControl1;
    }
}