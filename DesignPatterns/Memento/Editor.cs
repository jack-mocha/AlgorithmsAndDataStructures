using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    //The problem with this imiplementation is that it violates Single Responsibility Principle
    //The editor has 2 responsibilities in this implementation.
    //[1] It manages the state.
    //[2] It provides the feature of the editor.
    public class Editor
    {
        private string content;
        private Stack<string> stk;

        public Editor()
        {
            this.stk = new Stack<string>();
        }

        public string GetContent()
        {
            return content;
        }
         
        public void SetContent(string content)
        {
            stk.Push(this.content);
            this.content = content;
        }

        public void Undo()
        {
            if(stk.Count > 0)
                this.content = stk.Pop();
        }
    }
}
