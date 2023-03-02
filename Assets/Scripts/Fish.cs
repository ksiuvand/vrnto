using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fish : MonoBehaviour
{
    [SerializeField] private GameObject _fish;
    float RandX;
    public float delay = 5f;
    float nextTimeToSpawn;
    Vector3 whereToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        nextTimeToSpawn = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTimeToSpawn)
        {
            nextTimeToSpawn = Time.time + delay;
            RandX = Random.Range(2.459005f, 8.96f);
            whereToSpawn = new Vector3(RandX, -1, 5.12f);
            GameObject go = Instantiate(_fish, whereToSpawn, Quaternion.identity);
            Destroy(_fish, 10);
        }
    }
}
