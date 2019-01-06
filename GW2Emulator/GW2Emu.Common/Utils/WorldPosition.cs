using System;

namespace GW2Emu.Common
{
    public struct WorldPosition
    {
        public Vector3 Vector;
        public int W;

        public WorldPosition(Vector3 vector, int w)
        {
            Vector = vector;
            W = w;
        }
    }
}
