using ITEJA_sem_prace_Dokoupil.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Others
{
    internal class Program
    {
        public Block block;
        public string ident;
        
        public Program(Tokens tokens)
        {
            if (tokens.GetCurrTokenAndMove().Type != TokenType.PROGRAM) 
                throw new Exception("Missing word Program");
            if (tokens.GetCurrToken().Type != TokenType.IDENTIFIER) 
                throw new Exception("Not an identifier");
            ident = tokens.GetCurrTokenAndMove().Value?? "";
            if (tokens.GetCurrTokenAndMove().Type != TokenType.SEMICOLON) 
                throw new Exception("Missing ;");
            block = new Block(tokens);
            if (tokens.GetCurrToken().Type != TokenType.DOT) 
                throw new Exception("Missing .");
        }
    }
}
