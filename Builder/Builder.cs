using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    abstract class AutoBulider
    {
        protected Auto auto = new Auto();
        public abstract void buildWheel();
        public abstract void buildOilbox();
        public abstract void buildBody();
        public Auto GetResult()
        {
            return auto;
        }
    }
    class BMWBuilder : AutoBulider
    {
        public override void buildBody()
        {
            auto.Wheel = "宝马车身";
        }

        public override void buildOilbox()
        {
            auto.Oilbox = "宝马油箱";
        }

        public override void buildWheel()
        {
            auto.Body = "宝马车轮";
        }
    }
    class BenZBulider : AutoBulider
    {
        public override void buildBody()
        {
            auto.Wheel = "奔驰车身";
        }

        public override void buildOilbox()
        {
            auto.Oilbox = "奔驰油箱";
        }

        public override void buildWheel()
        {
            auto.Body = "奔驰车轮";
        }
    }
}

