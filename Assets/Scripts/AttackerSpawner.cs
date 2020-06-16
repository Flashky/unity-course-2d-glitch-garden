using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    // Que necesito para spawnear un enemigo:
    // - Un modelo (prefab) que usar para hacer Instanciate
    // - Algunos atributos para definir: cuantos enemigos quiero que spawneen, a que ratio o velocidad...

    // Posibles ideas:
    // - ScriptableObject para obtener los datos de la oleada.

    // Configuration parameters
    [SerializeField] Attacker attackerPrefab;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;

    
    bool spawn = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while(spawn) {
            
            float spawnDelay = UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay);
            yield return new WaitForSeconds(spawnDelay);

            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
