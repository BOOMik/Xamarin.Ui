using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.Ui.Ui
{
    public class UiLabel : UiView
    {
        private string _text;
        private double _textSize = 14;
        private Color _textColor = Color.Black;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                UpdateProperty(value);
            }
        }

        public double TextSize
        {
            get { return _textSize; }
            set
            {
                _textSize = value;
                UpdateProperty(value);
            }
        }

        public Color TextColor
        {
            get { return _textColor; }
            set
            {
                _textColor = value;
                UpdateProperty(value);
            }
        }


        public string TextBinding
        {
            set { AddBinding(value, nameof(Text)); }
        }
        
    }
}
