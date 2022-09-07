
using System.Windows.Forms;
using System.IO;

namespace GraphicsOut
{
    public static class Out
    {
        static string path;
        //комент для комита
        
        public static void WhriteInFile(string text)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.FileName;
            }
            else MessageBox.Show("Файл не найден!");

            File.WriteAllText(path, text);
        }
    }
}
