using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Statements
{
    internal class ReturnStatement : Statement
    {
        public Condition cond;

        public ReturnStatement(Tokens tokens)
        {
            cond = new Condition(tokens);
            if (tokens.GetCurrTokenAndMove().Type != TokenType.SEMICOLON) throw new Exception("Missing ;");
        }
    }
}
