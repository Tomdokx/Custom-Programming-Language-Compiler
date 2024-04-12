using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEJA_sem_prace_Dokoupil.Parser.Others.DataTypes;
using ITEJA_sem_prace_Dokoupil.Parser.Expressions;
using ITEJA_sem_prace_Dokoupil.Lexer;
namespace ITEJA_sem_prace_Dokoupil.Parser.Others.BlockDefine
{
    internal class Constant
    {
        public Expression expr;
        public string ident;

        public Constant(Tokens tokens)
        {
            if (tokens.GetCurrToken().Type != TokenType.IDENTIFIER) throw new Exception("Not an identifier.");
            ident = tokens.GetCurrTokenAndMove().Value;
            if (tokens.GetCurrTokenAndMove().Type != TokenType.EQUALS) throw new Exception("Not an equals");
            expr = new Expression(tokens);
        }
    }
}
