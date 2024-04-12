using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Expressions.BinaryExpressions
{
    internal class FactorSides: Factor
    {
        public Factor left;
        public Factor right;
        public TokenType oper;

        public FactorSides(Factor left, TokenType oper, Factor right)
        {
            this.left = left;
            this.right = right;
            this.oper = oper;
        }

    }
}
