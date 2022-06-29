using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericChallenge1 : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    private void Start()
    {
        GenericAddComponent<ShakeableObject>();
        GenericAddComponent<Peg>();
    }

    public void GenericAddComponent<T>() where T : MonoBehaviour
    {
        GameObject newItem = Instantiate(prefab);
        newItem.AddComponent<T>();
        newItem.GetComponent<T>().enabled = false;

        Debug.Log($"Component {typeof(T)} was added to the prefab");
    }
}
