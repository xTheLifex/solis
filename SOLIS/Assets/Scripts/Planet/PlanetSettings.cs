﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class PlanetSettings : ScriptableObject
{
    public int planetSeed;
    public float planetFeatureSize;
    public Color terrainColor;
    public Color waterColor;

    public GameObject tree;
    public GameObject bush;
    public Color treeLeafColor, treeBaseColor;
    public Color bushColor;
}
