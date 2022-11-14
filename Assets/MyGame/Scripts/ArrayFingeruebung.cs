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
        "1. array4",
        "2. array4",
        "3. array4",
        "4. array4",
        "5. array4",
        "6. array4",
        "7. array4",
        "8. array4",
        "9. array4",
        "10. array4",
    };

    private void Start()
    {
        GameObject[] redImageArray = GameObject.FindGameObjectsWithTag("RedImages");

        Debug.Log(array1[0]);
        Debug.Log(array2[0]);
        Debug.Log(array3[0]);
        Debug.Log(array4[0]);
        Debug.Log(redImageArray[0]);

        Debug.Log(array1[array1.Length - 1]);
        Debug.Log(array2[array2.Length - 1]);
        Debug.Log(array3[array3.Length - 1]);
        Debug.Log(array4[array4.Length - 1]);
        Debug.Log(redImageArray[redImageArray.Length - 1]);

        
        
        for (int i = 0; i < array4.Length; i++)
        {
            Debug.Log("Das Element[" + i + "] hat den string-Wert: " + array4[i]);
        }


        
        string debugText = " ";

        for (int i = 0; i < array2.Length; i++)
        {
            debugText += array2[i] + " ";    
        }
        Debug.Log("Alle Werte von Array2: " + debugText);
    }

}
