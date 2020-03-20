using Model.Common;

namespace Model.Blue
{
    public class BlueUsine : Usine
    {
        public override ContreTorpilleurs CreateContreTorpilleurs()
        {
            return new BlueContreTorpilleurs();
        }

        public override Croiseur CreateCroiseur()
        {
            return new BlueCroiseur();
        }

        public override PorteAvion CreatePorteAvion()
        {
            return new BluePorteAvion();
        }

        public override Torpilleur CreateTorpilleur()
        {
            return new BlueTorpilleur();
        }
    }
}