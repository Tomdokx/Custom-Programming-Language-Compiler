using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Lexer
{
    public enum TokenType
    {
        PROGRAM, SEMICOLON, NUMBER, IDENTIFIER, CONST, VAR, FUNCTION, PROCEDURE, DATA_TYPE, EQUALS,
        COLON, OPEN, CLOSE, COMMA, BEGIN, END, WHILE, DO, IF, THEN, FOR, COLON_EQUALS, TO, DOWNTO,
        EXECUTE, RETURN, PLUS, MINUS, STRING, DOUBLE, LESS_EQUAL, LESS, GREATER_EQUAL, GREATER,
        DOUBLE_EQUALS, NOT_EQUAL, OR, AND, DIVIDE, MULTIPLY, DOT
    }
    internal class Token
    {
        public TokenType Type { get; init; }
        public string? Value { get; init; }

        public Token(TokenType type, string? value = null)
        {
            Type = type;
            Value = value;
        }

        public override string? ToString()
        {
            return this.Value == null ? $"{Type}" : $"{Type}, value: {Value}";
        }
    }
}
