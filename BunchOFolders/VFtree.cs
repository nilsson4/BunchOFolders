using System;
using System.Collections.Generic;

namespace BunchOFolders
{
    class VFtree
    {
        public List<string> FolderBranchTips;
        public VFtree()
        {
            FolderBranchTips = new List<string>();
        }
        public VFtree(List<string> FolderPaths)
        {
            FolderBranchTips = new List<string>();
            foreach (string folderPath in FolderPaths)
            {
                Add(folderPath);
            }
        }
        public void Add(string folderPath)
        {
            for (int i = 0; i < FolderBranchTips.Count; i++)
            {
                if(folderPath.Length < FolderBranchTips[i].Length && FolderBranchTips[i].Contains(folderPath))
                {
                    Logging.Log($"[{folderPath}] is already in your Virtual Folder Tree", LogLevel.Message);
                    return;
                }
            }
            FolderBranchTips.Add(folderPath);
        }
    }
}
