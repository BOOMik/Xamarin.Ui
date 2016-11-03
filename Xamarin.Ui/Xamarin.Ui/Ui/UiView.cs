using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Xamarin.Ui.Ui
{
    public class UiViewForms : View
    {
        public UiViewForms()
        {
            HorizontalOptions = LayoutOptions.FillAndExpand;
            VerticalOptions = LayoutOptions.FillAndExpand;
        }

        public UiView View { get; set; }
    }

    public class UiView
    {

        #region Variables
        private string _automationId;
        private Color _backgroundColor = Color.Default;
        private Thickness _padding;
        private Thickness _margin;
        private double _width;
        private double _height;
        private double _x;
        private double _y;
        private bool _isVisible = true;
        private bool _init;
        private object _bindingContext;

        #endregion

        public INativeUiView NativeView { get; set; }

        public string AutomationId
        {
            get { return _automationId; }
            set
            {
                if (_automationId != null) throw new InvalidOperationException("AutomationId may only be set one time");
                _automationId = value;
                UpdateProperty(value);
            }
        }



        public object BindingContext
        {
            get { return _bindingContext; }
            set
            {
                SubscribeNotifyPropertyChanged(false);
                _bindingContext = value;
                UpdateProperty(value);
                SubscribeNotifyPropertyChanged();
            }
        }

        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                UpdateProperty(value);
            }
        }

        public Thickness Padding
        {
            get { return _padding; }
            set
            {
                _padding = value;
                UpdateProperty(value);
            }
        }

        public Thickness Margin
        {
            get { return _margin; }
            set
            {
                _margin = value;
                UpdateProperty(value);
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                _width = value;
                UpdateProperty(value);
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                _height = value;
                UpdateProperty(value);
            }
        }

        public double X
        {
            get { return _x; }
            set
            {
                _x = value;
                UpdateProperty(value);
            }
        }

        public double Y
        {
            get { return _y; }
            set
            {
                _y = value;
                UpdateProperty(value);
            }
        }

        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                UpdateProperty(value);
            }
        }

        public void SetInit()
        {
            _init = true;
        }

        public Dictionary<string, string> Bindings = new Dictionary<string, string>();
        
        public UiView AddBinding(string bindingName, string propertyName)
        {
            if (string.IsNullOrEmpty(bindingName)) return this;
            if (string.IsNullOrEmpty(propertyName))
            {
                if (Bindings.ContainsKey(propertyName)) Bindings.Remove(propertyName);
            } else Bindings.Add(bindingName, propertyName);
            return this;
        }

        private void SubscribeNotifyPropertyChanged(bool subscribe = true)
        {
            var notify = _bindingContext as INotifyPropertyChanged;
            if (notify == null) return;
            if (subscribe) notify.PropertyChanged += NotifyOnPropertyChanged;
            else notify.PropertyChanged -= NotifyOnPropertyChanged;
        }

        private void NotifyOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (_bindingContext == null) return;
            var changedProperty = propertyChangedEventArgs.PropertyName;
            var property = Bindings.ContainsKey(changedProperty) ? Bindings[changedProperty] : null;
            if (property == null) return;
            var value = _bindingContext.GetType().GetRuntimeProperty(propertyChangedEventArgs.PropertyName)?.GetValue(_bindingContext, null);
            UpdateProperty(value, otherMember: property);

        }

        private void UpdateProperty<T>(T value = default(T), [CallerMemberName] string member = null, string otherMember = null)
        {
            if (!_init) return;
            if (member == null) member = otherMember;
            if (member == null) return;
            NativeView?.UpdateProperty(member, value);
            NativeView?.ViewHelper?.UpdateProperty(member, value);
        }

        public virtual Size GetSize(double width, double height)
        {
            return NativeView?.GetSize(width, height) ?? Size.Zero;
        }

        public virtual Size OnMeasure(double width, double height)
        {
            return NativeView?.OnMeasure(width, height) ?? Size.Zero;
        }

    }

    public interface INativeUiView
    {
        Size GetSize(double width, double height);
        Size OnMeasure(double width, double height);
        IViewHelper ViewHelper { get; set; }
        void Init();
        void UpdateProperty(string property, object value);
    }

    public interface IViewHelper
    {
        T GetSharedView<T>() where T : UiView;
        void UpdateProperty(string property, object value);
    }
}