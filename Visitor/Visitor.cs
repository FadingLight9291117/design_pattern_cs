using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class AbstractVisitor
    {
        abstract public void Visit(AbstractEmployee element);
    }
    class IncomeVisitor : AbstractVisitor
    {
        public override void Visit(AbstractEmployee element)
        {
            element.Income += 500;
            Console.WriteLine("{0} 的新工资是 {1}", element.Name, element.Income);
        }
    }
    class VacationVisitor : AbstractVisitor
    {
        public override void Visit(AbstractEmployee element)
        {
            element.Vacation += 3;
            Console.WriteLine("{0} 的新假期是 {1}", element.Name, element.Vacation);
        }
    }
}
