using System;
using System.Collections.Generic;

namespace BunchOFolders
{
    class Program
    {
        static void Main()
        {
            FolderNavigation.WriteFolders();
            Input.TakeInput();
            Console.ReadKey();
        }
    }
}
