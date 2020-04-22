namespace Electron_OnlineInstaller
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.ttl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.giturl_verify = new System.Windows.Forms.Button();
			this.giturl = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.git_clone = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ttl
			// 
			this.ttl.AutoSize = true;
			this.ttl.Font = new System.Drawing.Font("Noto Sans JP Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.ttl.Location = new System.Drawing.Point(13, 9);
			this.ttl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ttl.Name = "ttl";
			this.ttl.Size = new System.Drawing.Size(489, 43);
			this.ttl.TabIndex = 0;
			this.ttl.Text = "Web Installer Maker for Electron App";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Noto Sans JP Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Git URL";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.git_clone);
			this.panel1.Controls.Add(this.giturl_verify);
			this.panel1.Controls.Add(this.giturl);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(13, 58);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(544, 342);
			this.panel1.TabIndex = 2;
			// 
			// giturl_verify
			// 
			this.giturl_verify.Font = new System.Drawing.Font("Noto Sans JP Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.giturl_verify.Location = new System.Drawing.Point(372, 11);
			this.giturl_verify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.giturl_verify.Name = "giturl_verify";
			this.giturl_verify.Size = new System.Drawing.Size(85, 31);
			this.giturl_verify.TabIndex = 2;
			this.giturl_verify.Text = "Verify";
			this.giturl_verify.UseVisualStyleBackColor = true;
			// 
			// giturl
			// 
			this.giturl.Font = new System.Drawing.Font("Noto Sans JP Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.giturl.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.giturl.Location = new System.Drawing.Point(76, 11);
			this.giturl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.giturl.Name = "giturl";
			this.giturl.Size = new System.Drawing.Size(288, 31);
			this.giturl.TabIndex = 1;
			this.giturl.WordWrap = false;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(13, 433);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(544, 133);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 406);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Debug Output";
			// 
			// git_clone
			// 
			this.git_clone.Location = new System.Drawing.Point(464, 11);
			this.git_clone.Name = "git_clone";
			this.git_clone.Size = new System.Drawing.Size(75, 31);
			this.git_clone.TabIndex = 3;
			this.git_clone.Text = "Clone";
			this.git_clone.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 578);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ttl);
			this.Font = new System.Drawing.Font("Noto Sans JP Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.Name = "Form1";
			this.Text = "Web Installer Maker for Electron App";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ttl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button giturl_verify;
		private System.Windows.Forms.TextBox giturl;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button git_clone;
	}
}

