using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Statements
{
    internal class DoStatement : Statement
    {
        public Condition condition;
        public StatementPart statements;

        public DoStatement(Tokens tokens)
        {
            statements = new StatementPart(tokens);
            if (tokens.GetCurrTokenAndMove().Type != TokenType.WHILE) throw new Exception("Expect word While");
            condition = new Condition(tokens);
            if (tokens.GetCurrTokenAndMove().Type != TokenType.SEMICOLON) throw new Exception("Missing ;");
        }
    }
}
