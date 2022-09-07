
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serialization
{
    public class serialization
    {
        public string file { get; set; }
        public object obj { get; set; }
        public serialization(string file, object obj)
        {
            this.file = file;
            this.obj = obj;
        }
        public serialization(string file)
        {   
            this.file = file;
        }
        public void Serialize()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream(file, FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, obj);
            }
        }

        public object Deserialize()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream(file, FileMode.OpenOrCreate))
            {
                obj = binaryFormatter.Deserialize(fileStream);
            }

            return obj;
        }
    }
}
