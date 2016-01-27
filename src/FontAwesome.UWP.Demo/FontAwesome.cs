using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace FontAwesome.UWP.Demo
{
    public class FontAwesome : FontIcon
    {
        public FontAwesome()
        {
            this.FontFamily = new FontFamily("./fontawesome.otf#FontAwesome");
            this.Glyph = "\uf17a";
            
            // this.FontFamily = new FontFamily("pack://application:,,,/FontAwesome.otf");
        }

        private FontAwesomeIcon _icon;
        public FontAwesomeIcon Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                // Glyph = "\f17a";
            }
        }
    }
}
