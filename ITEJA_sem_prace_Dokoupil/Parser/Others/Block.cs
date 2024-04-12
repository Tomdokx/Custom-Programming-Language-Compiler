using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Others.BlockDefine;
using ITEJA_sem_prace_Dokoupil.Parser.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Others
{
    internal class Block
    {
        public List<Variable> vars;
        public List<Constant> consts;
        public List<Procedure> procedures;
        public List<Function> funcs;
        public StatementPart statements;

        public Block(Tokens tokens)
        {
            vars = new List<Variable>();
            consts = new List<Constant>();
            procedures = new List<Procedure>();
            funcs = new List<Function>();
            bool d = true;
            while (d)
            {
                switch(tokens.GetCurrToken().Type)
                {
                    case TokenType.VAR:
                        tokens.MoveCurrNext();
                        vars.Add(new Variable(tokens));
                        if (tokens.GetCurrTokenAndMove().Type != TokenType.SEMICOLON) 
                            throw new Exception("Missing ;");

                        break;
                    case TokenType.CONST:
                        tokens.MoveCurrNext();
                        consts.Add(new Constant(tokens));
                        if (tokens.GetCurrTokenAndMove().Type != TokenType.SEMICOLON) 
                            throw new Exception("Missing ;");

                        break;
                    case TokenType.PROCEDURE:
                        tokens.MoveCurrNext();
                        procedures.Add(new Procedure(tokens));
                        if (tokens.GetCurrTokenAndMove().Type != TokenType.SEMICOLON) 
                            throw new Exception("Missing ;");

                        break;
                    case TokenType.FUNCTION:
                        tokens.MoveCurrNext();
                        funcs.Add(new Function(tokens));
                        if (tokens.GetCurrTokenAndMove().Type != TokenType.SEMICOLON) 
                            throw new Exception("Missing ;");
                        break;
                    default:
                        d = false;
                        break;
                }
            }
            statements = new StatementPart(tokens);
        }
    }
}
