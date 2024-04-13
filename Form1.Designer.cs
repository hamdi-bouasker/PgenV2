namespace PgenV2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTNpanel = new System.Windows.Forms.Panel();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.GenrateBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.NUDNumInput = new System.Windows.Forms.NumericUpDown();
            this.NUDCharsInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pwdOutput = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BTNpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCharsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNpanel
            // 
            this.BTNpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTNpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BTNpanel.Controls.Add(this.ClearBtn);
            this.BTNpanel.Controls.Add(this.ExportBtn);
            this.BTNpanel.Controls.Add(this.CopyBtn);
            this.BTNpanel.Controls.Add(this.GenrateBtn);
            this.BTNpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTNpanel.Location = new System.Drawing.Point(0, 0);
            this.BTNpanel.Name = "BTNpanel";
            this.BTNpanel.Size = new System.Drawing.Size(269, 561);
            this.BTNpanel.TabIndex = 0;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Image = ((System.Drawing.Image)(resources.GetObject("ClearBtn.Image")));
            this.ClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClearBtn.Location = new System.Drawing.Point(42, 344);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(193, 39);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear All Inputs";
            this.ClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.ClearBtn, "Click to clear all inputs");
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ExportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportBtn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportBtn.ForeColor = System.Drawing.Color.White;
            this.ExportBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExportBtn.Image")));
            this.ExportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportBtn.Location = new System.Drawing.Point(42, 260);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(193, 39);
            this.ExportBtn.TabIndex = 2;
            this.ExportBtn.Text = "Export as TXT File ";
            this.ExportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.ExportBtn, "Click to export passwords to TXT file");
            this.ExportBtn.UseVisualStyleBackColor = false;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // CopyBtn
            // 
            this.CopyBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.CopyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyBtn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyBtn.ForeColor = System.Drawing.Color.White;
            this.CopyBtn.Image = ((System.Drawing.Image)(resources.GetObject("CopyBtn.Image")));
            this.CopyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyBtn.Location = new System.Drawing.Point(44, 173);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(191, 39);
            this.CopyBtn.TabIndex = 1;
            this.CopyBtn.Text = "Copy Passwords";
            this.CopyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.CopyBtn, "Click to copy passwords");
            this.CopyBtn.UseVisualStyleBackColor = false;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // GenrateBtn
            // 
            this.GenrateBtn.AutoSize = true;
            this.GenrateBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.GenrateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenrateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenrateBtn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenrateBtn.ForeColor = System.Drawing.Color.White;
            this.GenrateBtn.Image = ((System.Drawing.Image)(resources.GetObject("GenrateBtn.Image")));
            this.GenrateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GenrateBtn.Location = new System.Drawing.Point(42, 84);
            this.GenrateBtn.Name = "GenrateBtn";
            this.GenrateBtn.Size = new System.Drawing.Size(193, 39);
            this.GenrateBtn.TabIndex = 0;
            this.GenrateBtn.Text = "Generate Passwords";
            this.GenrateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.GenrateBtn, "Click to generate passwords");
            this.GenrateBtn.UseCompatibleTextRendering = true;
            this.GenrateBtn.UseVisualStyleBackColor = true;
            this.GenrateBtn.Click += new System.EventHandler(this.GenrateBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NUDNumInput);
            this.panel1.Controls.Add(this.NUDCharsInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pwdOutput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(269, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 561);
            this.panel1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBar1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.progressBar1.Location = new System.Drawing.Point(19, 236);
            this.progressBar1.Maximum = 128;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(470, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(19, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "How Many Characters?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NUDNumInput
            // 
            this.NUDNumInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NUDNumInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NUDNumInput.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDNumInput.Location = new System.Drawing.Point(274, 172);
            this.NUDNumInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDNumInput.Name = "NUDNumInput";
            this.NUDNumInput.Size = new System.Drawing.Size(215, 23);
            this.NUDNumInput.TabIndex = 6;
            this.NUDNumInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.NUDNumInput, "Minimum is 1 and Maximum is 100");
            this.NUDNumInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDNumInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUDNumInput_MouseDown);
            // 
            // NUDCharsInput
            // 
            this.NUDCharsInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NUDCharsInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NUDCharsInput.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDCharsInput.Location = new System.Drawing.Point(274, 83);
            this.NUDCharsInput.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.NUDCharsInput.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NUDCharsInput.Name = "NUDCharsInput";
            this.NUDCharsInput.Size = new System.Drawing.Size(215, 23);
            this.NUDCharsInput.TabIndex = 5;
            this.NUDCharsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.NUDCharsInput, "Minimum is 16 and Maximum is 128");
            this.NUDCharsInput.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NUDCharsInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUDCharsInput_MouseDown);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(19, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = " How Many Passwords?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pwdOutput
            // 
            this.pwdOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pwdOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.pwdOutput.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pwdOutput.Location = new System.Drawing.Point(19, 271);
            this.pwdOutput.Multiline = true;
            this.pwdOutput.Name = "pwdOutput";
            this.pwdOutput.ReadOnly = true;
            this.pwdOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pwdOutput.ShortcutsEnabled = false;
            this.pwdOutput.Size = new System.Drawing.Size(470, 270);
            this.pwdOutput.TabIndex = 2;
            this.pwdOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pwdOutput.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P-GEN";
            this.BTNpanel.ResumeLayout(false);
            this.BTNpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCharsInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BTNpanel;
        private System.Windows.Forms.Button GenrateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwdOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDCharsInput;
        private System.Windows.Forms.NumericUpDown NUDNumInput;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

