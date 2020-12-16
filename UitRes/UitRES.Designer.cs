namespace UitRes
{
    partial class UitRES
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_s = new System.Windows.Forms.Button();
            this.CB_Nc = new System.Windows.Forms.ComboBox();
            this.TB_Rop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(776, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_s
            // 
            this.btn_s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_s.Font = new System.Drawing.Font("宋体", 18F);
            this.btn_s.Location = new System.Drawing.Point(633, 25);
            this.btn_s.Name = "btn_s";
            this.btn_s.Size = new System.Drawing.Size(155, 56);
            this.btn_s.TabIndex = 1;
            this.btn_s.Text = "START";
            this.btn_s.UseVisualStyleBackColor = true;
            this.btn_s.Click += new System.EventHandler(this.btn_s_Click);
            // 
            // CB_Nc
            // 
            this.CB_Nc.Font = new System.Drawing.Font("宋体", 18F);
            this.CB_Nc.FormattingEnabled = true;
            this.CB_Nc.Location = new System.Drawing.Point(434, 29);
            this.CB_Nc.Name = "CB_Nc";
            this.CB_Nc.Size = new System.Drawing.Size(121, 32);
            this.CB_Nc.TabIndex = 2;
            // 
            // TB_Rop
            // 
            this.TB_Rop.Font = new System.Drawing.Font("宋体", 18F);
            this.TB_Rop.Location = new System.Drawing.Point(170, 26);
            this.TB_Rop.Name = "TB_Rop";
            this.TB_Rop.Size = new System.Drawing.Size(100, 35);
            this.TB_Rop.TabIndex = 3;
            this.TB_Rop.Text = "3.095";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proportion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(322, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ncount";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // UitRES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Rop);
            this.Controls.Add(this.CB_Nc);
            this.Controls.Add(this.btn_s);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UitRES";
            this.Text = "UitRES";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_s;
        private System.Windows.Forms.ComboBox CB_Nc;
        private System.Windows.Forms.TextBox TB_Rop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

