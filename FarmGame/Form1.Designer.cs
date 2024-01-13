
namespace FarmGame
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
            this.PotatoesBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TomatoesBar = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CucumbersBar = new System.Windows.Forms.ProgressBar();
            this.PotatoesLabel = new System.Windows.Forms.Label();
            this.TomatoesLabel = new System.Windows.Forms.Label();
            this.Cucumberslabel = new System.Windows.Forms.Label();
            this.WateringBtn = new System.Windows.Forms.Button();
            this.FertilizingBtn = new System.Windows.Forms.Button();
            this.HarvestingBtn = new System.Windows.Forms.Button();
            this.DewormingBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PotatoesBar
            // 
            this.PotatoesBar.Location = new System.Drawing.Point(44, 42);
            this.PotatoesBar.Name = "PotatoesBar";
            this.PotatoesBar.Size = new System.Drawing.Size(100, 23);
            this.PotatoesBar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PotatoesLabel);
            this.groupBox1.Controls.Add(this.PotatoesBar);
            this.groupBox1.Location = new System.Drawing.Point(64, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "土豆";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TomatoesLabel);
            this.groupBox2.Controls.Add(this.TomatoesBar);
            this.groupBox2.Location = new System.Drawing.Point(292, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "西红柿";
            // 
            // TomatoesBar
            // 
            this.TomatoesBar.Location = new System.Drawing.Point(44, 42);
            this.TomatoesBar.Name = "TomatoesBar";
            this.TomatoesBar.Size = new System.Drawing.Size(100, 23);
            this.TomatoesBar.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cucumberslabel);
            this.groupBox3.Controls.Add(this.CucumbersBar);
            this.groupBox3.Location = new System.Drawing.Point(536, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "黄瓜";
            // 
            // CucumbersBar
            // 
            this.CucumbersBar.Location = new System.Drawing.Point(44, 42);
            this.CucumbersBar.Name = "CucumbersBar";
            this.CucumbersBar.Size = new System.Drawing.Size(100, 23);
            this.CucumbersBar.TabIndex = 0;
            // 
            // PotatoesLabel
            // 
            this.PotatoesLabel.AutoSize = true;
            this.PotatoesLabel.Location = new System.Drawing.Point(42, 27);
            this.PotatoesLabel.Name = "PotatoesLabel";
            this.PotatoesLabel.Size = new System.Drawing.Size(0, 12);
            this.PotatoesLabel.TabIndex = 1;
            // 
            // TomatoesLabel
            // 
            this.TomatoesLabel.AutoSize = true;
            this.TomatoesLabel.Location = new System.Drawing.Point(42, 27);
            this.TomatoesLabel.Name = "TomatoesLabel";
            this.TomatoesLabel.Size = new System.Drawing.Size(0, 12);
            this.TomatoesLabel.TabIndex = 2;
            // 
            // Cucumberslabel
            // 
            this.Cucumberslabel.AutoSize = true;
            this.Cucumberslabel.Location = new System.Drawing.Point(42, 27);
            this.Cucumberslabel.Name = "Cucumberslabel";
            this.Cucumberslabel.Size = new System.Drawing.Size(0, 12);
            this.Cucumberslabel.TabIndex = 2;
            // 
            // WateringBtn
            // 
            this.WateringBtn.Location = new System.Drawing.Point(64, 230);
            this.WateringBtn.Name = "WateringBtn";
            this.WateringBtn.Size = new System.Drawing.Size(75, 23);
            this.WateringBtn.TabIndex = 4;
            this.WateringBtn.Text = "浇水";
            this.WateringBtn.UseVisualStyleBackColor = true;
            // 
            // FertilizingBtn
            // 
            this.FertilizingBtn.Location = new System.Drawing.Point(180, 230);
            this.FertilizingBtn.Name = "FertilizingBtn";
            this.FertilizingBtn.Size = new System.Drawing.Size(75, 23);
            this.FertilizingBtn.TabIndex = 5;
            this.FertilizingBtn.Text = "除虫";
            this.FertilizingBtn.UseVisualStyleBackColor = true;
            // 
            // HarvestingBtn
            // 
            this.HarvestingBtn.Location = new System.Drawing.Point(406, 230);
            this.HarvestingBtn.Name = "HarvestingBtn";
            this.HarvestingBtn.Size = new System.Drawing.Size(75, 23);
            this.HarvestingBtn.TabIndex = 6;
            this.HarvestingBtn.Text = "收获";
            this.HarvestingBtn.UseVisualStyleBackColor = true;
            // 
            // DewormingBtn
            // 
            this.DewormingBtn.Location = new System.Drawing.Point(292, 230);
            this.DewormingBtn.Name = "DewormingBtn";
            this.DewormingBtn.Size = new System.Drawing.Size(75, 23);
            this.DewormingBtn.TabIndex = 7;
            this.DewormingBtn.Text = "施肥";
            this.DewormingBtn.UseVisualStyleBackColor = true;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(713, 415);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 8;
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DewormingBtn);
            this.Controls.Add(this.HarvestingBtn);
            this.Controls.Add(this.FertilizingBtn);
            this.Controls.Add(this.WateringBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar PotatoesBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar TomatoesBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar CucumbersBar;
        private System.Windows.Forms.Label PotatoesLabel;
        private System.Windows.Forms.Label TomatoesLabel;
        private System.Windows.Forms.Label Cucumberslabel;
        private System.Windows.Forms.Button WateringBtn;
        private System.Windows.Forms.Button FertilizingBtn;
        private System.Windows.Forms.Button HarvestingBtn;
        private System.Windows.Forms.Button DewormingBtn;
        private System.Windows.Forms.Button RefreshBtn;
    }
}

