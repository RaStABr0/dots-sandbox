using Unity.Entities;
using UnityEngine;

namespace DefaultNamespace
{
    [UpdateBefore(typeof(GameObjectDeclareReferencedObjectsGroup))]
    public class TestConvertSystem : ComponentSystem
    {
        private int count = 2;

        protected override void OnCreate()
        {
            Debug.Log("cr");
            Debug.Log(GameObject.FindGameObjectWithTag("Player"));
        }

        protected override void OnUpdate()
        {
        //     if (count == 2)
        //     {
        //         Debug.Log("up");
        //         //var container = GameObject.Find("Container");
        //         //container.transform.DetachChildren();
        //     }
        //     
        //     if (count == 1)
        //     {
        //         
        //     }
        //     
        //     count--;
        }
    }
}