using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunDecorator : Gun
    {
        private Gun gun;

        public override int AmmoCapacity => gun.AmmoCapacity;
        public override float NoiseLevel => gun.NoiseLevel;

        public GunDecorator(Gun gun)
        {
            this.gun = gun;
        }        
    }
}