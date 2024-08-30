using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject element;

    public Vector3 center;
    public Vector3 size;

    public bool isSpawned;

    // Start is called before the first frame update
    void Start()
    {
        isSpawned = false;
        SpawnElement();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isSpawned == true)
        {
            isSpawned = false;
            SpawnElement();
            Destroy(GameObject.FindWithTag("SpawnedElement"));
            Destroy(GameObject.FindWithTag("SpawnedElement2"));
            Destroy(GameObject.FindWithTag("SpawnedElement3"));
            Destroy(GameObject.FindWithTag("SpawnedElement4"));
            Destroy(GameObject.FindWithTag("SpawnedElement5"));
            Destroy(GameObject.FindWithTag("SpawnedElement6"));
            Destroy(GameObject.FindWithTag("SpawnedElement7"));
            Destroy(GameObject.FindWithTag("SpawnedElement8"));
            Destroy(GameObject.FindWithTag("SpawnedElement9"));
            Destroy(GameObject.FindWithTag("SpawnedElement10"));
            Destroy(GameObject.FindWithTag("Settlement 1"));
            Destroy(GameObject.FindWithTag("Settlement 2"));
            Destroy(GameObject.FindWithTag("Settlement 3"));
            Destroy(GameObject.FindWithTag("Settlement 4"));
            Destroy(GameObject.FindWithTag("Settlement 5"));
        }
    }

    public void SpawnElement()
    {
        if(isSpawned == false)
        {
            isSpawned = true;
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
            Instantiate(element, pos, Quaternion.identity);
        }
        
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
