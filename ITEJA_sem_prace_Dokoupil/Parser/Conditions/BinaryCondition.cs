using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Conditions
{
    internal class BinaryCondition : PrimaryCondition
    {
        public Expression left;
        public Expression right;
        public TokenType operat;
        public BinaryCondition(Expression left, Expression right, TokenType operat)
        {
            this.left = left;
            this.right = right;
            this.operat = operat;
        }
    }
}
