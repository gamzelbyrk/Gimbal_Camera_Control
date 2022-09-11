
namespace Gimbal_Camera_Control.Forms
{
    partial class TrackForm
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnPointToTrack = new System.Windows.Forms.Button();
            this.comboBoxTSize = new System.Windows.Forms.ComboBox();
            this.lblTrackTemplatesize = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.btnOffVehicle = new System.Windows.Forms.Button();
            this.btnOnVehicle = new System.Windows.Forms.Button();
            this.btnStpTrck = new System.Windows.Forms.Button();
            this.btnStrtTrck = new System.Windows.Forms.Button();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.panel10.Controls.Add(this.btnPointToTrack);
            this.panel10.Controls.Add(this.comboBoxTSize);
            this.panel10.Controls.Add(this.lblTrackTemplatesize);
            this.panel10.Controls.Add(this.button21);
            this.panel10.Controls.Add(this.btnOffVehicle);
            this.panel10.Controls.Add(this.btnOnVehicle);
            this.panel10.Controls.Add(this.btnStpTrck);
            this.panel10.Controls.Add(this.btnStrtTrck);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(297, 308);
            this.panel10.TabIndex = 3;
            // 
            // btnPointToTrack
            // 
            this.btnPointToTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPointToTrack.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnPointToTrack.Location = new System.Drawing.Point(96, 66);
            this.btnPointToTrack.Name = "btnPointToTrack";
            this.btnPointToTrack.Size = new System.Drawing.Size(158, 35);
            this.btnPointToTrack.TabIndex = 33;
            this.btnPointToTrack.Text = "Point To Track";
            this.btnPointToTrack.UseVisualStyleBackColor = true;
            this.btnPointToTrack.Click += new System.EventHandler(this.btnPointToTrack_Click);
            // 
            // comboBoxTSize
            // 
            this.comboBoxTSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTSize.FormattingEnabled = true;
            this.comboBoxTSize.Items.AddRange(new object[] {
            "Auto",
            "32",
            "64",
            "128"});
            this.comboBoxTSize.Location = new System.Drawing.Point(229, 262);
            this.comboBoxTSize.Name = "comboBoxTSize";
            this.comboBoxTSize.Size = new System.Drawing.Size(40, 21);
            this.comboBoxTSize.TabIndex = 32;
            this.comboBoxTSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxTSize_SelectedIndexChanged);
            // 
            // lblTrackTemplatesize
            // 
            this.lblTrackTemplatesize.AutoSize = true;
            this.lblTrackTemplatesize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrackTemplatesize.ForeColor = System.Drawing.Color.White;
            this.lblTrackTemplatesize.Location = new System.Drawing.Point(86, 262);
            this.lblTrackTemplatesize.Name = "lblTrackTemplatesize";
            this.lblTrackTemplatesize.Size = new System.Drawing.Size(136, 16);
            this.lblTrackTemplatesize.TabIndex = 31;
            this.lblTrackTemplatesize.Text = "Track Template Size:";
            // 
            // button21
            // 
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.button21.Location = new System.Drawing.Point(96, 207);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(158, 35);
            this.button21.TabIndex = 4;
            this.button21.Text = "Recognition To Tracking";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // btnOffVehicle
            // 
            this.btnOffVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffVehicle.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnOffVehicle.Location = new System.Drawing.Point(96, 161);
            this.btnOffVehicle.Name = "btnOffVehicle";
            this.btnOffVehicle.Size = new System.Drawing.Size(158, 35);
            this.btnOffVehicle.TabIndex = 3;
            this.btnOffVehicle.Text = "Turn Off Vehicle Recognition";
            this.btnOffVehicle.UseVisualStyleBackColor = true;
            this.btnOffVehicle.Click += new System.EventHandler(this.btnOffVehicle_Click);
            // 
            // btnOnVehicle
            // 
            this.btnOnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnVehicle.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnOnVehicle.Location = new System.Drawing.Point(96, 116);
            this.btnOnVehicle.Name = "btnOnVehicle";
            this.btnOnVehicle.Size = new System.Drawing.Size(158, 35);
            this.btnOnVehicle.TabIndex = 2;
            this.btnOnVehicle.Text = "Turn On Vehicle Recognition";
            this.btnOnVehicle.UseVisualStyleBackColor = true;
            this.btnOnVehicle.Click += new System.EventHandler(this.btnOnVehicle_Click);
            // 
            // btnStpTrck
            // 
            this.btnStpTrck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStpTrck.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnStpTrck.Location = new System.Drawing.Point(184, 12);
            this.btnStpTrck.Name = "btnStpTrck";
            this.btnStpTrck.Size = new System.Drawing.Size(110, 35);
            this.btnStpTrck.TabIndex = 1;
            this.btnStpTrck.Text = "Stop Track";
            this.btnStpTrck.UseVisualStyleBackColor = true;
            this.btnStpTrck.Click += new System.EventHandler(this.btnStpTrck_Click);
            // 
            // btnStrtTrck
            // 
            this.btnStrtTrck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrtTrck.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnStrtTrck.Location = new System.Drawing.Point(57, 12);
            this.btnStrtTrck.Name = "btnStrtTrck";
            this.btnStrtTrck.Size = new System.Drawing.Size(110, 35);
            this.btnStrtTrck.TabIndex = 0;
            this.btnStrtTrck.Text = "Start Track";
            this.btnStrtTrck.UseVisualStyleBackColor = true;
            this.btnStrtTrck.Click += new System.EventHandler(this.btnStrtTrck_Click);
            // 
            // TrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 308);
            this.Controls.Add(this.panel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrackForm";
            this.Text = "TrackForm";
            this.Load += new System.EventHandler(this.TrackForm_Load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox comboBoxTSize;
        private System.Windows.Forms.Label lblTrackTemplatesize;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button btnOffVehicle;
        private System.Windows.Forms.Button btnOnVehicle;
        private System.Windows.Forms.Button btnStpTrck;
        private System.Windows.Forms.Button btnStrtTrck;
        private System.Windows.Forms.Button btnPointToTrack;
    }
}