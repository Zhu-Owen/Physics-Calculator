namespace OwenZhuPhysicsCalculator
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
            this.inivel = new System.Windows.Forms.TextBox();
            this.ctime = new System.Windows.Forms.TextBox();
            this.displace = new System.Windows.Forms.TextBox();
            this.accel = new System.Windows.Forms.TextBox();
            this.finvel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.compute = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ninivel = new System.Windows.Forms.TextBox();
            this.nfinvel = new System.Windows.Forms.TextBox();
            this.naccel = new System.Windows.Forms.TextBox();
            this.ndisplace = new System.Windows.Forms.TextBox();
            this.nctime = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clean = new System.Windows.Forms.Button();
            this.sigFig = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sigFig)).BeginInit();
            this.SuspendLayout();
            // 
            // inivel
            // 
            this.inivel.Location = new System.Drawing.Point(194, 152);
            this.inivel.Margin = new System.Windows.Forms.Padding(6);
            this.inivel.Name = "inivel";
            this.inivel.Size = new System.Drawing.Size(164, 29);
            this.inivel.TabIndex = 0;
            this.inivel.TextChanged += new System.EventHandler(this.inivel_TextChanged);
            // 
            // ctime
            // 
            this.ctime.Location = new System.Drawing.Point(194, 480);
            this.ctime.Margin = new System.Windows.Forms.Padding(6);
            this.ctime.Name = "ctime";
            this.ctime.Size = new System.Drawing.Size(164, 29);
            this.ctime.TabIndex = 1;
            this.ctime.TextChanged += new System.EventHandler(this.ctime_TextChanged);
            // 
            // displace
            // 
            this.displace.Location = new System.Drawing.Point(194, 401);
            this.displace.Margin = new System.Windows.Forms.Padding(6);
            this.displace.Name = "displace";
            this.displace.Size = new System.Drawing.Size(164, 29);
            this.displace.TabIndex = 2;
            this.displace.TextChanged += new System.EventHandler(this.displace_TextChanged);
            // 
            // accel
            // 
            this.accel.Location = new System.Drawing.Point(194, 321);
            this.accel.Margin = new System.Windows.Forms.Padding(6);
            this.accel.Name = "accel";
            this.accel.Size = new System.Drawing.Size(164, 29);
            this.accel.TabIndex = 3;
            this.accel.TextChanged += new System.EventHandler(this.accel_TextChanged);
            // 
            // finvel
            // 
            this.finvel.Location = new System.Drawing.Point(194, 237);
            this.finvel.Margin = new System.Windows.Forms.Padding(6);
            this.finvel.Name = "finvel";
            this.finvel.Size = new System.Drawing.Size(164, 29);
            this.finvel.TabIndex = 4;
            this.finvel.TextChanged += new System.EventHandler(this.finvel_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Initial Velocity:";
            this.toolTip.SetToolTip(this.label2, "Enter the initial velocity");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Final Velocity:";
            this.toolTip.SetToolTip(this.label3, "Enter the final velocity");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Acceleration:";
            this.toolTip.SetToolTip(this.label4, "Enter the acceleration");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Displacement:";
            this.toolTip.SetToolTip(this.label5, "Enter the displacement");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 480);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "ΔTime:";
            this.toolTip.SetToolTip(this.label6, "Enter the change in time");
            // 
            // compute
            // 
            this.compute.Location = new System.Drawing.Point(394, 217);
            this.compute.Margin = new System.Windows.Forms.Padding(6);
            this.compute.Name = "compute";
            this.compute.Size = new System.Drawing.Size(274, 109);
            this.compute.TabIndex = 10;
            this.compute.Text = "Calculate!";
            this.toolTip.SetToolTip(this.compute, "Press to calculate for 2 unknowns\r\n");
            this.compute.UseVisualStyleBackColor = true;
            this.compute.Click += new System.EventHandler(this.compute_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(682, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Initial Velocity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(684, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Final Velocity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(692, 321);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Acceleration:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(682, 398);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Displacement:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(742, 480);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "ΔTime:";
            // 
            // ninivel
            // 
            this.ninivel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ninivel.Location = new System.Drawing.Point(823, 152);
            this.ninivel.Margin = new System.Windows.Forms.Padding(6);
            this.ninivel.Name = "ninivel";
            this.ninivel.ReadOnly = true;
            this.ninivel.Size = new System.Drawing.Size(164, 29);
            this.ninivel.TabIndex = 16;
            // 
            // nfinvel
            // 
            this.nfinvel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nfinvel.Location = new System.Drawing.Point(823, 233);
            this.nfinvel.Margin = new System.Windows.Forms.Padding(6);
            this.nfinvel.Name = "nfinvel";
            this.nfinvel.ReadOnly = true;
            this.nfinvel.Size = new System.Drawing.Size(164, 29);
            this.nfinvel.TabIndex = 17;
            // 
            // naccel
            // 
            this.naccel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.naccel.Location = new System.Drawing.Point(823, 317);
            this.naccel.Margin = new System.Windows.Forms.Padding(6);
            this.naccel.Name = "naccel";
            this.naccel.ReadOnly = true;
            this.naccel.Size = new System.Drawing.Size(164, 29);
            this.naccel.TabIndex = 18;
            // 
            // ndisplace
            // 
            this.ndisplace.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ndisplace.Location = new System.Drawing.Point(823, 398);
            this.ndisplace.Margin = new System.Windows.Forms.Padding(6);
            this.ndisplace.Name = "ndisplace";
            this.ndisplace.ReadOnly = true;
            this.ndisplace.Size = new System.Drawing.Size(164, 29);
            this.ndisplace.TabIndex = 19;
            // 
            // nctime
            // 
            this.nctime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nctime.Location = new System.Drawing.Point(823, 477);
            this.nctime.Margin = new System.Windows.Forms.Padding(6);
            this.nctime.Name = "nctime";
            this.nctime.ReadOnly = true;
            this.nctime.Size = new System.Drawing.Size(164, 29);
            this.nctime.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(395, 483);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 25);
            this.label14.TabIndex = 24;
            this.label14.Text = "# of Significant Digits:";
            this.toolTip.SetToolTip(this.label14, "Set the number of significant digits.\r\nNote, decimal trailing zeros are not shown" +
        " when solving");
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(394, 357);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(274, 106);
            this.clean.TabIndex = 29;
            this.clean.Text = "Clear";
            this.toolTip.SetToolTip(this.clean, "Clears all the input variables");
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // sigFig
            // 
            this.sigFig.Location = new System.Drawing.Point(602, 481);
            this.sigFig.Name = "sigFig";
            this.sigFig.Size = new System.Drawing.Size(66, 29);
            this.sigFig.TabIndex = 25;
            this.sigFig.ValueChanged += new System.EventHandler(this.sigFig_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(62, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(875, 49);
            this.label12.TabIndex = 26;
            this.label12.Text = "Kinematics Equations for Uniform Acceleration";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(389, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(251, 50);
            this.label13.TabIndex = 27;
            this.label13.Text = "Provide 3 of the 5 variables \r\nand solve the other 2!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 589);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sigFig);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nctime);
            this.Controls.Add(this.ndisplace);
            this.Controls.Add(this.naccel);
            this.Controls.Add(this.nfinvel);
            this.Controls.Add(this.ninivel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.compute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finvel);
            this.Controls.Add(this.accel);
            this.Controls.Add(this.displace);
            this.Controls.Add(this.ctime);
            this.Controls.Add(this.inivel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sigFig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inivel;
        private System.Windows.Forms.TextBox ctime;
        private System.Windows.Forms.TextBox displace;
        private System.Windows.Forms.TextBox accel;
        private System.Windows.Forms.TextBox finvel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button compute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ninivel;
        private System.Windows.Forms.TextBox nfinvel;
        private System.Windows.Forms.TextBox naccel;
        private System.Windows.Forms.TextBox ndisplace;
        private System.Windows.Forms.TextBox nctime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NumericUpDown sigFig;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button clean;
    }
}

