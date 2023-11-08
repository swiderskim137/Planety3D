using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planety3D
{
    internal class Model
    {
        public Model()
        {
            this.srPlanety = 1f;
            this.srModelu = 1f;
            this.wysTopPlanety = 1f;
            this.wysTopModelu = 1f;
            this.skalaSr = 1f;
            this.skalaTop = 1f;
            this.skalerTop = 1f;
            this.srModNaWysTopMod = 1f;
        }

        public float srPlanety;
        public float srModelu;
        public float wysTopPlanety;
        public float wysTopModelu;
        public float skalaSr;
        public float skalaTop;
        public float skalerTop;
        public float srModNaWysTopMod;

        public bool typModWarUstalone;
        public bool typModSkalerTop;
        public bool typModSrNaTop;

        public float IlorazSrTop()
        {
            return srModelu / wysTopModelu;
        }
    }
}
