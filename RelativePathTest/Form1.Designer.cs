
namespace RelativePathTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_output = new System.Windows.Forms.Label();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.tb_reference = new System.Windows.Forms.TextBox();
            this.tb_tolerance = new System.Windows.Forms.TextBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入绝对路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "参考路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "容忍度路径";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "输出";
            // 
            // l_output
            // 
            this.l_output.AutoSize = true;
            this.l_output.Location = new System.Drawing.Point(122, 172);
            this.l_output.Name = "l_output";
            this.l_output.Size = new System.Drawing.Size(29, 12);
            this.l_output.TabIndex = 4;
            this.l_output.Text = "输出";
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(129, 30);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(657, 21);
            this.tb_input.TabIndex = 5;
            // 
            // tb_reference
            // 
            this.tb_reference.Location = new System.Drawing.Point(129, 72);
            this.tb_reference.Name = "tb_reference";
            this.tb_reference.Size = new System.Drawing.Size(657, 21);
            this.tb_reference.TabIndex = 6;
            // 
            // tb_tolerance
            // 
            this.tb_tolerance.Location = new System.Drawing.Point(129, 115);
            this.tb_tolerance.Name = "tb_tolerance";
            this.tb_tolerance.Size = new System.Drawing.Size(657, 21);
            this.tb_tolerance.TabIndex = 7;
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(129, 202);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(657, 21);
            this.tb_output.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.tb_tolerance);
            this.Controls.Add(this.tb_reference);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.l_output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "计算相对路径";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_output;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.TextBox tb_reference;
        private System.Windows.Forms.TextBox tb_tolerance;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button button1;
    }
}

