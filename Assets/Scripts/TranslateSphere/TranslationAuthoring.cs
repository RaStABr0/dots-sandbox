using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

public class TranslationAuthoring : MonoBehaviour, IConvertGameObjectToEntity
{
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddComponentData(entity, new PhysicsVelocity());
        dstManager.AddComponentData(entity, new TranslationComponent
        {
            Direction = Vector2.up,
            Speed = 2f
        });
    }
}
