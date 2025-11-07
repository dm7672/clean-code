using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdown
{
    internal class ParsingRule

    {
        public Marker Left { get; }
        public List<object> Right { get; } // В нём будут находиться токены и маркеры

        public ParsingRule(Marker left, IEnumerable<object> right)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
