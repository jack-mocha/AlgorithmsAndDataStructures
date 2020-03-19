using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class History
    {
        private Stack<EditorState> states;

        public History()
        {
            states = new Stack<EditorState>();
        }

        public void Push(EditorState state)
        {
            states.Push(state);
        }

        public EditorState Pop()
        {
            if (states.Count > 0)
                return states.Pop();

            return null;
        }
    }
}
