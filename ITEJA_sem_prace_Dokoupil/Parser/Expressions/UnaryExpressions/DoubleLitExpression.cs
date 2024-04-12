using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Expressions.UnaryExpressions
{
    internal class DoubleLitExpression : LiteralExpression
    {
        public double value;
        public DoubleLitExpression(Tokens tokens)
        {
            string s = tokens.GetCurrTokenAndMove().Value.Replace('.', ',');
            if (!double.TryParse(s, out value))
            {
                throw new Exception("Expect value of double");
            }
        }
    }
}
