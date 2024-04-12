using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Expressions.UnaryExpressions
{
    internal class FuncCallExpression : Primary
    {
        public List<Expression> arguments;
        public string ident;

        public FuncCallExpression(Tokens tokens)
        {
            arguments = new List<Expression>();
            ident = tokens.GetCurrTokenAndMove().Value;
            if (tokens.GetCurrTokenAndMove().Type != TokenType.OPEN) throw new Exception("Missing (");
            while (true)
            {
                arguments.Add(new Expression(tokens));
                if (tokens.GetCurrToken().Type != TokenType.COMMA) break;
                tokens.MoveCurrNext();
            }
            if (tokens.GetCurrTokenAndMove().Type != TokenType.CLOSE) throw new Exception("Missing )");
        }
    }
}
