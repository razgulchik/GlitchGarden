using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] Attacker attackerPrefab;
    [SerializeField] float minSpawnDealay = 1f;
    [SerializeField] float maxSpawnDealay = 5f;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            SpawnAttacker();
            yield return new WaitForSeconds(Random.Range(minSpawnDealay, maxSpawnDealay));
        }
    }

    private void SpawnAttacker()
    {
        Attacker newAttacker = Instantiate
            (attackerPrefab, transform.position, transform.rotation) 
            as Attacker;
        newAttacker.transform.parent = transform;
    }

}
