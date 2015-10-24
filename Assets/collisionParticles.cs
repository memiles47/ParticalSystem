using UnityEngine;
using System.Collections;

public class collisionParticles : MonoBehaviour {

void OnParticleCollision(GameObject other)
	{
		Destroy (other.gameObject);
	}

}
