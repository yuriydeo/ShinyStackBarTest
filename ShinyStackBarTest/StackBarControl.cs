using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShinyStackBarTest
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ShinyStackBarTest"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ShinyStackBarTest;assembly=ShinyStackBarTest"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:StackBarControl/>
    ///
    /// </summary>
    public class StackBarControl : Control
    {
        static StackBarControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StackBarControl), new FrameworkPropertyMetadata(typeof(StackBarControl)));
        }

        public static DependencyProperty LegendProperty =
            DependencyProperty.Register("Legend", typeof(Dictionary<string, Color>), typeof(StackBarControl));
        public Dictionary<string, Color> Legend
        {
            get { return (Dictionary<string, Color>) GetValue(LegendProperty); }
            set { SetValue(LegendProperty, value); }
        }

        public static DependencyProperty StackItemsSourceProperty = DependencyProperty.Register("StackItemsSource",
            typeof(IEnumerable), typeof(StackBarControl),
            new PropertyMetadata(null, ItemsSourcePropertyChangedCallback));
        public IEnumerable StackItemsSource
        {
            get { return (IEnumerable) GetValue(StackItemsSourceProperty); }
            set { SetValue(StackItemsSourceProperty, value); }
        }

        private static void ItemsSourcePropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        public static DependencyProperty BarLabelFieldNameProperty = DependencyProperty.Register("BarLabelFieldName",
            typeof(string), typeof(StackBarControl));
        public string BarLabelFieldName
        {
            get { return (string)GetValue(BarLabelFieldNameProperty); }
            set { SetValue(BarLabelFieldNameProperty, value); }
        }

        public static DependencyProperty ValueFieldNameProperty = DependencyProperty.Register("ValueFieldName",
            typeof(string), typeof(StackBarControl));
        public string ValueFieldName
        {
            get { return (string)GetValue(ValueFieldNameProperty); }
            set { SetValue(ValueFieldNameProperty, value); }
        }

        public static DependencyProperty TextFieldNameProperty = DependencyProperty.Register("TextFieldName",
            typeof(string), typeof(StackBarControl));
        public string TextFieldName
        {
            get { return (string)GetValue(TextFieldNameProperty); }
            set { SetValue(TextFieldNameProperty, value); }
        }

        public static DependencyProperty ChildrenFieldNameProperty = DependencyProperty.Register("ChildrenFieldName",
            typeof(string), typeof(StackBarControl));
        public string ChildrenFieldName
        {
            get { return (string)GetValue(ChildrenFieldNameProperty); }
            set { SetValue(ChildrenFieldNameProperty, value); }
        }
    }
}
