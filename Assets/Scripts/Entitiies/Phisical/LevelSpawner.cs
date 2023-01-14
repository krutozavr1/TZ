using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    [SerializeField]GameObject deathLinePrefab;
    [SerializeField]float minLineLength, maxLineLength, cdForSpawn;

    void Awake()
    {
        GameObject player = Instantiate(Resources.Load<GameObject>("player"), Vector3.zero, Quaternion.identity);
        StartCoroutine(SpawnLinesInfinitely());
    }

    private void SpawnLine()
    {
        Vector3 verticalOffset = new Vector3(0, Random.Range(0, 8f) * Random.Range(0, 2) * 2 - 1);//offset needed so line does not always spawn in centre
        GameObject line = Instantiate(deathLinePrefab, transform.position + verticalOffset, Quaternion.identity);
        line.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 360));
        line.transform.localScale = new Vector3(line.transform.localScale.x, Random.Range(minLineLength, maxLineLength), 1);
        Destroy(line, 10);
    }

    private IEnumerator SpawnLinesInfinitely()
    {
        while(true)
        {
            yield return new WaitForSeconds(cdForSpawn);
            SpawnLine();

        }
    }

    public void SetSpawnCd(float cd)
    {
        cdForSpawn = cd;
    }
}
