
namespace Gimbal_Camera_Control.Forms
{
    partial class FormImage
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
            this.checkBoxPip = new System.Windows.Forms.CheckBox();
            this.comboBoxImage = new System.Windows.Forms.ComboBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblManualFocus = new System.Windows.Forms.Label();
            this.lblGrid = new System.Windows.Forms.Label();
            this.lblFocus = new System.Windows.Forms.Label();
            this.numericF = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownZOOM = new System.Windows.Forms.NumericUpDown();
            this.label25lblZoomX = new System.Windows.Forms.Label();
            this.numericZ = new System.Windows.Forms.NumericUpDown();
            this.lblZoom = new System.Windows.Forms.Label();
            this.btnZoomTO = new System.Windows.Forms.Button();
            this.btnStopRecord = new System.Windows.Forms.Button();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.checkBoxManualFoc = new System.Windows.Forms.CheckBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.btnStartRecord = new System.Windows.Forms.Button();
            this.takephoto = new System.Windows.Forms.Button();
            this.btnFocusOut = new System.Windows.Forms.Button();
            this.btnfocusIn = new System.Windows.Forms.Button();
            this.btnZoomout = new System.Windows.Forms.Button();
            this.btnZoomin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZOOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxPip
            // 
            this.checkBoxPip.AutoSize = true;
            this.checkBoxPip.Checked = true;
            this.checkBoxPip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPip.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.checkBoxPip.Location = new System.Drawing.Point(168, 282);
            this.checkBoxPip.Name = "checkBoxPip";
            this.checkBoxPip.Size = new System.Drawing.Size(43, 17);
            this.checkBoxPip.TabIndex = 72;
            this.checkBoxPip.Text = "PIP";
            this.checkBoxPip.UseVisualStyleBackColor = true;
            this.checkBoxPip.CheckedChanged += new System.EventHandler(this.checkBoxPip_CheckedChanged);
            // 
            // comboBoxImage
            // 
            this.comboBoxImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxImage.FormattingEnabled = true;
            this.comboBoxImage.Items.AddRange(new object[] {
            "Visible",
            "IR"});
            this.comboBoxImage.Location = new System.Drawing.Point(122, 278);
            this.comboBoxImage.Name = "comboBoxImage";
            this.comboBoxImage.Size = new System.Drawing.Size(40, 21);
            this.comboBoxImage.TabIndex = 73;
            this.comboBoxImage.SelectedIndexChanged += new System.EventHandler(this.comboBoxImage_SelectedIndexChanged);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblImage.ForeColor = System.Drawing.Color.White;
            this.lblImage.Location = new System.Drawing.Point(67, 279);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(49, 16);
            this.lblImage.TabIndex = 74;
            this.lblImage.Text = "Image:";
            // 
            // lblManualFocus
            // 
            this.lblManualFocus.AutoSize = true;
            this.lblManualFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblManualFocus.ForeColor = System.Drawing.Color.White;
            this.lblManualFocus.Location = new System.Drawing.Point(64, 176);
            this.lblManualFocus.Name = "lblManualFocus";
            this.lblManualFocus.Size = new System.Drawing.Size(95, 16);
            this.lblManualFocus.TabIndex = 68;
            this.lblManualFocus.Text = "Manual Focus:";
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGrid.ForeColor = System.Drawing.Color.White;
            this.lblGrid.Location = new System.Drawing.Point(64, 148);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(36, 16);
            this.lblGrid.TabIndex = 67;
            this.lblGrid.Text = "Grid:";
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFocus.ForeColor = System.Drawing.Color.White;
            this.lblFocus.Location = new System.Drawing.Point(64, 114);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(48, 16);
            this.lblFocus.TabIndex = 65;
            this.lblFocus.Text = "Focus:";
            // 
            // numericF
            // 
            this.numericF.BackColor = System.Drawing.SystemColors.Window;
            this.numericF.Location = new System.Drawing.Point(189, 114);
            this.numericF.Name = "numericF";
            this.numericF.Size = new System.Drawing.Size(35, 20);
            this.numericF.TabIndex = 66;
            // 
            // numericUpDownZOOM
            // 
            this.numericUpDownZOOM.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDownZOOM.Location = new System.Drawing.Point(180, 67);
            this.numericUpDownZOOM.Name = "numericUpDownZOOM";
            this.numericUpDownZOOM.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownZOOM.TabIndex = 60;
            // 
            // label25lblZoomX
            // 
            this.label25lblZoomX.AutoSize = true;
            this.label25lblZoomX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25lblZoomX.ForeColor = System.Drawing.Color.White;
            this.label25lblZoomX.Location = new System.Drawing.Point(241, 71);
            this.label25lblZoomX.Name = "label25lblZoomX";
            this.label25lblZoomX.Size = new System.Drawing.Size(16, 16);
            this.label25lblZoomX.TabIndex = 61;
            this.label25lblZoomX.Text = "X";
            // 
            // numericZ
            // 
            this.numericZ.BackColor = System.Drawing.SystemColors.Window;
            this.numericZ.Location = new System.Drawing.Point(189, 28);
            this.numericZ.Name = "numericZ";
            this.numericZ.Size = new System.Drawing.Size(35, 20);
            this.numericZ.TabIndex = 59;
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZoom.ForeColor = System.Drawing.Color.White;
            this.lblZoom.Location = new System.Drawing.Point(64, 28);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(46, 16);
            this.lblZoom.TabIndex = 58;
            this.lblZoom.Text = "Zoom:";
            // 
            // btnZoomTO
            // 
            this.btnZoomTO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZoomTO.FlatAppearance.BorderSize = 0;
            this.btnZoomTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomTO.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnZoomTO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZoomTO.Location = new System.Drawing.Point(60, 60);
            this.btnZoomTO.Name = "btnZoomTO";
            this.btnZoomTO.Size = new System.Drawing.Size(110, 35);
            this.btnZoomTO.TabIndex = 62;
            this.btnZoomTO.Text = "         ZOOM TO";
            this.btnZoomTO.UseVisualStyleBackColor = true;
            this.btnZoomTO.Click += new System.EventHandler(this.btnZoomTO_Click_1);
            // 
            // btnStopRecord
            // 
            this.btnStopRecord.FlatAppearance.BorderSize = 0;
            this.btnStopRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopRecord.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnStopRecord.Image = global::Gimbal_Camera_Control.Properties.Resources.pause;
            this.btnStopRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopRecord.Location = new System.Drawing.Point(190, 236);
            this.btnStopRecord.Name = "btnStopRecord";
            this.btnStopRecord.Size = new System.Drawing.Size(105, 35);
            this.btnStopRecord.TabIndex = 71;
            this.btnStopRecord.Text = "         Stop Record";
            this.btnStopRecord.UseVisualStyleBackColor = true;
            this.btnStopRecord.Click += new System.EventHandler(this.btnStopRecord_Click);
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Location = new System.Drawing.Point(106, 150);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGrid.TabIndex = 76;
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBoxGrid_CheckedChanged);
            // 
            // checkBoxManualFoc
            // 
            this.checkBoxManualFoc.AutoSize = true;
            this.checkBoxManualFoc.Location = new System.Drawing.Point(163, 178);
            this.checkBoxManualFoc.Name = "checkBoxManualFoc";
            this.checkBoxManualFoc.Size = new System.Drawing.Size(15, 14);
            this.checkBoxManualFoc.TabIndex = 77;
            this.checkBoxManualFoc.UseVisualStyleBackColor = true;
            this.checkBoxManualFoc.CheckedChanged += new System.EventHandler(this.checkBoxManualFoc_CheckedChanged);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "White Hot",
            "Black Hot",
            "Pseudo Color"});
            this.comboBoxColor.Location = new System.Drawing.Point(217, 278);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(77, 21);
            this.comboBoxColor.TabIndex = 78;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // btnStartRecord
            // 
            this.btnStartRecord.FlatAppearance.BorderSize = 0;
            this.btnStartRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartRecord.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnStartRecord.Image = global::Gimbal_Camera_Control.Properties.Resources.play_button1;
            this.btnStartRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartRecord.Location = new System.Drawing.Point(63, 236);
            this.btnStartRecord.Name = "btnStartRecord";
            this.btnStartRecord.Size = new System.Drawing.Size(105, 35);
            this.btnStartRecord.TabIndex = 70;
            this.btnStartRecord.Text = "        Start Record";
            this.btnStartRecord.UseVisualStyleBackColor = true;
            this.btnStartRecord.Click += new System.EventHandler(this.btnStartRecord_Click);
            // 
            // takephoto
            // 
            this.takephoto.FlatAppearance.BorderSize = 0;
            this.takephoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takephoto.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.takephoto.Image = global::Gimbal_Camera_Control.Properties.Resources.camera;
            this.takephoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.takephoto.Location = new System.Drawing.Point(125, 195);
            this.takephoto.Name = "takephoto";
            this.takephoto.Size = new System.Drawing.Size(110, 35);
            this.takephoto.TabIndex = 69;
            this.takephoto.Text = "            Photograph";
            this.takephoto.UseVisualStyleBackColor = true;
            this.takephoto.Click += new System.EventHandler(this.takephoto_Click);
            // 
            // btnFocusOut
            // 
            this.btnFocusOut.Enabled = false;
            this.btnFocusOut.FlatAppearance.BorderSize = 0;
            this.btnFocusOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFocusOut.Image = global::Gimbal_Camera_Control.Properties.Resources.minus1;
            this.btnFocusOut.Location = new System.Drawing.Point(240, 105);
            this.btnFocusOut.Name = "btnFocusOut";
            this.btnFocusOut.Size = new System.Drawing.Size(35, 35);
            this.btnFocusOut.TabIndex = 63;
            this.btnFocusOut.UseVisualStyleBackColor = true;
            this.btnFocusOut.Click += new System.EventHandler(this.btnFocusOut_Click);
            // 
            // btnfocusIn
            // 
            this.btnfocusIn.Enabled = false;
            this.btnfocusIn.FlatAppearance.BorderSize = 0;
            this.btnfocusIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfocusIn.Image = global::Gimbal_Camera_Control.Properties.Resources.plus1;
            this.btnfocusIn.Location = new System.Drawing.Point(135, 105);
            this.btnfocusIn.Name = "btnfocusIn";
            this.btnfocusIn.Size = new System.Drawing.Size(35, 35);
            this.btnfocusIn.TabIndex = 64;
            this.btnfocusIn.UseVisualStyleBackColor = true;
            this.btnfocusIn.Click += new System.EventHandler(this.btnfocusIn_Click);
            // 
            // btnZoomout
            // 
            this.btnZoomout.FlatAppearance.BorderSize = 0;
            this.btnZoomout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomout.Image = global::Gimbal_Camera_Control.Properties.Resources.zoom_out;
            this.btnZoomout.Location = new System.Drawing.Point(240, 19);
            this.btnZoomout.Name = "btnZoomout";
            this.btnZoomout.Size = new System.Drawing.Size(35, 35);
            this.btnZoomout.TabIndex = 56;
            this.btnZoomout.UseVisualStyleBackColor = true;
            this.btnZoomout.Click += new System.EventHandler(this.btnZoomout_Click);
            // 
            // btnZoomin
            // 
            this.btnZoomin.FlatAppearance.BorderSize = 0;
            this.btnZoomin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomin.Image = global::Gimbal_Camera_Control.Properties.Resources.zoom_in;
            this.btnZoomin.Location = new System.Drawing.Point(135, 19);
            this.btnZoomin.Name = "btnZoomin";
            this.btnZoomin.Size = new System.Drawing.Size(35, 35);
            this.btnZoomin.TabIndex = 57;
            this.btnZoomin.UseVisualStyleBackColor = true;
            this.btnZoomin.Click += new System.EventHandler(this.btnZoomin_Click);
            // 
            // FormImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnZoomTO;
            this.ClientSize = new System.Drawing.Size(317, 337);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.checkBoxManualFoc);
            this.Controls.Add(this.checkBoxGrid);
            this.Controls.Add(this.checkBoxPip);
            this.Controls.Add(this.comboBoxImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnStopRecord);
            this.Controls.Add(this.btnStartRecord);
            this.Controls.Add(this.takephoto);
            this.Controls.Add(this.lblManualFocus);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.btnFocusOut);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.btnfocusIn);
            this.Controls.Add(this.numericF);
            this.Controls.Add(this.btnZoomTO);
            this.Controls.Add(this.numericUpDownZOOM);
            this.Controls.Add(this.label25lblZoomX);
            this.Controls.Add(this.btnZoomout);
            this.Controls.Add(this.btnZoomin);
            this.Controls.Add(this.numericZ);
            this.Controls.Add(this.lblZoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormImage";
            this.Text = "FormImage";
            this.Load += new System.EventHandler(this.FormImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZOOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxPip;
        private System.Windows.Forms.ComboBox comboBoxImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnStopRecord;
        private System.Windows.Forms.Button btnStartRecord;
        private System.Windows.Forms.Button takephoto;
        private System.Windows.Forms.Label lblManualFocus;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.Button btnFocusOut;
        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Button btnfocusIn;
        private System.Windows.Forms.NumericUpDown numericF;
        private System.Windows.Forms.Button btnZoomTO;
        private System.Windows.Forms.NumericUpDown numericUpDownZOOM;
        private System.Windows.Forms.Label label25lblZoomX;
        private System.Windows.Forms.Button btnZoomout;
        private System.Windows.Forms.Button btnZoomin;
        private System.Windows.Forms.NumericUpDown numericZ;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.CheckBox checkBoxManualFoc;
        private System.Windows.Forms.ComboBox comboBoxColor;
    }
}