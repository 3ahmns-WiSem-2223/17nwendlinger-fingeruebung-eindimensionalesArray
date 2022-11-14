using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayFingeruebung : MonoBehaviour
{
    int[] array;

    int[] array1 = new int[4];
    int[] array2 = new int[] { 21, 22, 23, 24 };
    int[] array3 = { 31, 32, 33, 34, 35, 36, 37 };
    string[] array4 = new[]
    {
        "array4",
        "array4",
        "array4",
        "array4",
        "array4",
        "array4",
        "array4",
        "array4",
        "array4",
        "array4",
    };

    private void Start()
    {
        GameObject[] redImageArray = GameObject.FindGameObjectsWithTag("RedImages");
    }
    
}
