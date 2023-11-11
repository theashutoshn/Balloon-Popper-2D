using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _ballonPrefab;

    private bool _stopSpawning;
    void Start()
    {
        StartCoroutine(BalloonSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator BalloonSpawner()
    {
        while(_stopSpawning == false)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-8.38f, 8.38f), -6.4f, 0);
            Instantiate(_ballonPrefab, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
