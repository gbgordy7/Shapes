namespace Shapes
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listShapes = new System.Windows.Forms.ListBox();
            this.grpCircle = new System.Windows.Forms.GroupBox();
            this.txtCircRadius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpRectangle = new System.Windows.Forms.GroupBox();
            this.txtRecH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.grpDefault = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpCircle.SuspendLayout();
            this.grpRectangle.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpDefault.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(133, 40);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Calculate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listShapes);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Shape";
            // 
            // listShapes
            // 
            this.listShapes.FormattingEnabled = true;
            this.listShapes.ItemHeight = 15;
            this.listShapes.Items.AddRange(new object[] {
            "Circle",
            "Rectangle",
            "Oval",
            "Trapezoid",
            "Octogon",
            "Hexagon"});
            this.listShapes.Location = new System.Drawing.Point(6, 22);
            this.listShapes.Name = "listShapes";
            this.listShapes.Size = new System.Drawing.Size(238, 79);
            this.listShapes.TabIndex = 0;
            this.listShapes.SelectedIndexChanged += new System.EventHandler(this.listShapes_SelectedIndexChanged);
            // 
            // grpCircle
            // 
            this.grpCircle.Controls.Add(this.txtCircRadius);
            this.grpCircle.Controls.Add(this.label4);
            this.grpCircle.Location = new System.Drawing.Point(279, 116);
            this.grpCircle.Name = "grpCircle";
            this.grpCircle.Size = new System.Drawing.Size(250, 100);
            this.grpCircle.TabIndex = 2;
            this.grpCircle.TabStop = false;
            this.grpCircle.Tag = "Circle";
            this.grpCircle.Text = "Circle Parameters";
            // 
            // txtCircRadius
            // 
            this.txtCircRadius.Location = new System.Drawing.Point(86, 28);
            this.txtCircRadius.Name = "txtCircRadius";
            this.txtCircRadius.Size = new System.Drawing.Size(59, 23);
            this.txtCircRadius.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Radius:";
            // 
            // grpRectangle
            // 
            this.grpRectangle.Controls.Add(this.txtRecH);
            this.grpRectangle.Controls.Add(this.label6);
            this.grpRectangle.Controls.Add(this.txtRecW);
            this.grpRectangle.Controls.Add(this.label5);
            this.grpRectangle.Location = new System.Drawing.Point(279, 10);
            this.grpRectangle.Name = "grpRectangle";
            this.grpRectangle.Size = new System.Drawing.Size(250, 100);
            this.grpRectangle.TabIndex = 3;
            this.grpRectangle.TabStop = false;
            this.grpRectangle.Tag = "Rectangle";
            this.grpRectangle.Text = "Rectangle Parameters";
            // 
            // txtRecH
            // 
            this.txtRecH.Location = new System.Drawing.Point(86, 55);
            this.txtRecH.Name = "txtRecH";
            this.txtRecH.Size = new System.Drawing.Size(59, 23);
            this.txtRecH.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Height:";
            // 
            // txtRecW
            // 
            this.txtRecW.Location = new System.Drawing.Point(86, 31);
            this.txtRecW.Name = "txtRecW";
            this.txtRecW.Size = new System.Drawing.Size(59, 23);
            this.txtRecW.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Width:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblArea);
            this.groupBox4.Controls.Add(this.btnCreate);
            this.groupBox4.Location = new System.Drawing.Point(10, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 80);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Area";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(11, 39);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(30, 22);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "--";
            // 
            // grpDefault
            // 
            this.grpDefault.Controls.Add(this.label7);
            this.grpDefault.Location = new System.Drawing.Point(10, 125);
            this.grpDefault.Name = "grpDefault";
            this.grpDefault.Size = new System.Drawing.Size(250, 100);
            this.grpDefault.TabIndex = 5;
            this.grpDefault.TabStop = false;
            this.grpDefault.Tag = "Circle";
            this.grpDefault.Text = "Parameters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "No Shape Selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 316);
            this.Controls.Add(this.grpDefault);
            this.Controls.Add(this.grpRectangle);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpCircle);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Shapes";
            this.groupBox1.ResumeLayout(false);
            this.grpCircle.ResumeLayout(false);
            this.grpCircle.PerformLayout();
            this.grpRectangle.ResumeLayout(false);
            this.grpRectangle.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpDefault.ResumeLayout(false);
            this.grpDefault.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listShapes;
        private System.Windows.Forms.GroupBox grpCircle;
        private System.Windows.Forms.TextBox txtCircRadius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpRectangle;
        private System.Windows.Forms.TextBox txtRecH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRecW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.GroupBox grpDefault;
        private System.Windows.Forms.Label label7;
    }
}

