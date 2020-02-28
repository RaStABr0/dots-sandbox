using System.Collections.Generic;
using System.Linq;
using Unity.Entities;
using Unity.Scenes;
using UnityEngine;

namespace DefaultNamespace
{
    [UpdateBefore(typeof(GameObjectDeclareReferencedObjectsGroup))]
    [WorldSystemFilter(WorldSystemFilterFlags.GameObjectConversion)]
    public class TestConvertSystem : ComponentSystem
    {
        // protected override void OnStartRunning()
        // {
        //     Debug.Log("st");
        //     var gO = GameObject.FindGameObjectWithTag("Player");
        //
        //     var conv = gO.AddComponent<ParentConverter>();
        //     
        //     foreach (Transform child in gO.transform)
        //     {
        //         conv.children.Add(child);
        //         Debug.Log("ch");
        //     }
        //     
        //     gO.transform.DetachChildren();
        // }

        protected override void OnUpdate()
        {
           InitContainer();
        }

        private void InitContainer()
        {
            var containers = GameObject.FindObjectsOfType<ContainerTag>().
                Select(c => c.transform).ToArray();

            foreach (var container in containers)
            {
                Debug.Log(container);
                
                var converter = container.gameObject.AddComponent<ParentConverter>();

                foreach (Transform child in container)
                {
                    converter.children.Add(child);
                    child.SetParent(null);
                }
            }
        }
    }
}