using System;

namespace Utils.Bindings
{
    [Serializable]
    public class IntBinding : ValueBinding<int>
    {
        public override int Value
        {
            get => value;
            set
            {
                this.value = value;
                if (animator != null && parameterName != null)
                {
                    animator.SetInteger(parameterName, value);
                }
            }
        }
    }
}