using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class notoGenerator : MonoBehaviour
{
    [SerializeField] Note notePrefab;
    //note�𐶐�����
    //Prefab:Instantiate
    private void Start()
    {
        SpawnNote();
    }
    public void SpawnNote()
    {
        // Instantiate(�������������́C�ꏊ�C�p�x);
        Instantiate(notePrefab, new Vector3(0, 10, 0), Quaternion.identity);
    }
}
