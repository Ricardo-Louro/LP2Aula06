using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunClip : GunDecorator
    {
        private int ammoExpansion;

        public override int AmmoCapacity =>
            base.AmmoCapacity + ammoExpansion;

        public GunClip(Gun gun, int ammoExpansion) : base(gun)
        {
            this.ammoExpansion = ammoExpansion;
        }
    }
}