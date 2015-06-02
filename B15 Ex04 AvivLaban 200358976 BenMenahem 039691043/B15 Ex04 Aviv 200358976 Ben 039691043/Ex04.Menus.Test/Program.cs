using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {

            InterfaceMainMenu mainMenuInterfaceExample = createMainMenuInterfaceExample();
            Interfaces.MainMenu mainMenuInterface = new Interfaces.MainMenu();


            mainMenuInterface.Show(mainMenuInterfaceExample);
            
        }

        private static InterfaceMainMenu createMainMenuInterfaceExample()
        {
            InterfaceMainMenu mainMenuInterfaceExample= new InterfaceMainMenu();
            InterfaceDateTime dateTimeInterfaceExample = new InterfaceDateTime();
            InterfaceDate dateInterfaceExample = new InterfaceDate();
            InterfaceTime timeInterfaceExample = new InterfaceTime();
            InterfaceInfo infoInterfaceExample = new InterfaceInfo();
            InterfaceVersion versionInterfaceExample = new InterfaceVersion();
            InterfaceCountWords countWordsInterfaceExample = new InterfaceCountWords();
            
            dateTimeInterfaceExample.AddMenuItem(timeInterfaceExample);
            dateTimeInterfaceExample.AddMenuItem(dateInterfaceExample);
            infoInterfaceExample.AddMenuItem(versionInterfaceExample);
            infoInterfaceExample.AddMenuItem(countWordsInterfaceExample);
            mainMenuInterfaceExample.AddMenuItem(dateTimeInterfaceExample);
            mainMenuInterfaceExample.AddMenuItem(infoInterfaceExample);

            return mainMenuInterfaceExample;
        }
    }
}
