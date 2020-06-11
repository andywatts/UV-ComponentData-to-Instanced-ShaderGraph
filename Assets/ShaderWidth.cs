using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

[GenerateAuthoringComponent]
[MaterialProperty("_width", MaterialPropertyFormat.Float)]
public struct ShaderWidth : IComponentData
{
    public float Value;
}
