using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class EditorState
    {
        private readonly string content; //We want this to be readonly, so that it cannot be accidentally changed.

        public EditorState(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return this.content;
        }
    }
}
