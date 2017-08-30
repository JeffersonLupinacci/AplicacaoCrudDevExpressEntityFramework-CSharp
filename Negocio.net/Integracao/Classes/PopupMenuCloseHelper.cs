using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Negocio.Net.Integracao
{
    public class PopupMenuCloseHelper
    {
        private Timer _CloseTimer;
        private readonly PopupMenu _Menu;

        public PopupMenuCloseHelper(PopupMenu menu)
        {
            _Menu = menu;
            menu.Manager.HighlightedLinkChanged += OnLinkChanged;
        }

        void OnLinkChanged(object sender, HighlightedLinkChangedEventArgs e)
        {
            CheckCloseMenu(e.PrevLink, e.Link);
        }

        private void CheckCloseMenu(BarItemLink prevLink, BarItemLink link)
        {
            if (link == null)
            {
                StartCloseTimer();
                return;
            }            
        }
        
        bool IsCursorOnMenu(PopupMenu menu)
        {
            if (null != ((PopupControl)menu).IPopup)
                return ((PopupControl)menu).IPopup.CustomControl.FindForm().Bounds.Contains(Cursor.Position);
            else
                return false;
        }

        public Timer CloseTimer
        {
            get
            {
                if (_CloseTimer == null)
                    InitCloseTimer();
                return _CloseTimer;
            }
        }

        private void InitCloseTimer()
        {
            _CloseTimer = new Timer() { Interval = 500 };
            _CloseTimer.Tick += _CloseTimer_Tick;
        }

        void _CloseTimer_Tick(object sender, EventArgs e)
        {
            _CloseTimer.Stop();
            if (!IsCursorOnMenu(_Menu) && _Menu.Manager.HighlightedLink == null)
                _Menu.HidePopup();
        }

        private void StartCloseTimer()
        {
            CloseTimer.Start();
        }
    }
}
