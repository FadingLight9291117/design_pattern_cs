using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ObjectStructure
    {
        private ArrayList employee = new ArrayList();
        public void Attach(AbstractEmployee element)
        {
            employee.Add(element);
        }
        public void Detach(AbstractEmployee element)
        {
            employee.Remove(element);
        }
        public void Accept(AbstractVisitor visitor)
        {
            foreach (AbstractEmployee item in employee)
            {
                item.Accept(visitor);
            }
        }
    }
}
