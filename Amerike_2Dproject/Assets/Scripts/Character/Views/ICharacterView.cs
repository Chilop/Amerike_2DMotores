using UnityEngine;

namespace Character
{
    public interface ICharacterView
    {
        SpriteRenderer SpriteRenderer { get; }
        Rigidbody2D Rigidbody2D { get; }
        Transform Transform { get; }
        bool FlipSprite { get; set; }
        
        Vector2 Direction { get;}

        void JumpButtonDown();
        
        int MoveState { set; }
    }
}