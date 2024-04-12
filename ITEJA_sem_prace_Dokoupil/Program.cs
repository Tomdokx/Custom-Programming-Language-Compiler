// See https://aka.ms/new-console-template for more information
using ITEJA_sem_prace_Dokoupil.Lexer;
using ITEJA_sem_prace_Dokoupil.Parser.Others;

public class Prog
{
    public static void Main(string[] args)
    {
        string code;
        // test define ------------
        /*code = "program prog; " +
            "var a : Integer;" +
            " begin a := 5;" +
            " end .";*/
        /*code = "program prog;" +
            " const a = 5;" +
            " var c: Double;" +
            " procedure proc(b: Integer)" +
            "begin" +
            "c := 6;" +
            " end;" +
            " begin" +
            " execute proc(5);" +
            " end" +
            " .";*/
        /*code = "program prog;" +
            "var x : Double;" +
            "function func (a : Double, y: Double) : Double " +
            "var b: Integer; " +
            "begin " +
            "b:=5; " +
            "return b; " +
            " end;" +
            "begin " +
            "x := func(6.5, 2.8);" +
            "end" +
            ". ";*/
        // ------------
        // test statements -----------
        //while
        /*code = "program prog; " +
            "var a : String; " +
            "begin " +
            "while 5 > 2 do " +
            "begin " +
            "execute func(a); " +
            "end; " +
            "end " +
            ". ";*/
        //if 
        /*code = "program prog; " +
            "var a : String; " +
            "begin " +
            "if 5 > 2 then " +
            "begin " +
            "execute func(a); " +
            "end; " +
            "end " +
            ". ";*/
        //do-while
        /*code = "program prog; " +
            "var a : String; " +
            "begin " +
            "do " +
            "begin " +
            "execute func(a); " +
            "end " +
            "while 5 > 2;" +
            "end " +
            ". ";*/
        code = "program prog; " +
            "var a : String; " +
            "begin " +
            "for i := 0 downto 5 " +
            "begin " +
            "execute func(i);" +
            "a := 'Ahoj jak je?' ; " +
            "end; " +
            "end " +
            ". ";
        Lexer l = new Lexer();
        l.GenerateTokens(code);
        l.printTokens();
        try
        {
            Program program = new Program(l.getGeneratedTokens());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}


