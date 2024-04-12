using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEJA_sem_prace_Dokoupil.Parser.Expressions.BinaryExpressions
{
    internal abstract class BinaryExpression
    {
        protected Expression left;
        protected Expression right;
        protected BinaryExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }
    }
}
