using System;
using System.Collections.Generic;
using System.Text;

namespace UntitledER
{
    public class PlayGame
    {
        public bool Title()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.Clear();
                string title = @"
    |\     /|( (    /|\__   __/\__   __/\__   __/( \      (  ____ \(  __  \ 
    | )   ( ||  \  ( |   ) (      ) (      ) (   | (      | (    \/| (  \  )
    | |   | ||   \ | |   | |      | |      | |   | |      | (__    | |   ) |
    | |   | || (\ \) |   | |      | |      | |   | |      |  __)   | |   | |
    | |   | || | \   |   | |      | |      | |   | |      | (      | |   ) |
    | (___) || )  \  |   | |   ___) (___   | |   | (____/\| (____/\| (__/  )
    (_______)|/    )_)   )_(   \_______/   )_(   (_______/(_______/(______/ 
                                                                            
        _______  _______              _______  _______  _______  _______ 
       (  ____ \(  ____ )            (  ____ \(  ___  )(       )(  ____ \
       | (    \/| (    )|            | (    \/| (   ) || () () || (    \/
       | (__    | (____)|            | |      | (___) || || || || (__    
       |  __)   |     __)            | | ____ |  ___  || |(_)| ||  __)   
       | (      | (\ (               | | \_  )| (   ) || |   | || (      
       | (____/\| ) \ \__            | (___) || )   ( || )   ( || (____/\
       (_______/|/   \__/            (_______)|/     \||/     \|(_______/";
                Console.WriteLine(title);
                Console.WriteLine();
                Console.Write("Press Space to play...");

                keyInfo = Console.ReadKey();
            }
            while (keyInfo.Key != ConsoleKey.Spacebar);

            return false;
        }
    }
}
