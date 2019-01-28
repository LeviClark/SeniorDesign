using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GunController : MonoBehaviour {

	public Transform weaponHold;
	public Gun startingGun;
	Gun equippedGun;

	void Start(){
		if (startingGun != null) {
			EquipGun(startingGun);
		}
		weaponHold = GameObject.Find ("Weapon Hold").transform;
	}

	public void EquipGun(Gun gunToEquip){
		if (equippedGun != null) {
			Destroy (equippedGun.gameObject);
		}

		equippedGun = Instantiate (gunToEquip, weaponHold.position, weaponHold.rotation) as Gun;
		equippedGun.transform.parent = weaponHold;
	}

	public void Shoot(){
		if (equippedGun != null) {
			equippedGun.Shoot ();
		}
	}
}
