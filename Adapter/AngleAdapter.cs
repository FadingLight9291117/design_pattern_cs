using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class AngleAdapter : IGraph
    {
        private Angle angle;
        public AngleAdapter(Angle angle)
        {
            this.angle = angle;
        }
        public void Draw()
        {
            angle.DrawAngle();
        }
    }
}
