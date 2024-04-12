using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Expressions.UnaryExpressions
{
    internal class NumberLitExpression : LiteralExpression
    {
        public int value;
        public NumberLitExpression(Tokens tokens)
        {
            if (!int.TryParse(tokens.GetCurrTokenAndMove().Value, out this.value))
            {
                throw new Exception("Expect value of double");
            }
        }
    }
}
