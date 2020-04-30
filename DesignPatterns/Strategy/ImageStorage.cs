using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    //The difference between Strategy pattern and State pattern is that
    //In the state pattern, the Canvas object has a single state, which is the current tool.
    //The behaviors, e.g. mouseDown(), are represented in the subclass of the tool interface.
    //In contrast, in the strategy pattern, we do not have a single state. 
    //Different behaviors are represented by different strategy objects.
    public class ImageStorage
    {
        private ICompressor compressor;
        private IFilter filter;

        public ImageStorage(ICompressor compressor, IFilter filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void Store(string fileName)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);
        }
    }
}
