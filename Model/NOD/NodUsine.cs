using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.NOD
{
    class NodUsine : Usine
    {
        public override ContreTorpilleurs CreateContreTorpilleurs()
        {
            return new NodContreTorpilleur();
        }

        public override Croiseur CreateCroiseur()
        {
            return new NodCroiseur();
        }

        public override PorteAvion CreatePorteAvion()
        {
            return new NodPorteAvion();
        }

        public override Torpilleur CreateTorpilleur()
        {
            return new NodTorpilleur();
        }
    }
}
