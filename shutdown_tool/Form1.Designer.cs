namespace shutdown_tool
{
    partial class ShutdownTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShutdownTool));
            this.btn_sleep = new System.Windows.Forms.Button();
            this.btn_shutdown = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_sleep_count_down = new System.Windows.Forms.Button();
            this.btn_shutdown_count_down = new System.Windows.Forms.Button();
            this.btn_reload_count_down = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox_select_time = new System.Windows.Forms.ComboBox();
            this.btn_sleep_1 = new System.Windows.Forms.Button();
            this.btn_sleep_1_count_down = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sleep
            // 
            this.btn_sleep.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sleep.Location = new System.Drawing.Point(71, 133);
            this.btn_sleep.Name = "btn_sleep";
            this.btn_sleep.Size = new System.Drawing.Size(130, 60);
            this.btn_sleep.TabIndex = 0;
            this.btn_sleep.Text = "休眠";
            this.btn_sleep.UseVisualStyleBackColor = true;
            this.btn_sleep.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_shutdown
            // 
            this.btn_shutdown.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_shutdown.Location = new System.Drawing.Point(71, 280);
            this.btn_shutdown.Name = "btn_shutdown";
            this.btn_shutdown.Size = new System.Drawing.Size(120, 50);
            this.btn_shutdown.TabIndex = 1;
            this.btn_shutdown.Text = "关机";
            this.btn_shutdown.UseVisualStyleBackColor = true;
            this.btn_shutdown.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reload.Location = new System.Drawing.Point(71, 428);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(120, 50);
            this.btn_reload.TabIndex = 2;
            this.btn_reload.Text = "重启";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_sleep_count_down
            // 
            this.btn_sleep_count_down.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sleep_count_down.Location = new System.Drawing.Point(264, 133);
            this.btn_sleep_count_down.Name = "btn_sleep_count_down";
            this.btn_sleep_count_down.Size = new System.Drawing.Size(210, 50);
            this.btn_sleep_count_down.TabIndex = 3;
            this.btn_sleep_count_down.Text = "倒计时休眠";
            this.btn_sleep_count_down.UseVisualStyleBackColor = true;
            this.btn_sleep_count_down.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_shutdown_count_down
            // 
            this.btn_shutdown_count_down.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_shutdown_count_down.Location = new System.Drawing.Point(264, 280);
            this.btn_shutdown_count_down.Name = "btn_shutdown_count_down";
            this.btn_shutdown_count_down.Size = new System.Drawing.Size(210, 50);
            this.btn_shutdown_count_down.TabIndex = 4;
            this.btn_shutdown_count_down.Text = "倒计时关机";
            this.btn_shutdown_count_down.UseVisualStyleBackColor = true;
            this.btn_shutdown_count_down.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_reload_count_down
            // 
            this.btn_reload_count_down.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reload_count_down.Location = new System.Drawing.Point(264, 428);
            this.btn_reload_count_down.Name = "btn_reload_count_down";
            this.btn_reload_count_down.Size = new System.Drawing.Size(210, 50);
            this.btn_reload_count_down.TabIndex = 5;
            this.btn_reload_count_down.Text = "倒计时重启";
            this.btn_reload_count_down.UseVisualStyleBackColor = true;
            this.btn_reload_count_down.Click += new System.EventHandler(this.btn_reload_count_down_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(643, 64);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "                ---V1.0---\r\n   编译日期：2023.2.6（22:44分）";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox_select_time
            // 
            this.comboBox_select_time.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_select_time.FormattingEnabled = true;
            this.comboBox_select_time.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10",
            "20",
            "30",
            "60",
            "90",
            "120",
            "180",
            "240"});
            this.comboBox_select_time.Location = new System.Drawing.Point(507, 215);
            this.comboBox_select_time.Name = "comboBox_select_time";
            this.comboBox_select_time.Size = new System.Drawing.Size(328, 36);
            this.comboBox_select_time.TabIndex = 7;
            this.comboBox_select_time.Text = "选择倒计时(分钟)";
            this.comboBox_select_time.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_time_SelectedIndexChanged);
            // 
            // btn_sleep_1
            // 
            this.btn_sleep_1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sleep_1.Location = new System.Drawing.Point(71, 576);
            this.btn_sleep_1.Name = "btn_sleep_1";
            this.btn_sleep_1.Size = new System.Drawing.Size(120, 50);
            this.btn_sleep_1.TabIndex = 8;
            this.btn_sleep_1.Text = "睡眠";
            this.btn_sleep_1.UseVisualStyleBackColor = true;
            this.btn_sleep_1.Click += new System.EventHandler(this.btn_sleep_1_Click);
            // 
            // btn_sleep_1_count_down
            // 
            this.btn_sleep_1_count_down.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sleep_1_count_down.Location = new System.Drawing.Point(264, 576);
            this.btn_sleep_1_count_down.Name = "btn_sleep_1_count_down";
            this.btn_sleep_1_count_down.Size = new System.Drawing.Size(210, 50);
            this.btn_sleep_1_count_down.TabIndex = 9;
            this.btn_sleep_1_count_down.Text = "倒计时睡眠";
            this.btn_sleep_1_count_down.UseVisualStyleBackColor = true;
            this.btn_sleep_1_count_down.Click += new System.EventHandler(this.btn_sleep_1_count_down_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reset.Location = new System.Drawing.Point(618, 415);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(96, 77);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.button3_Click);
            // 
            // ShutdownTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 684);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_sleep_1_count_down);
            this.Controls.Add(this.btn_sleep_1);
            this.Controls.Add(this.comboBox_select_time);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_reload_count_down);
            this.Controls.Add(this.btn_shutdown_count_down);
            this.Controls.Add(this.btn_sleep_count_down);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_shutdown);
            this.Controls.Add(this.btn_sleep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShutdownTool";
            this.Text = "Shutdown Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sleep;
        private System.Windows.Forms.Button btn_shutdown;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_sleep_count_down;
        private System.Windows.Forms.Button btn_shutdown_count_down;
        private System.Windows.Forms.Button btn_reload_count_down;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox_select_time;
        private System.Windows.Forms.Button btn_sleep_1;
        private System.Windows.Forms.Button btn_sleep_1_count_down;
        private System.Windows.Forms.Button btn_reset;
    }
}

