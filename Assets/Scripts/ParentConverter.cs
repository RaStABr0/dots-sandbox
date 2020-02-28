using System.Collections.Generic;
using DefaultNamespace;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class ParentConverter : MonoBehaviour, IConvertGameObjectToEntity
{
    [HideInInspector]
    public List<Transform> children = new List<Transform>();
    
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        Debug.Log($"Parent: {gameObject.name} {entity.Index}");
        dstManager.AddComponent<ParentTag>(entity);
        foreach (var child in children)
        {
            var conv = child.gameObject.AddComponent<ChildConverter>();
            conv.parent = entity;
        }
        
    }
}
