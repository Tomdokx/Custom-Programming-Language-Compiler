using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Conditions
{
    internal class OrCondition : FactorCondition
    {
        public FactorCondition left;
        public TokenType oper;
        public FactorCondition right;

        public OrCondition(FactorCondition left,TokenType oper,FactorCondition right)
        {
            this.left = left;
            this.oper = oper;
            this.right = right;
        }
    }
}
