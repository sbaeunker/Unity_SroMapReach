using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachIstantiate : MonoBehaviour {
    public GameObject ReachPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

            if (hit)
            {
                Instantiate(ReachPrefab, new Vector3(hit.point.x, hit.point.y, 0f), new Quaternion(0.7071068f, 0f, 0f, 0.7071068f));
            }
        }

    }
}
