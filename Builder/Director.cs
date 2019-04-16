using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Director
    {
        private AutoBulider autoBulider;
        public Director(AutoBulider autoBulider)
        {
            this.autoBulider = autoBulider;
        }
        public void SetBuilder(AutoBulider autoBulider)
        {
            this.autoBulider = autoBulider;
        }
        public void Construct()
        {
            autoBulider.buildBody();
            autoBulider.buildOilbox();
            autoBulider.buildWheel();
        }
    }
}
