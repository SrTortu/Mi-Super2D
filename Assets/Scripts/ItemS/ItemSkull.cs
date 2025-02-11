using UnityEngine;
using System;

public class ItemNose : Item
{

	const float NOSE_DAMAGE = -0.1f;

	#region Unity Callbacks
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Ground")
			Destroy(gameObject);

		if (collision.gameObject.tag == "Player")
		{
			Jetpack jetpack = collision.gameObject.GetComponent<Jetpack>();
			collision.gameObject.GetComponent<Player>().DagameOn();
			jetpack.AddRegRatio(NOSE_DAMAGE);
			Recolected();
		}
	}
	#endregion


}
