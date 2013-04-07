using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ManagerSystem.Module
{
    internal abstract class DataPath
    {
        protected static internal String GetProjectPath()
        {
            return Directory.GetCurrentDirectory();
        }

        protected static internal String GetDesktopPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        protected static internal String GetImagePath()
        {
            return GetProjectPath() + @"\Image";
        }

        protected static internal String GetImagePath(String name)
        {
            return GetImagePath() + @"\" + name;
        }

        protected static internal String GetNewFolder(String newName)
        {
            return GetProjectPath() + @"\Image\" + newName;
        }

        protected internal static String GetConfigPath(String projectName, String configName)
        {
            return GetNewFolder(projectName) + @"\" + configName;
        }

        protected internal static String GetConfigPath(String projectName)
        {
            return projectName + @"\pic.config";
        }
    }
}