using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdown
{
    internal class Marker
    {
        public TokenType MarkerType { get; }
        public List<object> Right { get; }
        public Marker(TokenType markerType, List<object> Right)
        {
            throw new NotImplementedException();
        }
    }
}
