using Unity.Entities;
using UnityEngine;

namespace DefaultNamespace
{
    public class ChildConverter : MonoBehaviour, IConvertGameObjectToEntity
    {
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            //transform.parent = null;
            dstManager.AddComponent<ChildTag>(entity);
        }
    }
}