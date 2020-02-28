using Unity.Entities;
using UnityEngine;

namespace DefaultNamespace
{
    public class ChildConverter : MonoBehaviour, IConvertGameObjectToEntity
    {
        public Entity parent;
        
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            Debug.Log($"Child: {gameObject.name} {entity.Index} {parent.Index}");
            
            var childTag = new ChildTag {parent = parent};
            dstManager.AddComponentData(entity, childTag);
        }
    }
}