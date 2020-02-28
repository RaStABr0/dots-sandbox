using DefaultNamespace;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class TestConverter : MonoBehaviour, IConvertGameObjectToEntity
{
    private void Awake()
    {
        Debug.Log("Aw");
        Debug.Log(GameObject.FindGameObjectWithTag("Player"));

        foreach (Transform child in transform)
        {
            child.gameObject.AddComponent<ChildConverter>();
            child.SetParent(null);
        }   
    }

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        //dstManager.RemoveComponent<Parent>()
        //var testTag = new ParentTag {a = 3};

        dstManager.AddComponent<ParentTag>(entity);
    }
}
