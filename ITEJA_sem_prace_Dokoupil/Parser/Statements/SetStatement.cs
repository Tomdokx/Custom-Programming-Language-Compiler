using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Statements
{
    internal class SetStatement : Statement
    {
        public string ident;
        public Expression expression;
        public SetStatement(Tokens tokens)
        {
            if (tokens.GetCurrToken().Type != TokenType.IDENTIFIER) 
                throw new Exception("Not an identifier");
            ident = tokens.GetCurrTokenAndMove().Value;
            if (tokens.GetCurrTokenAndMove().Type != TokenType.COLON_EQUALS) 
                throw new Exception("Expected := ");
            expression = new Expression(tokens);
            if (tokens.GetCurrTokenAndMove().Type != TokenType.SEMICOLON) 
                throw new Exception("Expected semicolon");
        }
    }
}
