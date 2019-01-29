using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Snake.Models
{
    /// <OsztályLeírás>
    /// ez az osztály a játéktér beállításait kezeli
    /// </summary>
    public class Arena
    {
        private TimeSpan PlayTime;
        private DispatcherTimer GameTimer;
        private MainWindow mainWindow;

        public Arena(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void Start()
        {
            PlayTime = TimeSpan.FromMilliseconds(0); //Lenullázuk az órát
            ///Az első: Tikkek közötti idő megadása
            ///

            GameTimer = new DispatcherTimer(TimeSpan.FromMilliseconds(100), DispatcherPriority.Normal, ItIsTimeForShow(), Application.Current.Dispatcher);
        }

        private EventHandler ItIsTimeForShow()
        {
            
        }

        public void Stop()
        {
            
        }
    }
}
