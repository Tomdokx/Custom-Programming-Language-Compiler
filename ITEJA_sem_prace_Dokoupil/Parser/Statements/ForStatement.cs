using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Conditions;
using ITEJA_sem_prace_Dokoupil.Parser.Expressions;
using ITEJA_sem_prace_Dokoupil.Parser.Expressions.UnaryExpressions;
using ITEJA_sem_prace_Dokoupil.Parser.Others.BlockDefine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Statements
{
    internal class ForStatement : Statement
    {
        public string ident;
        public Expression expression;
        public bool to;
        public NumberLitExpression number;
        public StatementPart statements;
        public ForStatement(Tokens tokens)
        {
            if (tokens.GetCurrToken().Type != TokenType.IDENTIFIER) throw new Exception("Not an identifier");
            ident = tokens.GetCurrTokenAndMove().Value;
            if (tokens.GetCurrTokenAndMove().Type == TokenType.COLON_EQUALS)
            {
                expression = new Expression(tokens);
            }
            switch (tokens.GetCurrTokenAndMove().Type)
            {
                case TokenType.TO:
                    to = true;
                    break;
                case TokenType.DOWNTO:
                    to = false;
                    break;
                default:
                    throw new Exception("Expect to or downto");
            }
            number = new NumberLitExpression(tokens);
            statements = new StatementPart(tokens);
            if (tokens.GetCurrTokenAndMove().Type != TokenType.SEMICOLON) throw new Exception("Expected semicolon");
        }
    }
}
