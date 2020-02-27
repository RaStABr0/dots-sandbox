using Unity.Entities;
using Unity.Jobs;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

public class TranslationSystem : JobComponentSystem
{
    private struct TranslateJob : IJobForEach<PhysicsVelocity, TranslationComponent, Translation>
    {
        public void Execute(ref PhysicsVelocity velocity, ref TranslationComponent translationComponent, ref Translation translation)
        {
            Entity a = default;
            Debug.Log(a);
            velocity.Linear.y = translationComponent.Direction.y * translationComponent.Speed;
        }
    }

    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
       
        var job = new TranslateJob();
        return job.Schedule(this, inputDeps);
    }


    //protected override void OnUpdate()
    //{
    //    Entities.ForEach((ref PhysicsVelocity velocity, ref TranslationComponent translationComponent,
    //        ref Translation translation) =>
    //    {
    //        velocity.Linear.y = translationComponent.Direction.y * translationComponent.Speed;
    //    });
    //}
}
