using System.Collections;
using System.Collections.Generic;
using Unity.Entities;

public class AnimateUVs : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref ShaderWidth width, ref ShaderHeight height) =>
            {
                // color.Value = new float4( math.cos(t.Value + 1.0f), math.cos(t.Value + 2.0f), math.cos(t.Value + 3.0f), 1.0f);
            })
            .Schedule();
    }
}