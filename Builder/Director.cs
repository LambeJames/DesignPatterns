using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalViableProduct()
        {
            _builder.BuildChassis();
            _builder.BuildBody();
            _builder.BuildEngine();
            _builder.BuildSeats();
        }

        public void BuildFullFeaturedProduct()
        {
            _builder.BuildChassis();
            _builder.BuildBody();
            _builder.BuildEngine();
            _builder.BuildSeats();
            _builder.BuildSpoiler();
            _builder.BuildGoFasterStripes();
        }
    }
}
