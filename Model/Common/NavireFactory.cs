using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public abstract class NavireFactory
    {
        public abstract ContreTorpilleurs CreateContreTorpilleurs();
        public abstract Croiseur CreateCroiseur();
        public abstract PorteAvion CreatePorteAvion();
        public abstract Torpilleur CreateTorpilleur();
    }
}
