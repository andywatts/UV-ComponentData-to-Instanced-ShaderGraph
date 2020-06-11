using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

[GenerateAuthoringComponent]
[MaterialProperty("_height", MaterialPropertyFormat.Float)]
public struct ShaderHeight : IComponentData
{
    public float Value;
}
