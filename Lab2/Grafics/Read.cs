using System.IO;
using System.Windows.Forms;

namespace GraphicsRead
{
    public static class Read
    {
        static string path;

        public static string[] readFile()
        {
            
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.FileName;
            }
            else MessageBox.Show("Файл не найден!");
            
            string[] data = File.ReadAllLines(path);
            
            return (data);
        }
    }
}
