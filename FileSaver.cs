using System;
using System.IO;

namespace wordcounter_proppter
{
    
    internal abstract class FileSaver
    {
        public abstract void Save(string text);
    }

    
    internal class SaveToProject : FileSaver
    {
        public override void Save(string text)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "result.txt");
            File.WriteAllText(path, text);
        }
    }

    
    internal class SaveToUserFolder : FileSaver
    {
        public override void Save(string text)
        {
            string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string path = Path.Combine(userPath, "result.txt");

            File.WriteAllText(path, text);
        }
    }
}