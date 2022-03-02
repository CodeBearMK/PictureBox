namespace PictureBox
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnLarge = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(50, 32);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(363, 314);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(223, 379);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(83, 32);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "上一張";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(333, 379);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 32);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "下一張";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(329, 430);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(84, 29);
            this.btnSmall.TabIndex = 3;
            this.btnSmall.Text = "縮小";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnLarge
            // 
            this.btnLarge.Location = new System.Drawing.Point(223, 430);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(80, 29);
            this.btnLarge.TabIndex = 4;
            this.btnLarge.Text = "放大";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCurrent.Location = new System.Drawing.Point(12, 391);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(53, 20);
            this.lblCurrent.TabIndex = 5;
            this.lblCurrent.Text = "label1";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRate.Location = new System.Drawing.Point(12, 433);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(53, 20);
            this.lblRate.TabIndex = 6;
            this.lblRate.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 482);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "圖像瀏覽縮放器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnLarge;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblRate;
    }
}

