using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractEmployee XiaoChen = new Engineer("小陈", 8200, 25);
            AbstractEmployee XiaoLi = new Engineer("小李", 9000, 20);
            AbstractEmployee Xiaozhou = new Economist("小周", 8000, 23);
            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Attach(XiaoChen);
            objectStructure.Attach(XiaoLi);
            objectStructure.Attach(Xiaozhou);
            AbstractVisitor incomeVisitor = new IncomeVisitor();
            AbstractVisitor vacationVisitor = new VacationVisitor();
            objectStructure.Accept(incomeVisitor);
            objectStructure.Accept(vacationVisitor);
        }
    }
}
