using Unity.Entities;
using UnityEngine;

namespace DefaultNamespace
{
    public class ChildConverter : MonoBehaviour, IConvertGameObjectToEntity
    {
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            transform.parent = null;
            //dstManager.AddComponent<TestTag2>(entity);
            
            conversionSystem.PostUpdateCommands.AddComponent<TestTag2>(entity);
        }
    }
}