using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Conditions
{
    internal class Condition
    {
        public TermCondition termCond;
        public Condition(Tokens tokens)
        {
            termCond = new TermCondition(tokens);
            while (tokens.GetNextToken().Type == TokenType.AND)
            {
                TokenType t = tokens.GetCurrTokenAndMove().Type;
                tokens.MoveCurrNext();
                TermCondition right = new TermCondition(tokens);
                termCond = new AndCondition(termCond, t, right);
            }
        }
    }
}
