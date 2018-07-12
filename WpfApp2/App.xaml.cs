using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //AppDomain.CurrentDomain.AssemblyResolve += aaa;
            AppDomain domain = AppDomain.CreateDomain("dd");

            //string pathToDll = @"C:\Users\yaronwe\.nuget\packages\netstandard.library\2.0.1\build\netstandard2.0\ref\netstandard.dll";
            //Assembly.LoadFrom(pathToDll);

            //Type t = typeof(FileSystemWatcher);
            //FileSystemWatcher myObject = (FileSystemWatcher)domain.CreateInstanceFromAndUnwrap(pathToDll, t.FullName);

        }

        private Assembly aaa(object sender, ResolveEventArgs args)
        {
            string s = args.Name;
            return null;
        }
    }
}
