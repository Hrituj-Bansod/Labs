using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    interface IMouseListener
    {
        void MouseClicked(MouseEvent e);
        void MouseEntered(MouseEvent e);
        void MouseExited(MouseEvent e);
        void MousePressed(MouseEvent e);
        void MouseReleased(MouseEvent e);
    }

    // Interface for mouse motion listener
    interface IMouseMotionListener
    {
        void MouseDragged(MouseEvent e);
        void MouseMoved(MouseEvent e);
    }

    // Class representing mouse event in C#
    class MouseEvent
    {
        // Properties to represent mouse event details
        public int X { get; set; }
        public int Y { get; set; }
        // Other properties as needed...
    }

    // Class implementing mouse listener interface
    class MyMouseListener : IMouseListener
    {
        public void MouseClicked(MouseEvent e)
        {
            Console.WriteLine("Mouse Clicked at: " + e.X + ", " + e.Y);
        }

        public void MouseEntered(MouseEvent e)
        {
            Console.WriteLine("Mouse Entered at: " + e.X + ", " + e.Y);
        }

        public void MouseExited(MouseEvent e)
        {
            Console.WriteLine("Mouse Exited at: " + e.X + ", " + e.Y);
        }

        public void MousePressed(MouseEvent e)
        {
            Console.WriteLine("Mouse Pressed at: " + e.X + ", " + e.Y);
        }

        public void MouseReleased(MouseEvent e)
        {
            Console.WriteLine("Mouse Released at: " + e.X + ", " + e.Y);
        }
    }

    // Class implementing mouse motion listener interface
    class MyMouseMotionListener : IMouseMotionListener
    {
        public void MouseDragged(MouseEvent e)
        {
            Console.WriteLine("Mouse Dragged at: " + e.X + ", " + e.Y);
        }

        public void MouseMoved(MouseEvent e)
        {
            Console.WriteLine("Mouse Moved at: " + e.X + ", " + e.Y);
        }
    }
}
