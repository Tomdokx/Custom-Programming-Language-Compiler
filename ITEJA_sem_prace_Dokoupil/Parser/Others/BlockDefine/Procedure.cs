using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Others.BlockDefine
{
    internal class Procedure
    {
        public string ident;
        public List<Variable> parameters;
        public Block block;

        public Procedure(Tokens tokens)
        {
            parameters = new List<Variable>();
            if (tokens.GetCurrToken().Type != TokenType.IDENTIFIER) throw new Exception("Not an identifier");
            ident = tokens.GetCurrTokenAndMove().Value ?? "";
            if (tokens.GetCurrTokenAndMove().Type != TokenType.OPEN) throw new Exception("Missing (");
            while (true)
            {
                parameters.Add(new Variable(tokens));
                if (tokens.GetCurrToken().Type != TokenType.COMMA) break;
                tokens.MoveCurrNext();
            }
            if (tokens.GetCurrTokenAndMove().Type != TokenType.CLOSE) throw new Exception("Missing )");
            block = new Block(tokens);
        }
    }
}
