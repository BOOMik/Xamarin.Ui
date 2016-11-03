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
        public string Text { get; set; }
		public double TextSize { get; set; } = 14;
		public Color TextColor { get; set; } = Color.Black;
    }
}
