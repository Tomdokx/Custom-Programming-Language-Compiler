using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Expressions;
using ITEJA_sem_prace_Dokoupil.Parser.Expressions.UnaryExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Statements
{
    internal class ExecuteStatement : Statement
    {
        public FuncCallExpression funcCall;
        public ExecuteStatement(Tokens tokens)
        {
            if (tokens.GetCurrToken().Type != TokenType.IDENTIFIER) 
                throw new Exception("Not an identifier");
            funcCall = new FuncCallExpression(tokens);
            if (tokens.GetCurrTokenAndMove().Type != TokenType.SEMICOLON) 
                throw new Exception("Missing semicolon");
        }
    }
}
