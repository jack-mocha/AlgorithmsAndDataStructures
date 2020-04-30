using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class BrowseHistory
    {
        private List<String> urls = new List<String>();

        public void Push(String url)
        {
            urls.Add(url);
        }

        public String Pop()
        {
            var lastIndex = urls.Count - 1;
            var lastUrl = urls[lastIndex];
            urls.RemoveAt(lastIndex);

            return lastUrl;
        }

        public Iterator<String> CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : Iterator<String>
        {
            private BrowseHistory history;
            private int index;

            public ListIterator(BrowseHistory history)
            {
                this.history = history;
            }

            public String Current()
            {
                return history.urls[index];
            }

            public bool HasNext()
            {
                return (index < history.urls.Count);
            }

            public void Next()
            {
                index++;
            }
        }
    }
}
