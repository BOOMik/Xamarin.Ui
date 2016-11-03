using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.Ui.Ui
{
    public class UiStackLayout : UiViewContainer
    {
        public UiStackOrientation Orientation { get; set; } = UiStackOrientation.Vertical;
        public double Spacing { get; set; }
    }

    /// <summary>The orientations the a StackLayout can have.</summary>
    /// <remarks />
    public enum UiStackOrientation
    {
        Vertical,
        Horizontal,
    }
}
