using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Conditions
{
    internal class TermCondition
    {
        FactorCondition factorCond;

        public TermCondition(Tokens tokens)
        {
            factorCond = new FactorCondition(tokens);
            while(tokens.GetNextToken().Type == TokenType.OR)
            {
                TokenType t = tokens.GetCurrTokenAndMove().Type;
                tokens.MoveCurrNext();
                FactorCondition right = new FactorCondition(tokens);
                
                factorCond = new OrCondition(factorCond, t, right);
            }
        }
        public TermCondition() { }
        
    }
}
