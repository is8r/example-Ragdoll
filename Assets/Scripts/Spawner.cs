using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject original;
    public GameObject exprosion;

    int count = 0;
    int countUp = 30;
    int ragdollMax = 30;
    List<GameObject> clones = new List<GameObject>();

    void Update()
    {
        count++;
        if(count > countUp)
        {
            count = 0;
            GameObject clone = Instantiate(original, transform.position, Random.rotation);
            clones.Add(clone);

            if(clones.Count > ragdollMax)
            {
                Destroy(clones[0]);
                clones.RemoveAt(0);
            }
        }

        if (exprosion.active)
        {
            exprosion.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            exprosion.SetActive(true);
        }
    }
}
