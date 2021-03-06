﻿using System.Linq;
using Unity.Entities;
using UnityEngine;

namespace DefaultNamespace
{
    [UpdateBefore(typeof(GameObjectDeclareReferencedObjectsGroup))]
    [WorldSystemFilter(WorldSystemFilterFlags.GameObjectConversion)]
    public class TestConvertSystem : ComponentSystem
    {
        protected override void OnUpdate()
        {
           InitContainers();
        }

        private void InitContainers()
        {
            var containers = GameObject.FindObjectsOfType<ContainerTag>().
                Select(c => c.transform).ToArray();

            foreach (Transform container in containers)
            {
                InitContainer(container);
            }
        }

        private void InitContainer(Transform container)
        {
            var converter = container.gameObject.AddComponent<ParentConverter>();

            foreach (Transform child in container)
            {
                converter.children.Add(child);

                if (child.childCount > 0)
                {
                    InitContainer(child);
                }
            }
            
            container.DetachChildren();
        }
    }
}