using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Statements
{
    internal class IfStatement : Statement
    {
        public Condition condition;
        public StatementPart statements;

        public IfStatement(Tokens tokens)
        {
            condition = new Condition(tokens);
            if (tokens.GetCurrTokenAndMove().Type != TokenType.THEN) throw new Exception("Missing a word then");
            statements = new StatementPart(tokens);
            if (tokens.GetCurrTokenAndMove().Type != TokenType.SEMICOLON) throw new Exception("Missing ;");
        }
    }
}
