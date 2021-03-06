﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    ///     <MyNamespace:StackBarItemControl/>
    ///
    /// </summary>
    public class StackBarItemControl : Control
    {
        static StackBarItemControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StackBarItemControl), new FrameworkPropertyMetadata(typeof(StackBarItemControl)));
        }

        public static DependencyProperty ItemValueProperty = DependencyProperty.Register("ItemValue",
            typeof(string), typeof(StackBarControl));
        public string ItemValue
        {
            get { return (string)GetValue(ItemValueProperty); }
            set { SetValue(ItemValueProperty, value); }
        }

        public static DependencyProperty ItemLabelProperty = DependencyProperty.Register("ItemLabel",
            typeof(string), typeof(StackBarControl));
        public string ItemLabel
        {
            get { return (string)GetValue(ItemLabelProperty); }
            set { SetValue(ItemLabelProperty, value); }
        }

        public static DependencyProperty BarLabelProperty = DependencyProperty.Register("BarLabel",
            typeof(string), typeof(StackBarControl), new FrameworkPropertyMetadata("test"));
        public string BarLabel
        {
            get { return (string)GetValue(BarLabelProperty); }
            set { SetValue(BarLabelProperty, value); }
        }

        public static DependencyProperty BarItemsSourceProperty = DependencyProperty.Register("BarItemsSource",
            typeof(IEnumerable), typeof(StackBarControl));
        public IEnumerable BarItemsSource
        {
            get { return (IEnumerable)GetValue(BarItemsSourceProperty); }
            set { SetValue(BarItemsSourceProperty, value); }
        }

        //public static DependencyProperty ItemsSourcePathProperty = DependencyProperty.Register("ItemsSourcePath",
        //    typeof(string), typeof(StackBarControl));
        //public string ItemsSourcePath
        //{
        //    get { return (string)GetValue(ItemsSourcePathProperty); }
        //    set
        //    {
        //        SetValue(ItemsSourcePathProperty, value);
        //        SetItemsSourceBinding();
        //    }
        //}
        //public void SetItemsSourceBinding()
        //{
        //    Binding binding = new Binding();
        //    binding.Path = new PropertyPath(ItemsSourcePath, null);

        //    BindingOperations.SetBinding(this, BarItemsSourceProperty, binding);
        //}
    }
}
