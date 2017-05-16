using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgorithmObjectManager : MonoBehaviour {

    GameObject AlgorithmObject;
    const int count = 10;
    const int positionScaler = 10;

    public List<Transform> listOfObjects = new List<Transform>();

    void Awake () {
        GenerateObjects();
        RandomizeObjects();
    }

    void GenerateObjects()
    {
        for (int i = 0; i < count; ++i)
        {
            listOfObjects.Add(Instantiate(Resources.Load("AlgorithmObject") as GameObject, transform.position + new Vector3(i * positionScaler, 0, 0), Quaternion.identity, transform).transform);
            listOfObjects[i].gameObject.name = i.ToString();
        }
    }

    public void RandomizeObjects()
    {
        for (int i = 0; i < count; ++i)
        {
            //listOfObjects[i].localScale = Vector3.one + (Vector3.one * Random.value);
            listOfObjects[i].localScale = Vector3.one * Random.value * 10f;
        }
    }
}
