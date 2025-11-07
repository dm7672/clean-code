using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdown
{
    internal class Parser
    {
        private StringBuilder result; // для построения результата пошагово
        private int pos; // позиция парсера в списке токенов
        private Stack<Marker> parsingStack;
        private List<ParsingRule> parsingRules;
        public Parser(List<ParsingRule> parsingRules)
        {
            throw new NotImplementedException();
        }
        public bool CanParse(List<Token> tokens)
        {
            throw new NotImplementedException();
        }

        public string Parse(List<Token> tokens)
        {
            throw new NotImplementedException();
        }
        private ParseUntilTerminator(TokenType terminator)
        {
            throw new NotImplementedException();
        }
        private Token Lookahead(int ahead = 0) // в процессе парсинга будем заглядывать в список токенов
                                               // чтобы узнать какое правило применить
        {
            throw new NotImplementedException();
        }
    }
}
