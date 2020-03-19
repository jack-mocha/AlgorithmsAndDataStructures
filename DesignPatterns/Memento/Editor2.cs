using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Editor2
    {
        private string content;

        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void Restore(EditorState state)
        {
            if(state != null)
                this.content = state.GetContent();
        }

        public string GetContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }
    }
}
