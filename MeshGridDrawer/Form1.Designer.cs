
namespace MeshGridDrawer
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
            this.UIpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ParseOpenedFile = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.trackBarPsi = new System.Windows.Forms.TrackBar();
            this.trackBarTheta = new System.Windows.Forms.TrackBar();
            this.UIpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheta)).BeginInit();
            this.SuspendLayout();
            // 
            // UIpanel
            // 
            this.UIpanel.Controls.Add(this.trackBarTheta);
            this.UIpanel.Controls.Add(this.trackBarPsi);
            this.UIpanel.Controls.Add(this.trackBarR);
            this.UIpanel.Controls.Add(this.panel2);
            this.UIpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.UIpanel.Location = new System.Drawing.Point(600, 0);
            this.UIpanel.Name = "UIpanel";
            this.UIpanel.Size = new System.Drawing.Size(200, 450);
            this.UIpanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ParseOpenedFile);
            this.panel2.Controls.Add(this.ButtonOpen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // ParseOpenedFile
            // 
            this.ParseOpenedFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParseOpenedFile.Location = new System.Drawing.Point(99, 0);
            this.ParseOpenedFile.Name = "ParseOpenedFile";
            this.ParseOpenedFile.Size = new System.Drawing.Size(101, 100);
            this.ParseOpenedFile.TabIndex = 1;
            this.ParseOpenedFile.Text = "Apply";
            this.ParseOpenedFile.UseVisualStyleBackColor = true;
            this.ParseOpenedFile.Click += new System.EventHandler(this.ParseOpenedFile_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonOpen.Location = new System.Drawing.Point(0, 0);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(99, 100);
            this.ButtonOpen.TabIndex = 0;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(3, 106);
            this.trackBarR.Maximum = 100;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(194, 45);
            this.trackBarR.TabIndex = 1;
            this.trackBarR.TickFrequency = 10;
            this.trackBarR.Value = 10;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // trackBarPsi
            // 
            this.trackBarPsi.Location = new System.Drawing.Point(3, 157);
            this.trackBarPsi.Maximum = 90;
            this.trackBarPsi.Minimum = -90;
            this.trackBarPsi.Name = "trackBarPsi";
            this.trackBarPsi.Size = new System.Drawing.Size(194, 45);
            this.trackBarPsi.TabIndex = 2;
            this.trackBarPsi.TabStop = false;
            this.trackBarPsi.TickFrequency = 10;
            this.trackBarPsi.Value = 30;
            this.trackBarPsi.Scroll += new System.EventHandler(this.trackBarPsi_Scroll);
            // 
            // trackBarTheta
            // 
            this.trackBarTheta.Location = new System.Drawing.Point(3, 208);
            this.trackBarTheta.Maximum = 180;
            this.trackBarTheta.Minimum = -180;
            this.trackBarTheta.Name = "trackBarTheta";
            this.trackBarTheta.Size = new System.Drawing.Size(194, 45);
            this.trackBarTheta.TabIndex = 3;
            this.trackBarTheta.TickFrequency = 10;
            this.trackBarTheta.Value = 30;
            this.trackBarTheta.Scroll += new System.EventHandler(this.trackBarTheta_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UIpanel);
            this.Name = "Form1";
            this.Text = "GridViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.UIpanel.ResumeLayout(false);
            this.UIpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UIpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ParseOpenedFile;
        private System.Windows.Forms.TrackBar trackBarTheta;
        private System.Windows.Forms.TrackBar trackBarPsi;
        private System.Windows.Forms.TrackBar trackBarR;
    }
}

