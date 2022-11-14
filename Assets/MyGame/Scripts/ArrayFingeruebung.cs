using UnityEngine;
using UnityEngine.UI;

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


        array1[3] = 3;
        Debug.Log(array1[3]);

        array2[2] = 203;
        Debug.Log(array2[2]);

        array3[5] = 333;
        Debug.Log(array3[5]);

        array4[2] = "heute";
        Debug.Log(array4[2]);

        redImageArray[2].GetComponent<Image>().color = new Color32(0, 137, 0, 255);


        int[] array5 = new int[51];
        for (int i = 0; i < array5.Length; i++)
        {
            if (i % 2 == 0)
            {
                array5[i] = i + 20;
            }

        }

        int[] array6 = new int[501];
        for (int i = 0; i < array6.Length; i++)
        {
            if (i % 2 == 0)
            {
                array6[i] = i;
            }

        }

        int[] array7 = new int[501];
        for (int i = 0; i < array7.Length; i++)
        {
            if (i % 2 == 1)
            {
                array7[i] = i;
            }

        }

        string[] array8 = new string[101];
        for (int i = 0; i < array8.Length; i++)
        {
            if (i % 2 == 0)
            {
                array8[i] = "a";
            }

            else if (i % 2 == 1)
            {
                array8[i] = "b";
            }
        }

        int[] array9 = new int[1001];
        for (int i = 0; i < array9.Length; i++)
        {
            array9[i] = Random.Range(0, 1000);
            Debug.Log(array9[i]);
        }

        System.Array.Sort(array9);

        for (int i = 0; i < array9.Length; i++)
        { 
            Debug.Log(array9[i]);
        }

        /*int[] array10 = new[]*/

        /*int[] array10 = new int[array5.Length + array6.Length + 10];
        array5.CopyTo(array10, 0);
        array6.CopyTo(array10, array6.Length);

        for (int i = 0; i < array10.Length; i++)
        {
            Debug.Log(array10[i]);
        }*/

        int[] array11 = new int[1001];
        for (int i = 0; i < array11.Length; i++)
        {
            array11[i] = Random.Range(0, 1000);
            Debug.Log(array9[i]);
        }

        System.Array.Sort(array11);

        Debug.Log(array11[0] + " und " + array11[array11.Length - 1]);



        int[] array12 = new int[1001];
        for (int i = 0; i < array12.Length; i++)
        {
            array12[i] = Random.Range(0, 1000);
        }

        int randomNumber = Random.Range(0, 1000);

        Debug.Log(System.Array.IndexOf(array12, randomNumber));
    }

}
