using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Expressions.UnaryExpressions
{
    internal class StringLitExpression : LiteralExpression
    {
        public string value;
        public StringLitExpression(Tokens tokens)
        {
            if (tokens.GetCurrToken().Value == null)
                throw new Exception("Value cannot be null");
            value = tokens.GetCurrTokenAndMove().Value;
        }
    }
}
