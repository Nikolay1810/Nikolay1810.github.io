using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Linq = System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;

namespace Client.AddBinding
{
    public class DependencyPropertyBehavior:Behavior<DependencyObject>
    {
        private Delegate _handler;
        private EventInfo _eventInfo;
        private PropertyInfo _propertyInfo; 
        public string Property { get; set; }
        public string UpdateEvent { get; set; }

        public static readonly DependencyProperty BindingProperty = DependencyProperty.RegisterAttached(
            "Binding",
            typeof(object),
            typeof(DependencyPropertyBehavior),
            new FrameworkPropertyMetadata { BindsTwoWayByDefault = true });

        public object Binding
        {
            get
            {
                return GetValue(BindingProperty);
            }
            set
            {
                SetValue(BindingProperty, value);
            }
        }

        protected override void OnAttached()
        {
            Type elementType = AssociatedObject.GetType();

            if(Property == null)
            {
                PresentationTraceSources.DependencyPropertySource.TraceData(
                    TraceEventType.Error,
                    1,
                    "Target property not defined.");
                return;
            }

            _propertyInfo = elementType.GetProperty(Property, BindingFlags.Instance | BindingFlags.Public);
            if(_propertyInfo == null)
            {
                PresentationTraceSources.DependencyPropertySource.TraceData(
                    TraceEventType.Error,
                    2,
                    string.Format("Property \"{0}\" not found.", Property));
                return;
            }

            if (UpdateEvent == null) return;

            _eventInfo = elementType.GetEvent(UpdateEvent);

            if(_eventInfo == null)
            {
                PresentationTraceSources.MarkupSource.TraceData(
                    TraceEventType.Error,
                    3,
                    string.Format("Event \"{0}\" not found."), UpdateEvent);
                return;
            }

            _handler = CreateDelegateForEvent(_eventInfo, EventFired);
            _eventInfo.AddEventHandler(AssociatedObject, _handler);
        }

        protected override void OnDetaching()
        {
            if (_eventInfo == null) return;
            if (_handler == null) return;

            _eventInfo.RemoveEventHandler(AssociatedObject, _handler);
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            if (e.Property.Name != "Binding") return;
            if (AssociatedObject == null) return;
            if (_propertyInfo == null) return;

            object oldValue = _propertyInfo.GetValue(AssociatedObject, null);
            if (oldValue.Equals(e.NewValue)) return;

            if (_propertyInfo.CanWrite)
            {
                _propertyInfo.SetValue(AssociatedObject, e.NewValue, null);
            }

            base.OnPropertyChanged(e);
        }

        private static Delegate CreateDelegateForEvent(EventInfo eventInfo, Action action)
        {
            Linq.ParameterExpression[] parameters =
                eventInfo.
                EventHandlerType
                .GetMethod("Invoke")
                .GetParameters()
                .Select(parameter => Linq.Expression.Parameter(parameter.ParameterType))
                .ToArray();

            return Linq.Expression.Lambda(
                eventInfo.EventHandlerType,
                Linq.Expression.Call(Linq.Expression.Constant(action), "Invoke", Type.EmptyTypes),
                parameters).Compile();
        }

        private void EventFired()
        {
            if (AssociatedObject == null) return;
            if (_propertyInfo == null) return;

            Binding = _propertyInfo.GetValue(AssociatedObject, null);
        }
    }
}
