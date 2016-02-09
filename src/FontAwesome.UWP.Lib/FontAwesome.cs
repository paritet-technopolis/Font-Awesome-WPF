using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace FontAwesome.UWP.Lib
{
    public class FontAwesome : FontIcon
    {
        public FontAwesome()
        {
            this.FontFamily = new FontFamily("ms-appx:///FontAwesome.UWP.Lib/fontawesome.otf#FontAwesome");
        }

        private FontAwesomeIcon _icon;
        public FontAwesomeIcon Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                Glyph = char.ConvertFromUtf32((int)_icon);
            }
        }
    }
}
