using System;
using System.Collections.Generic;
using System.IO;

namespace BunchOFolders
{
    class FolderNavigation
    {
        public static string CurrentPath = @"C:\";
        public static string[] Children;
        public static int SelectedIndex = 0;

        public static void Move(MoveDirection direction)
        {
            
            if (direction == MoveDirection.Up && CurrentPath != @"C:\")
            {
                CurrentPath = CurrentPath.Substring(0, CurrentPath.LastIndexOf("\\"));
                SelectedIndex = 0;
                WriteFolders();
                return;
            }
            GetChildren();
            if (direction == MoveDirection.Down)
            {
                try
                {
                    CurrentPath += Children[SelectedIndex].Substring(Children[SelectedIndex].LastIndexOf("\\"));
                    SelectedIndex = 0;
                    WriteFolders();
                }
                catch (Exception ex)
                {
                    Logging.Log(ex.Message, LogLevel.Error);
                }
                return;

            }  
            else if (direction == MoveDirection.Left)
            {
                if (SelectedIndex == 0)
                {
                    SelectedIndex = Children.Length -1;
                }
                else
                {
                    SelectedIndex--;
                }
                WriteFolders();
                return;
            }  
            else if (direction == MoveDirection.Right)
            {
                if (SelectedIndex == Children.Length-1)
                {
                    SelectedIndex = 0;
                }
                else
                {
                    SelectedIndex++;
                }
                WriteFolders();
                return;
            }
                
        }
        static void GetChildren()
        {

            Children = Directory.GetDirectories(CurrentPath);
        }
        public static void WriteFolders()
        {
            Console.Clear();
            GetChildren();

            Console.WriteLine($"(PATH) {CurrentPath}\n");

            for (int i = 0; i < Children.Length; i++)
            {
                if(i == SelectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.WriteLine(Children[i].Substring(Children[i].LastIndexOf("\\")));
                if (i == SelectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                
            }
        }
    }
    enum MoveDirection
    {
        Up,
        Down,
        Left,
        Right
    }
}
