using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Gun : MonoBehaviour {

	public Transform muzzle;
	public Projectile projectile;
	public float fireRate = 100; //100 ms
	public float muzzleVelocity = 35;

	float nextShotTime;

	public void Shoot() {

		if (Time.time > nextShotTime) {
			nextShotTime = Time.time + fireRate / 1000;
			Projectile newProjectile = Instantiate (projectile, muzzle.position, muzzle.rotation) as Projectile;
			newProjectile.SetBulletSpeed (muzzleVelocity);
		}
	
	}
}
