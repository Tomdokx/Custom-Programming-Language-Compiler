using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Others.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Expressions.UnaryExpressions
{
    internal class UnaryExpression
    {
        public Primary primary;
        public TokenType oper;
        public UnaryExpression(Tokens tokens)
        {
            if (tokens.GetCurrToken().Type == TokenType.PLUS || tokens.GetCurrToken().Type == TokenType.MINUS)
                oper = tokens.GetCurrTokenAndMove().Type;
            switch (tokens.GetCurrToken().Type)
            {
                case TokenType.NUMBER:
                    primary = new NumberLitExpression(tokens);
                    break;
                case TokenType.STRING:
                    primary = new StringLitExpression(tokens);
                    break;
                case TokenType.DOUBLE:
                    primary = new DoubleLitExpression(tokens);
                    break;
                case TokenType.IDENTIFIER:
                    if (tokens.GetNextToken().Type == TokenType.OPEN)
                    {
                        primary = new FuncCallExpression(tokens);
                        break;
                    }
                    primary = new IdentExpression(tokens);
                    break;
                default:
                    throw new Exception("Expected Primary");
            }
        }
    }
}
