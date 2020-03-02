using System;
using System.Collections.Generic;

namespace Pizza
{
    public class Menu
    {
        private List<string> menu;
        public Menu(int step = 1){
            if(step == 1) { //hvis default menu
                menu = new List<string>{
                    "Vil du gå til højre?",
                    "Vil du gå til venstre?"
                };
            }
            else if(step == 2) { //hvis default menu
                menu = new List<string>{
                    "Vil du gå til højre?",
                    "Vil du gå til venstre?"
                };
            }
        }
        public void ShowMenu ()
        {
            for (int i= 0; i < menu.Count ; i++) {
                Console.WriteLine(menu[i]);
            }

        }
    }
}