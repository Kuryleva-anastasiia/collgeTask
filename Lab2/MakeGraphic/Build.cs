

namespace BuildGraphic
{
    public static class Build
    {
        public static string[] buildGraphic(string[] data, int i)
        {
            data = data[i].Split('\t');
            return data;
        }
    }
}
