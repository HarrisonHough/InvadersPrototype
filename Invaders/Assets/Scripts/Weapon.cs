using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    [SerializeField]
    private GameObject bullet;
    Transform spawnPoint;
	// Use this for initialization
	void Start () {
		
	}


    public void Fire()
    {
        GameObject projectile = Instantiate(bullet, spawnPoint.position, Quaternion.identity) as GameObject;
        //projectile.get
    }
}
