using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Lexer
{
    internal class Tokens
    {
        private List<Token> tokens;
        private int currIndex;
        public Tokens(List<Token> tokens)
        {
            this.tokens = tokens;
        }
        private bool NextExist()
        {
            if (currIndex > tokens.Count -1) return false;
            if (tokens[currIndex+1] == null) return false;
            return true;
        }
        public void MoveCurrNext()
        {
            if (NextExist())
                currIndex++;
            else
                throw new Exception("Cannot move to next token");
        }
        public void MoveCurrBack()
        {
            currIndex--;
        }
        public Token GetCurrToken()
        {
            return tokens[currIndex];
        }
        public Token GetCurrTokenAndMove()
        {
            if (NextExist())
                return tokens[currIndex++];
            else
                throw new Exception("Cannot move to next token");
        }
        public Token GetPreviousToken()
        {
            if (currIndex < 0) throw new Exception("Cannot bring you token from position -1.");
            return tokens[currIndex - 1];
        }
        public Token GetNextToken()
        {
            if (NextExist())
                return tokens[currIndex + 1];
            else
                throw new Exception("Next token doesn't exist");
        }
    }
}
