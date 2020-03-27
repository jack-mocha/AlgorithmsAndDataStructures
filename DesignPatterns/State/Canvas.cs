using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    //The state pattern allows the object to behave differently when the state changes.
    //Essentially, this is achieved by polymorphism.
    //Open Close Principle:
    //      Class should be open for extension, but close for modification.
    public class Canvas
    {
        private Tool currentTool;

        public void MouseDown()
        {
            currentTool.MouseDown();
        }

        public void MouseUp()
        {
            currentTool.MouseUp();
        }

        public void SetToolType(Tool currentTool)
        {
            this.currentTool = currentTool;
        }

        public Tool GetToolType()
        {
            return this.currentTool;
        }
    }
}
