using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Statements
{
    internal class WhileStatement : Statement
    {
        public Condition condition;
        public StatementPart statements;

        public WhileStatement(Tokens tokens)
        {
            condition = new Condition(tokens);
            if (tokens.GetCurrTokenAndMove().Type != TokenType.DO)
                throw new Exception("Missing a word DO");
            statements = new StatementPart(tokens);
            if (tokens.GetCurrTokenAndMove().Type != TokenType.SEMICOLON)
                throw new Exception("Missing ;");
        }
    }
}
