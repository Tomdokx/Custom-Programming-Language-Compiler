using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Expressions.BinaryExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Expressions
{
    internal class Term
    {
        public Factor factor;
        public Term()
        {
        }
        public Term(Tokens tokens)
        {
            factor = new Factor(tokens);
            while (tokens.GetNextToken().Type == TokenType.DIVIDE || tokens.GetNextToken().Type == TokenType.MULTIPLY)
            {
                TokenType t = tokens.GetCurrTokenAndMove().Type;
                tokens.MoveCurrNext();
                Factor right = new Factor(tokens);
                switch (t)
                {
                    case TokenType.DIVIDE:
                        break;
                    case TokenType.MULTIPLY:
                        break;
                    default:
                        throw new Exception("Missing operator + or -");
                }
                factor = new FactorSides(factor, t, right);
            }
        }


    }
}
