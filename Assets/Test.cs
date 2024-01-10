using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private GameObject[] myArray;

    [SerializeField]
    private List<int> myList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        myList.Add(4);
        myList.Add(7);
        myList.Add(8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
