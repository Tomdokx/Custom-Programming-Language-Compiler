using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Statements
{
    internal class StatementPart
    {
        public List<Statement> statements;
        public StatementPart(Tokens tokens)
        {
            statements = new List<Statement>();
            if (tokens.GetCurrTokenAndMove().Type != TokenType.BEGIN) 
                throw new Exception("Cannot find word Begin");
            bool d = true;
            while(d)
            {
                switch (tokens.GetCurrToken().Type)
                {
                    case TokenType.WHILE:
                        tokens.MoveCurrNext();
                        statements.Add(new WhileStatement(tokens));
                        break;
                    case TokenType.FOR:
                        tokens.MoveCurrNext();
                        statements.Add(new ForStatement(tokens));
                        break;
                    case TokenType.DO:
                        tokens.MoveCurrNext();
                        statements.Add(new DoStatement(tokens));
                        break;
                    case TokenType.IF:
                        tokens.MoveCurrNext();
                        statements.Add(new IfStatement(tokens));
                        break;
                    case TokenType.EXECUTE:
                        tokens.MoveCurrNext();
                        statements.Add(new ExecuteStatement(tokens));
                        break;
                    case TokenType.RETURN:
                        tokens.MoveCurrNext();
                        statements.Add(new ReturnStatement(tokens));
                        break;
                    case TokenType.IDENTIFIER:
                        statements.Add(new SetStatement(tokens));
                        break;
                    case TokenType.END:
                        tokens.MoveCurrNext();
                        d = false;
                        break;
                    default: throw new Exception("Expected statement.");
                }
            }
        }
    }
}
