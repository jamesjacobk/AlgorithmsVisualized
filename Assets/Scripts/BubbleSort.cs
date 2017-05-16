using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    List<Transform> listOfObjects;

    void Awake()
    {
        listOfObjects = gameObject.GetComponent<AlgorithmObjectManager>().listOfObjects;
    }

	public void Sort()
    {
        for (int i = listOfObjects.Count - 1; i >= -1; --i)
        {
            for (int j = 0; j < i; ++j)
            {
                if (listOfObjects[j].localScale.x > listOfObjects[j + 1].localScale.x)
                {
                    Debug.Log("Swapping...");
                    swapInList(j);
                    swapVisually(j);
                }
            }
        }
    }

    void swapInList(int index)
    {
        var temp = listOfObjects[index + 1];
        listOfObjects[index + 1] = listOfObjects[index];
        listOfObjects[index] = temp;
    }

    void swapVisually(int index)
    {
        var temp = listOfObjects[index + 1].position;
        listOfObjects[index + 1].position = listOfObjects[index].position;
        listOfObjects[index].position = temp;
    }
}
