using DesignPatterns.Memento;
using DesignPatterns.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.SetToolType(new SelectionTool());
            canvas.MouseDown();
            canvas.MouseUp();
            canvas.SetToolType(new BrushTool());
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
