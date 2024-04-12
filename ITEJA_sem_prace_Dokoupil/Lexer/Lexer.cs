using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Lexer
{
    internal class Lexer
    {
        private int startTokenIndex;
        private int currentTokenIndex;
        private string code;

        public List<Token> Tokens { get; }
        public Lexer() { Tokens = new List<Token>(); }
        
        public void GenerateTokens(string code)
        {
            startTokenIndex = 0;
            currentTokenIndex = 0;
            this.code = code;
            while (currentTokenIndex < code.Length)
            {
                TokenType? CurrTokenType = GetTokenType();

                if (CurrTokenType != null)
                {
                    if (CurrTokenType == TokenType.IDENTIFIER)
                    {
                        string valueOfIden = code.Substring(startTokenIndex, currentTokenIndex - startTokenIndex);
                        if (valueOfIden.Equals("Integer") || valueOfIden.Equals("Double") || valueOfIden.Equals("String"))
                            Tokens.Add(new Token(TokenType.DATA_TYPE, valueOfIden));
                        else Tokens.Add(new Token(TokenType.IDENTIFIER, valueOfIden));
                    }
                    else if (CurrTokenType == TokenType.NUMBER || CurrTokenType == TokenType.DOUBLE)
                    {
                        Tokens.Add(new Token((TokenType)CurrTokenType, code.Substring(startTokenIndex, currentTokenIndex - startTokenIndex)));
                    }
                    else if(CurrTokenType == TokenType.STRING)
                    {
                        Tokens.Add(new Token((TokenType)CurrTokenType, code.Substring(startTokenIndex, (currentTokenIndex-1) - startTokenIndex)));

                    }
                    else
                    {
                        Tokens.Add(new Token((TokenType)CurrTokenType));
                    }
                }
            }
        }

        private TokenType? GetTokenType()
        {
            startTokenIndex = currentTokenIndex;
            char tokenReader = code[currentTokenIndex++];
            switch (tokenReader)
            {
                case '.':
                    return TokenType.DOT;
                case ';':
                    return TokenType.SEMICOLON;
                case ':':
                    return GetNextChar('=') ? TokenType.COLON_EQUALS : TokenType.COLON;
                case '<':
                    return GetNextChar('=') ? TokenType.LESS_EQUAL : TokenType.LESS;
                case '>':
                    return GetNextChar('=') ? TokenType.GREATER_EQUAL : TokenType.GREATER;
                case '+':
                    return TokenType.PLUS;
                case '!':
                    if (!GetNextChar('=')) return null;
                    return TokenType.NOT_EQUAL;
                case '-':
                    return TokenType.MINUS;
                case '*':
                    return TokenType.MULTIPLY;
                case '/':
                    return TokenType.DIVIDE;
                case ',':
                    return TokenType.COMMA;
                case '=':
                    return GetNextChar('=') ? TokenType.DOUBLE_EQUALS : TokenType.EQUALS;
                case '(':
                    return TokenType.OPEN;
                case ')':
                    return TokenType.CLOSE;
                case '\'':
                    return ReadString();
                case ' ':
                case '\n':
                case '\t':
                case '\r':
                default:
                    if (char.IsDigit(tokenReader))
                    {
                        bool d = false;
                        currentTokenIndex--;
                        while (currentTokenIndex < code.Length && char.IsDigit(code[currentTokenIndex]))
                        {
                            currentTokenIndex++;
                            if (code[currentTokenIndex] == '.')
                            {
                                d = true;
                                if (!char.IsDigit(code[++currentTokenIndex]))
                                {
                                    throw new Exception("Double must be completed after dot.");
                                }
                            }
                        }
                        return d ? TokenType.DOUBLE : TokenType.NUMBER;
                    }
                    else if (char.IsLetter(tokenReader))
                    {
                        string str = "";
                        while (currentTokenIndex < code.Length && char.IsLetter(code[currentTokenIndex]))
                        {
                            currentTokenIndex++;
                        }
                        str = code.Substring(startTokenIndex, currentTokenIndex - startTokenIndex);
                        return (str.ToLower()) switch
                        {
                            "program" => TokenType.PROGRAM,
                            "const" => TokenType.CONST,
                            "var" => TokenType.VAR,
                            "execute" => TokenType.EXECUTE,
                            "function" => TokenType.FUNCTION,
                            "procedure" => TokenType.PROCEDURE,
                            "begin" => TokenType.BEGIN,
                            "end" => TokenType.END,
                            "if" => TokenType.IF,
                            "then" => TokenType.THEN,
                            "for" => TokenType.FOR,
                            "to" => TokenType.TO,
                            "downto" => TokenType.DOWNTO,
                            "return" => TokenType.RETURN,
                            "or" => TokenType.OR,
                            "and" => TokenType.AND,
                            "while" => TokenType.WHILE,
                            "do" => TokenType.DO,
                            _ => TokenType.IDENTIFIER
                        };
                    }
                    else
                    {
                        return null;
                    }
            }
        }
        private TokenType? ReadString()
        {
            startTokenIndex++;
            while (!GetNextChar('\''))
            {
                currentTokenIndex++;
            }
            return TokenType.STRING;
        }
        private bool GetNextChar(char C)
        {
            if (code.Length > currentTokenIndex && C != code[currentTokenIndex])
            {
                return false;
            }
            else
            {
                currentTokenIndex++;
                return true;
            }
        }
        public Tokens getGeneratedTokens()
        {
            return new Tokens(Tokens);
        }
        public void printTokens()
        {
            int a = 0;
            foreach (Token t in Tokens)
            {
                Console.WriteLine(a++ + " " + t.ToString());
            }
        }
    }
}
