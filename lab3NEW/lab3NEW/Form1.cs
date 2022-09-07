
using System.Windows.Forms;
using System;
using Books;
using Dogs;
using Films;
using Serialization;
using System.Collections.Generic;

namespace lab3NEW
{
	public partial class Form1 : Form
	{
		public List<object> objects = new List<object>();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			AddObject(new Dog("Marik", "5", "Brown", "Chih"));
			AddObject(new Book("The Hunger Games", "2008", "Suzan Collins", "400"));
			AddObject(new Film("Pirates of the Caribbean", "2003", "Espen Sandberg", "USA"));
			AddObject(new Dog("Kira", "2", "Black", "Labrador"));
			AddObject(new Book("The Way of Kings", "2010", "Brandon Sanderson", "900"));
		}

		public void AddObject(Dog dog)
		{
			listBox1.Items.Add(dog.GetData());
			objects.Add(dog);
		}

		public void AddObject(Book book)
		{
			listBox1.Items.Add(book.GetData());
			objects.Add(book);
		}

		public void AddObject(Film film)
		{
			listBox1.Items.Add(film.GetData());
			objects.Add(film);

		}

		private void button4_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog()
			{
				Filter = "Files|*.dat",
				DefaultExt = "dat"
			};

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					var serializer = new serialization(dialog.FileName, objects[listBox1.SelectedIndex]);
					serializer.Serialize();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog()
			{
				Filter = "Files|*.dat"
			};

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					object obj = new serialization(dialog.FileName).Deserialize();

					if (rbtnDog.Checked)
					{
						AddObject(obj as Dog);
					}
					else if (rbtnFilm.Checked)
					{
						AddObject(obj as Film);
					}
					else
					{
						AddObject(obj as Book);
					}
				}
				catch
				{
					MessageBox.Show("Не удалось десериализировать объект!");
				}
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			
		}

		private void rbtnAnimal_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
