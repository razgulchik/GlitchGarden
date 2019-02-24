using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] Attacker[] attackerPrefabArray;
    [SerializeField] float minSpawnDealay = 1f;
    [SerializeField] float maxSpawnDealay = 5f;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDealay, maxSpawnDealay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        var attackerIndex = Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerIndex]);
    }

    private void Spawn(Attacker choosedAttacker)
    {
        Attacker newAttacker = Instantiate
                    (choosedAttacker, transform.position, transform.rotation)
                    as Attacker;
        newAttacker.transform.parent = transform;
    }
}
