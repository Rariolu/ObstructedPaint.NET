namespace PaintByAPI
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.nup4 = new System.Windows.Forms.NumericUpDown();
            this.nup3 = new System.Windows.Forms.NumericUpDown();
            this.nup2 = new System.Windows.Forms.NumericUpDown();
            this.nup1 = new System.Windows.Forms.NumericUpDown();
            this.nupPenSize = new System.Windows.Forms.NumericUpDown();
            this.lblColour = new System.Windows.Forms.Label();
            this.btnChangeColour = new System.Windows.Forms.Button();
            this.lblPenPosition = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblPenState = new System.Windows.Forms.Label();
            this.btnPen = new System.Windows.Forms.Button();
            this.pbCanvas = new PaintByAPI.PaintBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPenSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSendCode);
            this.panel1.Controls.Add(this.nup4);
            this.panel1.Controls.Add(this.nup3);
            this.panel1.Controls.Add(this.nup2);
            this.panel1.Controls.Add(this.nup1);
            this.panel1.Controls.Add(this.nupPenSize);
            this.panel1.Controls.Add(this.lblColour);
            this.panel1.Controls.Add(this.btnChangeColour);
            this.panel1.Controls.Add(this.lblPenPosition);
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.lblPenState);
            this.panel1.Controls.Add(this.btnPen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 144);
            this.panel1.TabIndex = 0;
            // 
            // btnSendCode
            // 
            this.btnSendCode.Location = new System.Drawing.Point(185, 109);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(75, 23);
            this.btnSendCode.TabIndex = 14;
            this.btnSendCode.Text = "Send Code";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // nup4
            // 
            this.nup4.Location = new System.Drawing.Point(144, 112);
            this.nup4.Name = "nup4";
            this.nup4.Size = new System.Drawing.Size(35, 20);
            this.nup4.TabIndex = 13;
            // 
            // nup3
            // 
            this.nup3.Location = new System.Drawing.Point(103, 112);
            this.nup3.Name = "nup3";
            this.nup3.Size = new System.Drawing.Size(35, 20);
            this.nup3.TabIndex = 12;
            // 
            // nup2
            // 
            this.nup2.Location = new System.Drawing.Point(62, 112);
            this.nup2.Name = "nup2";
            this.nup2.Size = new System.Drawing.Size(35, 20);
            this.nup2.TabIndex = 11;
            // 
            // nup1
            // 
            this.nup1.Location = new System.Drawing.Point(21, 112);
            this.nup1.Name = "nup1";
            this.nup1.Size = new System.Drawing.Size(35, 20);
            this.nup1.TabIndex = 10;
            // 
            // nupPenSize
            // 
            this.nupPenSize.Location = new System.Drawing.Point(243, 67);
            this.nupPenSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPenSize.Name = "nupPenSize";
            this.nupPenSize.Size = new System.Drawing.Size(64, 20);
            this.nupPenSize.TabIndex = 9;
            this.nupPenSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nupPenSize.ValueChanged += new System.EventHandler(this.nupPenSize_ValueChanged);
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(313, 33);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(37, 13);
            this.lblColour.TabIndex = 8;
            this.lblColour.Text = "(0,0,0)";
            // 
            // btnChangeColour
            // 
            this.btnChangeColour.Location = new System.Drawing.Point(232, 21);
            this.btnChangeColour.Name = "btnChangeColour";
            this.btnChangeColour.Size = new System.Drawing.Size(75, 36);
            this.btnChangeColour.TabIndex = 7;
            this.btnChangeColour.Text = "Change Colour";
            this.btnChangeColour.UseVisualStyleBackColor = true;
            this.btnChangeColour.Click += new System.EventHandler(this.btnChangeColour_Click);
            // 
            // lblPenPosition
            // 
            this.lblPenPosition.AutoSize = true;
            this.lblPenPosition.Location = new System.Drawing.Point(173, 74);
            this.lblPenPosition.Name = "lblPenPosition";
            this.lblPenPosition.Size = new System.Drawing.Size(28, 13);
            this.lblPenPosition.TabIndex = 6;
            this.lblPenPosition.Text = "(0,0)";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(74, 64);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(126, 35);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(21, 35);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(74, 6);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblPenState
            // 
            this.lblPenState.AutoSize = true;
            this.lblPenState.Location = new System.Drawing.Point(405, 45);
            this.lblPenState.Name = "lblPenState";
            this.lblPenState.Size = new System.Drawing.Size(43, 13);
            this.lblPenState.TabIndex = 1;
            this.lblPenState.Text = "Pen Up";
            // 
            // btnPen
            // 
            this.btnPen.Location = new System.Drawing.Point(464, 21);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(127, 61);
            this.btnPen.TabIndex = 0;
            this.btnPen.Text = "Pen";
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.White;
            this.pbCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCanvas.Location = new System.Drawing.Point(0, 0);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.PenColour = System.Drawing.Color.Black;
            this.pbCanvas.PenDown = false;
            this.pbCanvas.PenPosition = new System.Drawing.Point(0, 0);
            this.pbCanvas.PenWidth = 1F;
            this.pbCanvas.Size = new System.Drawing.Size(603, 336);
            this.pbCanvas.TabIndex = 1;
            this.pbCanvas.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 480);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPenSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PaintBox pbCanvas;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Label lblPenState;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblPenPosition;
        private System.Windows.Forms.Button btnChangeColour;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.NumericUpDown nupPenSize;
        private System.Windows.Forms.NumericUpDown nup3;
        private System.Windows.Forms.NumericUpDown nup2;
        private System.Windows.Forms.NumericUpDown nup1;
        private System.Windows.Forms.NumericUpDown nup4;
        private System.Windows.Forms.Button btnSendCode;
    }
}

