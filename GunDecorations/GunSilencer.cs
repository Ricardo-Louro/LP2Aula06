using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunSilencer : GunDecorator
    {
        private float suppressionPercent;

        public override float NoiseLevel =>
            base.NoiseLevel * (1- suppressionPercent);

        public GunSilencer(Gun gun, float suppressionPercent) : base(gun)
        {
            if (suppressionPercent < 0 || suppressionPercent > 1)
            {
                throw new ArgumentOutOfRangeException("Invalid suppression!!!");
            }
            this.suppressionPercent = suppressionPercent;
        }
    }
}