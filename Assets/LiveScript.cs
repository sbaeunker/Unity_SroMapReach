using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveScript : MonoBehaviour {
    private float initializationTime;
    public float mountSpeed = 0.05f;
    private float multi;
    void Start()
    {
        initializationTime = Time.timeSinceLevelLoad;
        mountSpeed = 0.05f;     
        InputField msEntry = Resources.FindObjectsOfTypeAll<InputField>()[0];
        try
        {
            multi = float.Parse(msEntry.text);
        }catch(System.Exception e)
        {
            multi = 1;
        }
    }
    void Update()
    {
        float timeSinceInitialization = Time.timeSinceLevelLoad - initializationTime;
        this.gameObject.transform.localScale = timeSinceInitialization * multi * mountSpeed * new Vector3(1f, 0.001f, 1f);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Destroy(this.gameObject);
        }
    }
}
