namespace lab3NEW
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rbtnBook = new System.Windows.Forms.RadioButton();
			this.rbtnFilm = new System.Windows.Forms.RadioButton();
			this.rbtnDog = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(570, 154);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(109, 35);
			this.button4.TabIndex = 17;
			this.button4.Text = "Serialize";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(24, 154);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(109, 35);
			this.button5.TabIndex = 18;
			this.button5.Text = "Deserialize";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(157, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(522, 132);
			this.listBox1.TabIndex = 19;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 13);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 16);
			this.label1.TabIndex = 23;
			this.label1.Text = "Класс объекта:";
			// 
			// rbtnBook
			// 
			this.rbtnBook.AutoSize = true;
			this.rbtnBook.Location = new System.Drawing.Point(48, 105);
			this.rbtnBook.Margin = new System.Windows.Forms.Padding(4);
			this.rbtnBook.Name = "rbtnBook";
			this.rbtnBook.Size = new System.Drawing.Size(60, 20);
			this.rbtnBook.TabIndex = 22;
			this.rbtnBook.TabStop = true;
			this.rbtnBook.Text = "Book";
			this.rbtnBook.UseVisualStyleBackColor = true;
			// 
			// rbtnFilm
			// 
			this.rbtnFilm.AutoSize = true;
			this.rbtnFilm.Location = new System.Drawing.Point(48, 76);
			this.rbtnFilm.Margin = new System.Windows.Forms.Padding(4);
			this.rbtnFilm.Name = "rbtnFilm";
			this.rbtnFilm.Size = new System.Drawing.Size(53, 20);
			this.rbtnFilm.TabIndex = 21;
			this.rbtnFilm.TabStop = true;
			this.rbtnFilm.Text = "Film";
			this.rbtnFilm.UseVisualStyleBackColor = true;
			// 
			// rbtnDog
			// 
			this.rbtnDog.AutoSize = true;
			this.rbtnDog.Checked = true;
			this.rbtnDog.Location = new System.Drawing.Point(48, 46);
			this.rbtnDog.Margin = new System.Windows.Forms.Padding(4);
			this.rbtnDog.Name = "rbtnDog";
			this.rbtnDog.Size = new System.Drawing.Size(54, 20);
			this.rbtnDog.TabIndex = 20;
			this.rbtnDog.TabStop = true;
			this.rbtnDog.Text = "Dog";
			this.rbtnDog.UseVisualStyleBackColor = true;
			this.rbtnDog.CheckedChanged += new System.EventHandler(this.rbtnAnimal_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(691, 211);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rbtnBook);
			this.Controls.Add(this.rbtnFilm);
			this.Controls.Add(this.rbtnDog);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbtnBook;
		private System.Windows.Forms.RadioButton rbtnFilm;
		private System.Windows.Forms.RadioButton rbtnDog;
	}
}

