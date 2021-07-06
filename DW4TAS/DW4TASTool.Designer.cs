
namespace DW4TAS
{
	partial class DW4TasTool
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TestLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TestLabel
			// 
			this.TestLabel.AutoSize = true;
			this.TestLabel.Location = new System.Drawing.Point(12, 9);
			this.TestLabel.Name = "TestLabel";
			this.TestLabel.Size = new System.Drawing.Size(35, 13);
			this.TestLabel.TabIndex = 0;
			this.TestLabel.Text = "label1";
			// 
			// DW4TasTool
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 390);
			this.Controls.Add(this.TestLabel);
			this.Name = "DW4TasTool";
			this.Text = "Dragon Warrior 4 TAS Tool";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TestLabel;
	}
}

