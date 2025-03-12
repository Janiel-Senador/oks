namespace SenadorMidtermExam1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnVoteNo = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.btnVoteYes = new System.Windows.Forms.Button();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoteNo
            // 
            this.btnVoteNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoteNo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVoteNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoteNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoteNo.Location = new System.Drawing.Point(481, 132);
            this.btnVoteNo.Name = "btnVoteNo";
            this.btnVoteNo.Size = new System.Drawing.Size(64, 23);
            this.btnVoteNo.TabIndex = 1;
            this.btnVoteNo.Text = "NO";
            this.btnVoteNo.UseVisualStyleBackColor = false;
            this.btnVoteNo.Click += new System.EventHandler(this.btnVoteNo_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(338, 81);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(98, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "ARE YOU GAY?";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.result.Location = new System.Drawing.Point(346, 178);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 3;
            // 
            // btnVoteYes
            // 
            this.btnVoteYes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoteYes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVoteYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoteYes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVoteYes.Location = new System.Drawing.Point(211, 132);
            this.btnVoteYes.Name = "btnVoteYes";
            this.btnVoteYes.Size = new System.Drawing.Size(75, 23);
            this.btnVoteYes.TabIndex = 4;
            this.btnVoteYes.Text = "YES";
            this.btnVoteYes.UseVisualStyleBackColor = false;
            this.btnVoteYes.Click += new System.EventHandler(this.btnVoteYes_Click);
            // 
            // btnFinalize
            // 
            this.btnFinalize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalize.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFinalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinalize.Location = new System.Drawing.Point(341, 194);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(75, 23);
            this.btnFinalize.TabIndex = 5;
            this.btnFinalize.Text = "ENTER";
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-35, -42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(831, 430);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.btnVoteYes);
            this.Controls.Add(this.result);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnVoteNo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoteNo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button btnVoteYes;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

