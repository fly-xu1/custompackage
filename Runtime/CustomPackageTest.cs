using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomPackageTest : MonoBehaviour
{
    public void Spawn()
    {
       int i =  Random.Range(0,10);
       GameObject obj = new GameObject();
       obj.name = $"{i}";
    }
}
