using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class notoGenerator : MonoBehaviour
{
    [SerializeField] Note notePrefab;
    //noteを生成する
    //Prefab:Instantiate
    private void Start()
    {
        SpawnNote();
    }
    public void SpawnNote()
    {
        // Instantiate(生成したいもの，場所，角度);
        Instantiate(notePrefab, new Vector3(0, 10, 0), Quaternion.identity);
    }
}
