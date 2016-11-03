using System.Collections.Generic;

namespace Xamarin.Ui.Ui
{
    public class UiViewContainer : UiView
    {
        private List<UiView> _childrens;

        public List<UiView> Childrens
        {
            get { return _childrens; }
            set
            {
                _childrens = value;
                UpdateProperty(value);
                SetBindingContextToChilds();
            }
        }

        private void SetBindingContextToChilds()
        {
            if (_childrens == null) return;
            foreach (var view in _childrens)
            {
                view.BindingContext = BindingContext;
            }
        }

        public override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            SetBindingContextToChilds();
        }
    }

}
