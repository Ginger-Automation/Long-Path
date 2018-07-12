using ClassLibrary1;
using System.IO;
using System.Windows;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, RoutedEventArgs e)
        {
            // testPath();
            //FileSystemWatcher
            Class1.testPath();
            // testPath();
        }

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
                Directory.CreateDirectory(longPath);

                //longPath = longPath.Replace(@"\\?\", "");

                FileSystemWatcher fs = new FileSystemWatcher(longPath);
                fs.EnableRaisingEvents = true;
                i++;
            }
            MessageBox.Show("pass");
        }
    }
}
