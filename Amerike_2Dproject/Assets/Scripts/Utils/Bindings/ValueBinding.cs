using System;
using UnityEngine;
using UnityEngine.Events;

namespace Utils.Bindings
{
    [Serializable]
    public abstract class ValueBinding<T> : UnityEvent<T>
    {
        [SerializeField] protected Animator animator;
        [SerializeField] protected string parameterName;
        
        
        protected T value;
        
        public abstract T Value { get; set; }
    }
}