using System;
// using System.IO;
using System.Reflection;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void testPath()
        {            
            string path = @"\\?\c:\temp\";
            // string path = @"c:\temp\";
            
            int i = 1;
            while (path.Length < 300)
            {
                path = System.IO.Path.Combine(path, "LongSubFolderName_" + i);
                // Directory.CreateDirectory(path);

                string longPath = System.IO.Path.GetFullPath(path);
                System.IO.Directory.CreateDirectory(longPath);

                //longPath = longPath.Replace(@"\\?\", "");

                System.IO.FileSystemWatcher fs = new System.IO.FileSystemWatcher();
                Assembly[] asms = AppDomain.CurrentDomain.GetAssemblies();
                fs.Path = longPath;
                
                fs.EnableRaisingEvents = true;
                fs.IncludeSubdirectories = true;
                fs.Changed += aaa;
                i++;
            }
            
        }

        private static void aaa(object sender, System.IO.FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
