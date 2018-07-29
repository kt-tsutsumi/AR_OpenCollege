using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class download2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (connect ("http://unipro-school.com/data/ar/0804/img/02"));

	}


	IEnumerator connect(string url)
	{
		WWW www = new WWW(url);
		yield return www;
		RawImage rawImage = GetComponent<RawImage>();
		rawImage.texture = www.textureNonReadable;


	}

}
