using System;

namespace GW2Emu.Common
{
    public struct Vector4
    {
        private float x;
        private float y;
        private float z;
        private float w;

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public float X
        {
            get
            {
                return x;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }
        }

        public float Z
        {
            get
            {
                return z;
            }
        }

        public float W
        {
            get
            {
                return w;
            }
        }
    }
}
