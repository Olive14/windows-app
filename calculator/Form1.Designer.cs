
namespace windows_app {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.TitleLabel = new System.Windows.Forms.Label();
			this.OperandText1 = new System.Windows.Forms.TextBox();
			this.OperandText2 = new System.Windows.Forms.TextBox();
			this.ExecuteCalcBtn = new System.Windows.Forms.Button();
			this.AnswerLabel = new System.Windows.Forms.Label();
			this.OperatorComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.TitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.TitleLabel.Location = new System.Drawing.Point(291, 58);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(124, 32);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Calculator";
			this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
			// 
			// OperandText1
			// 
			this.OperandText1.Location = new System.Drawing.Point(95, 208);
			this.OperandText1.Name = "OperandText1";
			this.OperandText1.Size = new System.Drawing.Size(100, 23);
			this.OperandText1.TabIndex = 2;
			this.OperandText1.TextChanged += new System.EventHandler(this.OperandText1_TextChanged);
			// 
			// OperandText2
			// 
			this.OperandText2.Location = new System.Drawing.Point(315, 208);
			this.OperandText2.Name = "OperandText2";
			this.OperandText2.Size = new System.Drawing.Size(100, 23);
			this.OperandText2.TabIndex = 3;
			this.OperandText2.TextChanged += new System.EventHandler(this.OperandText2_TextChanged);
			// 
			// ExecuteCalcBtn
			// 
			this.ExecuteCalcBtn.Location = new System.Drawing.Point(435, 208);
			this.ExecuteCalcBtn.Name = "ExecuteCalcBtn";
			this.ExecuteCalcBtn.Size = new System.Drawing.Size(75, 23);
			this.ExecuteCalcBtn.TabIndex = 4;
			this.ExecuteCalcBtn.Text = "  = ";
			this.ExecuteCalcBtn.UseVisualStyleBackColor = true;
			this.ExecuteCalcBtn.Click += new System.EventHandler(this.ExecuteCalcBtn_Click);
			// 
			// AnswerLabel
			// 
			this.AnswerLabel.AutoSize = true;
			this.AnswerLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AnswerLabel.Location = new System.Drawing.Point(529, 211);
			this.AnswerLabel.Name = "AnswerLabel";
			this.AnswerLabel.Size = new System.Drawing.Size(0, 20);
			this.AnswerLabel.TabIndex = 5;
			this.AnswerLabel.Click += new System.EventHandler(this.AnswerLabel_Click);
			// 
			// OperatorComboBox
			// 
			this.OperatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.OperatorComboBox.FormattingEnabled = true;
			this.OperatorComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
			this.OperatorComboBox.Location = new System.Drawing.Point(220, 208);
			this.OperatorComboBox.Name = "OperatorComboBox";
			this.OperatorComboBox.Size = new System.Drawing.Size(67, 23);
			this.OperatorComboBox.TabIndex = 7;
			this.OperatorComboBox.SelectedIndexChanged += new System.EventHandler(this.OperatorComboBox_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.OperatorComboBox);
			this.Controls.Add(this.AnswerLabel);
			this.Controls.Add(this.ExecuteCalcBtn);
			this.Controls.Add(this.OperandText2);
			this.Controls.Add(this.OperandText1);
			this.Controls.Add(this.TitleLabel);
			this.Name = "Form1";
			this.Text = "My Window";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.TextBox OperandText1;
		private System.Windows.Forms.TextBox OperandText2;
		private System.Windows.Forms.Button ExecuteCalcBtn;
		private System.Windows.Forms.Label AnswerLabel;
		private System.Windows.Forms.ComboBox OperatorComboBox;
	}
}

