using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdown
{
    internal enum TokenType
    {
        Text,
        Digit,         //'0-9'
        EscapedChar,   // \(x) 
        Whitespace,    // ' '
        Underscore,    // '_'
        DoubleUnderscore, // '__' 
        Hash,          // '#'
        NewLine,       // '\n'
        EOF            // конец файла
    }
    internal class Token
    {
        public TokenType Type { get; } 
        public string Value { get; }
        public bool CanOpen { get;}
        public bool CanClose { get; }
        public Token(TokenType type, string text = "")
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
    
}
