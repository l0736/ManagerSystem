using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ManagerSystem.Module
{
    internal abstract class DataPath
    {
        protected static internal String getProjectPath()
        {
            return Directory.GetCurrentDirectory();
        }

        protected static internal String getDesktopPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        protected static internal String getImagePath()
        {
            return getProjectPath() + @"\Image";
        }

        protected static internal String getImagePath(String name)
        {
            return getImagePath() + @"\" + name;
        }

        protected static internal String getNewFolder(String newName)
        {
            return getProjectPath() + @"\Image\" + newName;
        }
    }
}