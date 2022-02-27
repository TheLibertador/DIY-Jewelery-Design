using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadChar : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawnPoint;
    public TMP_Text label;
    
    [SerializeField] private GameObject necklaceInScene;

    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab = characterPrefabs[selectedCharacter];
        var necklaceObj = characterPrefabs[selectedCharacter].GetComponentInChildren<MeshRenderer>().material;

        Debug.Log(necklaceObj);
        

        var necklaceMat = necklaceInScene.GetComponentInChildren<SkinnedMeshRenderer>();
        necklaceMat.materials[0] = necklaceObj;
        necklaceMat.materials[1] = necklaceObj;
       
    }


}