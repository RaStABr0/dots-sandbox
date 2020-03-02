using Unity.Entities;

namespace DefaultNamespace
{
    public struct ChildTag : IComponentData
    {
        public Entity parent;
    }
}