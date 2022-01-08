using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionGenerator : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 40; // Z pozicija kam se postavi prvi generirani section
    public bool creatingSection = false;
    public int secNum;

    IEnumerator GenerateSection(){
        //secNum = 0; //ko je vec kot 1 section -> Random.Range(0, stevilo_sectionov);

        //secNum = 0;
        secNum = Random.Range(0, 4);
        
        Debug.Log(section.Length);
        Instantiate(section[secNum], new Vector3(0,0,zPos), Quaternion.identity);
        
        zPos += 40; //+Z pozicija kam se postavi vsaki naslednji generirani section
        yield return new WaitForSeconds(5);
        creatingSection = false;
    }

    // Update is called once per frame
    void Update(){
        if(creatingSection == false){
        creatingSection = true;
        StartCoroutine(GenerateSection());
        }
    }

    void Start(){
        section = new GameObject[4];
        section[0] = GameObject.Find("Section1");
        section[1] = GameObject.Find("Section2");
        section[2] = GameObject.Find("Section3");
        section[3] = GameObject.Find("Section4");
    }

}
