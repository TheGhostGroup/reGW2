using System;

namespace GW2Emu.Common
{
    public class Optional<T> where T : struct
    {
        private bool isPresent;
        private T value;

        public Optional(T value)
        {
            if (IsNullable(value) && value.Equals(default(T)))
            {
                throw new ArgumentNullException("value");
            }

            isPresent = true;
            this.value = value;
        }

        private bool IsNullable(T t) { return false; }
        private bool IsNullable(T? t) { return true; }

        public bool IsPresent
        {
            get
            {
                return isPresent;
            }
        }

        public T Value
        {
            get
            {
                return value;
            }
        }
    }
}
