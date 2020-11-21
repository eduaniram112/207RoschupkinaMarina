using System;
using System.Collections.Generic;
using System.Text;

partial class Folder
{
    internal class Backup
    {
        List<File> backupfiles = new List<File>();
        public Backup(Folder folder)
        {
            foreach (File f in folder.files)
            {
                backupfiles.Add(f);
            }
        }
          

        public static void Restore(Folder folder, Backup backup)
        {
            folder.files = new List<File>();
            foreach (File f in backup.backupfiles)
            {
                folder.files.Add(f);
            }
        }

    }

    public void AddFile(string name, int size)
    {
        files.Add(new File(name, size));
    }
    public void RemoveFile(File file)
    {
        files.Remove(file);
    }

    public File this[int i]
    {
        get {
            if (i < files.Count && i>=0) return files[i];
            else throw new IndexOutOfRangeException("Not enough files or index less zero");
        }
    }

    public File this[string filename]
    {
        get {
            int index = -1;
            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].Name == filename) { index = i; }
            }
            if (index != -1) return files[index];
            else throw new ArgumentException("File not found");
         }
    }

    public override string ToString()
    {
        string str = "Files in folder:";
        foreach (File f in files)
        {
            str += "\n" + f;
        }
        return str;
    }
}

