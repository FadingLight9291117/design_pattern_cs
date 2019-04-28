using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class AbstractEmployee
    {
        private string name;
        private double income;
        private int vacation;
        public AbstractEmployee(String name, double income, int vacation)
        {
            this.name = name;
            this.income = income;
            this.vacation = vacation;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public double Income
        {
            get { return income; }
            set { income = value; }
        }
        public int Vacation
        {
            get { return vacation; }
            set { vacation = value; }
        }
        abstract public void Accept(AbstractVisitor visitor);
    }
    class Engineer : AbstractEmployee
    {
        public Engineer(string name, double income, int vacation) : base(name, income, vacation) { }

        public override void Accept(AbstractVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    class Salesman : AbstractEmployee
    {
        public Salesman(string name, double income, int vacation) : base(name, income, vacation) { }
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    class Economist : AbstractEmployee
    {
        public Economist(string name, double income, int vacation) : base(name, income, vacation) { }
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
