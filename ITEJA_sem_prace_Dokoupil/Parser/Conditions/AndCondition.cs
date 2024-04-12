using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Conditions
{
    internal class AndCondition : TermCondition
    {
        TermCondition left;
        TokenType oper;
        TermCondition right;

        public AndCondition(TermCondition left, TokenType oper, TermCondition right)
        {
            this.left = left;
            this.oper = oper;
            this.right = right;
        }
    }
}
