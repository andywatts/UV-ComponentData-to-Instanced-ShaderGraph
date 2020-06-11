using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

[GenerateAuthoringComponent]
[MaterialProperty("_x", MaterialPropertyFormat.Float)]
public struct ShaderX : IComponentData
{
    public float Value;
}
