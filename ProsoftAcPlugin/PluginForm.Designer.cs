namespace ProsoftAcPlugin
{
    partial class PluginForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCircle3Color = new System.Windows.Forms.Label();
            this.lblCircle2Color = new System.Windows.Forms.Label();
            this.lblCircle1Color = new System.Windows.Forms.Label();
            this.txtBlockName = new System.Windows.Forms.TextBox();
            this.btnSubmitCircle = new System.Windows.Forms.Button();
            this.btnCircle3Color = new System.Windows.Forms.Button();
            this.btnCircle2Color = new System.Windows.Forms.Button();
            this.btnCircle1Color = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.circleColorDialog = new System.Windows.Forms.ColorDialog();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblDeep = new System.Windows.Forms.Label();
            this.txtDeep = new System.Windows.Forms.TextBox();
            this.btnSubmitSquare = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCircle3Color);
            this.groupBox1.Controls.Add(this.lblCircle2Color);
            this.groupBox1.Controls.Add(this.lblCircle1Color);
            this.groupBox1.Controls.Add(this.txtBlockName);
            this.groupBox1.Controls.Add(this.btnSubmitCircle);
            this.groupBox1.Controls.Add(this.btnCircle3Color);
            this.groupBox1.Controls.Add(this.btnCircle2Color);
            this.groupBox1.Controls.Add(this.btnCircle1Color);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concentric Circles";
            // 
            // lblCircle3Color
            // 
            this.lblCircle3Color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCircle3Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCircle3Color.Location = new System.Drawing.Point(144, 166);
            this.lblCircle3Color.Name = "lblCircle3Color";
            this.lblCircle3Color.Size = new System.Drawing.Size(33, 33);
            this.lblCircle3Color.TabIndex = 4;
            // 
            // lblCircle2Color
            // 
            this.lblCircle2Color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCircle2Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCircle2Color.Location = new System.Drawing.Point(144, 126);
            this.lblCircle2Color.Name = "lblCircle2Color";
            this.lblCircle2Color.Size = new System.Drawing.Size(33, 33);
            this.lblCircle2Color.TabIndex = 4;
            // 
            // lblCircle1Color
            // 
            this.lblCircle1Color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCircle1Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCircle1Color.Location = new System.Drawing.Point(144, 87);
            this.lblCircle1Color.Name = "lblCircle1Color";
            this.lblCircle1Color.Size = new System.Drawing.Size(33, 33);
            this.lblCircle1Color.TabIndex = 4;
            // 
            // txtBlockName
            // 
            this.txtBlockName.Location = new System.Drawing.Point(9, 46);
            this.txtBlockName.Name = "txtBlockName";
            this.txtBlockName.Size = new System.Drawing.Size(112, 20);
            this.txtBlockName.TabIndex = 1;
            this.txtBlockName.TextChanged += new System.EventHandler(this.txtBlockName_TextChanged);
            // 
            // btnSubmitCircle
            // 
            this.btnSubmitCircle.Location = new System.Drawing.Point(9, 223);
            this.btnSubmitCircle.Name = "btnSubmitCircle";
            this.btnSubmitCircle.Size = new System.Drawing.Size(112, 33);
            this.btnSubmitCircle.TabIndex = 5;
            this.btnSubmitCircle.Text = "Submit";
            this.btnSubmitCircle.UseVisualStyleBackColor = true;
            this.btnSubmitCircle.Click += new System.EventHandler(this.btnSubmitCircle_Click);
            // 
            // btnCircle3Color
            // 
            this.btnCircle3Color.Location = new System.Drawing.Point(9, 166);
            this.btnCircle3Color.Name = "btnCircle3Color";
            this.btnCircle3Color.Size = new System.Drawing.Size(112, 33);
            this.btnCircle3Color.TabIndex = 4;
            this.btnCircle3Color.Text = "Circle 3 Color";
            this.btnCircle3Color.UseVisualStyleBackColor = true;
            this.btnCircle3Color.Click += new System.EventHandler(this.btnCircle3Color_Click);
            // 
            // btnCircle2Color
            // 
            this.btnCircle2Color.Location = new System.Drawing.Point(9, 126);
            this.btnCircle2Color.Name = "btnCircle2Color";
            this.btnCircle2Color.Size = new System.Drawing.Size(112, 33);
            this.btnCircle2Color.TabIndex = 3;
            this.btnCircle2Color.Text = "Circle 2 Color";
            this.btnCircle2Color.UseVisualStyleBackColor = true;
            this.btnCircle2Color.Click += new System.EventHandler(this.btnCircle2Color_Click);
            // 
            // btnCircle1Color
            // 
            this.btnCircle1Color.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCircle1Color.Location = new System.Drawing.Point(9, 87);
            this.btnCircle1Color.Name = "btnCircle1Color";
            this.btnCircle1Color.Size = new System.Drawing.Size(112, 33);
            this.btnCircle1Color.TabIndex = 2;
            this.btnCircle1Color.Text = "Circle 1 Color";
            this.btnCircle1Color.UseVisualStyleBackColor = true;
            this.btnCircle1Color.Click += new System.EventHandler(this.btnCircle1Color_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Block Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDeep);
            this.groupBox2.Controls.Add(this.lblDeep);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.lblHeight);
            this.groupBox2.Controls.Add(this.btnSubmitSquare);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.lblWidth);
            this.groupBox2.Location = new System.Drawing.Point(219, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Square";
            // 
            // circleColorDialog
            // 
            this.circleColorDialog.AllowFullOpen = false;
            this.circleColorDialog.AnyColor = true;
            this.circleColorDialog.Color = System.Drawing.Color.White;
            this.circleColorDialog.SolidColorOnly = true;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(9, 45);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(112, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(6, 29);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(6, 84);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(9, 100);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(112, 20);
            this.txtHeight.TabIndex = 3;
            // 
            // lblDeep
            // 
            this.lblDeep.AutoSize = true;
            this.lblDeep.Location = new System.Drawing.Point(6, 147);
            this.lblDeep.Name = "lblDeep";
            this.lblDeep.Size = new System.Drawing.Size(33, 13);
            this.lblDeep.TabIndex = 2;
            this.lblDeep.Text = "Deep";
            // 
            // txtDeep
            // 
            this.txtDeep.Location = new System.Drawing.Point(9, 163);
            this.txtDeep.Name = "txtDeep";
            this.txtDeep.Size = new System.Drawing.Size(112, 20);
            this.txtDeep.TabIndex = 3;
            // 
            // btnSubmitSquare
            // 
            this.btnSubmitSquare.Location = new System.Drawing.Point(9, 223);
            this.btnSubmitSquare.Name = "btnSubmitSquare";
            this.btnSubmitSquare.Size = new System.Drawing.Size(112, 33);
            this.btnSubmitSquare.TabIndex = 5;
            this.btnSubmitSquare.Text = "Submit";
            this.btnSubmitSquare.UseVisualStyleBackColor = true;
            this.btnSubmitSquare.Click += new System.EventHandler(this.btnSubmitCircle_Click);
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PluginForm";
            this.Text = "Concentric Circles Add in";
            this.Load += new System.EventHandler(this.PluginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCircle3Color;
        private System.Windows.Forms.Label lblCircle2Color;
        private System.Windows.Forms.Label lblCircle1Color;
        private System.Windows.Forms.TextBox txtBlockName;
        private System.Windows.Forms.Button btnSubmitCircle;
        private System.Windows.Forms.Button btnCircle3Color;
        private System.Windows.Forms.Button btnCircle2Color;
        private System.Windows.Forms.Button btnCircle1Color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColorDialog circleColorDialog;
        private System.Windows.Forms.TextBox txtDeep;
        private System.Windows.Forms.Label lblDeep;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnSubmitSquare;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
    }
}