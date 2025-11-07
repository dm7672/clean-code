using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Markdown
{
    public class Md
    {
        /*
         * Парсить буду предполагая что специальный язык является контекстно свободным
         * Сначала подберу правила для контекстно свободного языка,
         * Запишу их в виде ParsingRule
         *
         * Разобью строку на токены - терминалы
         * С помощью парсера попытаюсь свернуть по правилам терминалы к нетерминалам - маркерам
         * После свёртки по правилам разверну обратно в терминалы добавляя нужные HTML теги
         */
        public string Render(string text)
        {
            var tokenizer = new Tokenizer();
            var tokens = tokenizer.Tokenize(text);

            var parsingRules = new List<ParsingRule>();

            var parser = new Parser(parsingRules);
            var parcedText = parser.Parse(tokens);

            return parcedText;
            
        }
    }
    
}
