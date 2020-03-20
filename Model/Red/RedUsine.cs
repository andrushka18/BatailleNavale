using Model.Common;

namespace Model.Red
{
    public class RedUsine : Usine
    {
        public override ContreTorpilleurs CreateContreTorpilleurs()
        {
            return new RedContreTorpilleurs();
        }

        public override Croiseur CreateCroiseur()
        {
            return new RedCroiseur();
        }

        public override PorteAvion CreatePorteAvion()
        {
            return new RedPorteAvion();
        }

        public override Torpilleur CreateTorpilleur()
        {
            return new RedTorpilleur();
        }
    }
}