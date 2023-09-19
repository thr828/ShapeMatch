namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.readBtn = new System.Windows.Forms.Button();
            this.hSmartWindowControl1 = new HalconDotNet.HSmartWindowControl();
            this.btnCreateCircle = new System.Windows.Forms.Button();
            this.brnLoadModel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(30, 27);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(105, 36);
            this.readBtn.TabIndex = 0;
            this.readBtn.Text = "读取图片";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // hSmartWindowControl1
            // 
            this.hSmartWindowControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hSmartWindowControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.hSmartWindowControl1.HDoubleClickToFitContent = true;
            this.hSmartWindowControl1.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.hSmartWindowControl1.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hSmartWindowControl1.HKeepAspectRatio = true;
            this.hSmartWindowControl1.HMoveContent = true;
            this.hSmartWindowControl1.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.hSmartWindowControl1.Location = new System.Drawing.Point(30, 83);
            this.hSmartWindowControl1.Margin = new System.Windows.Forms.Padding(0);
            this.hSmartWindowControl1.Name = "hSmartWindowControl1";
            this.hSmartWindowControl1.Size = new System.Drawing.Size(1239, 692);
            this.hSmartWindowControl1.TabIndex = 1;
            this.hSmartWindowControl1.WindowSize = new System.Drawing.Size(1239, 692);
            // 
            // btnCreateCircle
            // 
            this.btnCreateCircle.Location = new System.Drawing.Point(167, 29);
            this.btnCreateCircle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCircle.Name = "btnCreateCircle";
            this.btnCreateCircle.Size = new System.Drawing.Size(146, 34);
            this.btnCreateCircle.TabIndex = 2;
            this.btnCreateCircle.Text = "创建圆形";
            this.btnCreateCircle.UseVisualStyleBackColor = true;
            this.btnCreateCircle.Click += new System.EventHandler(this.btnCreateCircle_Click);
            // 
            // brnLoadModel
            // 
            this.brnLoadModel.Location = new System.Drawing.Point(361, 29);
            this.brnLoadModel.Margin = new System.Windows.Forms.Padding(4);
            this.brnLoadModel.Name = "brnLoadModel";
            this.brnLoadModel.Size = new System.Drawing.Size(144, 34);
            this.brnLoadModel.TabIndex = 3;
            this.brnLoadModel.Text = "加载圆形模板";
            this.brnLoadModel.UseVisualStyleBackColor = true;
            this.brnLoadModel.Click += new System.EventHandler(this.brnLoadModel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "显示结果";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 813);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.brnLoadModel);
            this.Controls.Add(this.btnCreateCircle);
            this.Controls.Add(this.hSmartWindowControl1);
            this.Controls.Add(this.readBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readBtn;
        private HalconDotNet.HSmartWindowControl hSmartWindowControl1;
        private System.Windows.Forms.Button btnCreateCircle;
        private System.Windows.Forms.Button brnLoadModel;
        private System.Windows.Forms.Button button1;
    }
}

