using UnityEngine;
using System.Collections;

public class RandomVelocity : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        //this.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));
        //this.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-3, 3), Random.Range(-3, 3)));
        StartCoroutine(WaitAndPrint());
    }
	
	// Update is called once per frame
	void Update () {
        //StartCoroutine(WaitAndPrint());
        StartCoroutine(WaitAndPrint());
    }

    IEnumerator WaitAndPrint1()
    {
        yield return StartCoroutine("WaitAndPrint");
    }


        IEnumerator WaitAndPrint()
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(2);
        //print("WaitAndPrint " + Time.time);
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100, 100), Random.Range(-5, 5)));
        yield return new WaitForSeconds(2);
        //print("WaitAndPrint " + Time.time);
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100, 10), Random.Range(-5, 15)));
        yield return new WaitForSeconds(2);
        //print("WaitAndPrint " + Time.time);
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-10, 100), Random.Range(-5, 15)));
    }

}
