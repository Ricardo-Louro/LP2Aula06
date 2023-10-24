using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class MachineGun : Gun
    {
        public override int AmmoCapacity => 100;
        public override float NoiseLevel => 60f;
    }
}