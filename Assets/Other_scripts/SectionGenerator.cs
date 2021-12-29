using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionGenerator : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 40; // Z pozicija kam se postavi prvi generirani section
    public bool creatingSection = false;
    public int secNum;
    public int stevilo_sectionov = 1; //ena manj kot jih dejansko je

    IEnumerator GenerateSection(){
        secNum = 1; //ko je vec kot 1 section -> Random.Range(0, stevilo_sectionov);

        //secNum = Random.Range(0, stevilo_sectionov);

        Instantiate(section[secNum], new Vector3(0,0,zPos), Quaternion.identity);
        zPos += 40; //+Z pozicija kam se postavi vsaki naslednji generirani section
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }

    // Update is called once per frame
    void Update(){
        if(creatingSection == false){
        creatingSection = true;
        StartCoroutine(GenerateSection());
        }
    }
}
