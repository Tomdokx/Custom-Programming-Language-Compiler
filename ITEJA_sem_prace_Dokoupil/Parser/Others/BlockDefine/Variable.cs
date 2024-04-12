using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Others.BlockDefine
{
    internal class Variable
    {
        public string ident;
        public Token type;

        public Variable(Tokens tokens)
        {
            if (tokens.GetCurrToken().Type != TokenType.IDENTIFIER) throw new Exception("Not an identifier");
            ident = tokens.GetCurrTokenAndMove().Value;
            if (tokens.GetCurrTokenAndMove().Type != TokenType.COLON) throw new Exception("Missing :");
            type = tokens.GetCurrTokenAndMove();
            
        }
    }
}
