using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Red
{
   public class RedFactory : Factory
    {
        public override Usine CreateUsine()
        {
            return new RedUsine();
        }
    }
}
