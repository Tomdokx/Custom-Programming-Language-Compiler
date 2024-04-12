using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Expressions.UnaryExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Expressions
{
    internal class Factor
    {
        public UnaryExpression unary;
        public Factor(Tokens tokens)
        {
            unary = new UnaryExpression(tokens);
        }
        public Factor(){}
    }
}
