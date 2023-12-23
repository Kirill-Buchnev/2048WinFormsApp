namespace _2048ClassLibrary
{
    public class FileProvider
    {
        public string Path { get; }

        public FileProvider(string path)
        {
            Path = path;
        }

        public void Write(string item)
        {
            File.WriteAllText(Path, item);
        }

        public string Get()
        {
            if (Exists())
            {
                using (var sr = new StreamReader(Path))
                {
                    return sr.ReadToEnd();
                }
            }
            return string.Empty;
        }

        public bool Exists()
        {
            return new FileInfo(Path).Exists;
        }
    }
}
