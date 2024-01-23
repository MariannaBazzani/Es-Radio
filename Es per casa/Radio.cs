using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_per_casa
{
    internal class Radio
    {
        private float volume;
        public float Volume 
        { 
            get { return volume; } 
            set { volume = value; } 
        }

        public void AumentaVolume()
        {
            volume *= 1.1f;
        }

        public void DiminuisciVolume()
        {
            volume *= 0.9f;
        }
    }
}
