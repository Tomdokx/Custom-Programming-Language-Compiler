using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Expressions.UnaryExpressions
{
    internal class IdentExpression : Primary
    {
        public string ident;

        public IdentExpression(Tokens tokens)
        {
            ident = tokens.GetCurrTokenAndMove().Value ?? "";
        }
    }
}
