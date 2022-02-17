using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunchOFolders
{
    class Input
    {
        public static void TakeInput()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.Backspace)
            {
                FolderNavigation.Move(MoveDirection.Up);
                Console.SetCursorPosition(0, 0);
            }
            if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
            {
                FolderNavigation.Move(MoveDirection.Down);
                Console.SetCursorPosition(0, 0);
            }
            if (key.Key == ConsoleKey.UpArrow)
            {
                FolderNavigation.Move(MoveDirection.Left);
                Console.SetCursorPosition(0, 0);
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                FolderNavigation.Move(MoveDirection.Right);
                Console.SetCursorPosition(0, 0);
            }
            TakeInput();
        }
    }
}
