using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Expressions.BinaryExpressions;
using ITEJA_sem_prace_Dokoupil.Parser.Others.DataTypes;

namespace ITEJA_sem_prace_Dokoupil.Parser.Expressions
{
    internal class Expression
    {
        public Term term;
        public Expression(Tokens tokens)
        {
            term = new Term(tokens);
            while (tokens.GetNextToken().Type == TokenType.PLUS || tokens.GetNextToken().Type == TokenType.MINUS)
            {
                TokenType t = tokens.GetCurrTokenAndMove().Type;
                tokens.MoveCurrNext();
                Term right = new Term(tokens);
                switch (t)
                {
                    case TokenType.PLUS:
                        break;
                    case TokenType.MINUS:
                        break;
                    default:
                        throw new Exception("Missing operator + or -");
                }
                term = new TermSides(term, t, right);
            }
        }
    }
}
