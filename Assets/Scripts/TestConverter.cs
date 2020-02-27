using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Unity.Entities;
using Unity.Physics;
using UnityEngine;

public class TestConverter : MonoBehaviour, IConvertGameObjectToEntity
{
    public int a;

    // private void Awake(n
    // {
    //     Debug.Log("awake");
    // }

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        foreach (Transform child in transform)
        {
            child.gameObject.AddComponent<ChildConverter>();
            child.SetParent(null);
        }
        
        var testTag = new TestTag {a = 3};

        dstManager.AddComponentData(entity, testTag);
    }
}
