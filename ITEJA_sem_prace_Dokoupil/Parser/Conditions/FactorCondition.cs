using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Conditions
{
    internal class FactorCondition
    {
        public PrimaryCondition primaryCond;
        public FactorCondition(Tokens tokens)
        {
            Expression left = new Expression(tokens);
            TokenType t = tokens.GetCurrToken().Type;
            bool b = false;
            switch (t)
            {
                case TokenType.GREATER:
                case TokenType.GREATER_EQUAL:
                case TokenType.DOUBLE_EQUALS:
                case TokenType.NOT_EQUAL:
                case TokenType.LESS:
                case TokenType.LESS_EQUAL:
                    b = true;
                    tokens.MoveCurrNext();
                    break;
                default:
                    break;
            }
            if (b)
            {
                Expression right = new Expression(tokens);
                primaryCond = new BinaryCondition(left, right, t);
            }
            else
            {
                primaryCond = new OddCondition(left);
            }
        }
        public FactorCondition() { }
    }
}
