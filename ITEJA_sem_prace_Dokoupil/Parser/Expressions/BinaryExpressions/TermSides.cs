using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Expressions.BinaryExpressions
{
    internal class TermSides : Term
    {
        public Term left;
        public Term right;
        public TokenType oper;

        public TermSides(Tokens tokens) : base(tokens)
        {
        }
        public TermSides(Term left, TokenType oper, Term right)
        {
            this.left = left;
            this.right = right;
            this.oper = oper;
        }
    }
}
