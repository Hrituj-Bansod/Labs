using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class UIComponent { }

    class Button : UIComponent { }

    class TextField : UIComponent { }

    class CheckBox : UIComponent { }

    abstract class UIComponentCreator
    {
        public void Show(string type)
        {
            UIComponent comp = CreateUIComponent(type);
            Add(comp);
        }

        public void Add(UIComponent component)
        {
            Console.WriteLine("Added the component\t" + component);
        }

        public abstract UIComponent CreateUIComponent(string type);
    }

    class WindowsUIComponentCreator : UIComponentCreator
    {
        public override UIComponent CreateUIComponent(string type)
        {
            if (type.Equals("Button", StringComparison.OrdinalIgnoreCase))
            {
                return new Button();
            }
            else if (type.Equals("TextField", StringComparison.OrdinalIgnoreCase))
            {
                return new TextField();
            }
            else if (type.Equals("CheckBox", StringComparison.OrdinalIgnoreCase))
            {
                return new CheckBox();
            }
            throw new ArgumentException("Invalid component type: " + type);
        }
    }

    class LinuxUIComponentCreator : UIComponentCreator
    {
        public override UIComponent CreateUIComponent(string type)
        {
            if (type.Equals("Button", StringComparison.OrdinalIgnoreCase))
            {
                return new Button();
            }
            else if (type.Equals("TextField", StringComparison.OrdinalIgnoreCase))
            {
                return new TextField();
            }
            else if (type.Equals("CheckBox", StringComparison.OrdinalIgnoreCase))
            {
                return new CheckBox();
            }
            throw new ArgumentException("Invalid component type: " + type);
        }
    }

    class MacUIComponentCreator : UIComponentCreator
    {
        public override UIComponent CreateUIComponent(string type)
        {
            if (type.Equals("Button", StringComparison.OrdinalIgnoreCase))
            {
                return new Button();
            }
            else if (type.Equals("TextField", StringComparison.OrdinalIgnoreCase))
            {
                return new TextField();
            }
            else if (type.Equals("CheckBox", StringComparison.OrdinalIgnoreCase))
            {
                return new CheckBox();
            }
            throw new ArgumentException("Invalid component type: " + type);
        }
    }
}
