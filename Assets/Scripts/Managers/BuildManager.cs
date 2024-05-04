using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    private GameObject towerToBuild;
    public static BuildManager instance;

    public GameObject getTowerBuild(){
        return towerToBuild;
    }

    void Awake(){
        instance = this;
    }
}
