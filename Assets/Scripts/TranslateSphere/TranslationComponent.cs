using Unity.Entities;
using UnityEngine;

public struct TranslationComponent : IComponentData
{
    public Vector2 Direction { get; set; }
    public float Speed { get; set; }
}
