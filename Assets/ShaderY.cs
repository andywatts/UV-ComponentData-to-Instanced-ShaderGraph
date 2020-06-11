using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

[GenerateAuthoringComponent]
[MaterialProperty("_y", MaterialPropertyFormat.Float)]
public struct ShaderY : IComponentData
{
    public float Value;
}
