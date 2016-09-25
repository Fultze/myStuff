using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Form should have a ref to dungeon obj
/// 
/// TXT p 428
/// 
/// Dungeon List<room> Roomlist
/// List<Monster> monstermanual
/// List<items> possible Items
/// Location for current room array possable
/// 
/// ROOM 
/// list monsters in room
/// List items in room
/// int num monsters
/// int num monsters && int num items
/// 
/// Load monsters manual  
/// inhabitants - new list <monster>
/// Room has mosters and items 
/// 
/// </summary>
namespace DungeonCrawl1_Fultze
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }
}
