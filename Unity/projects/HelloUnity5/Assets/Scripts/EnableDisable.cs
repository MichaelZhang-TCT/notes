using UnityEngine;
using System.Collections;

public class EnableDisable : MonoBehaviour {

    public MeshRenderer meshRenderer;

    public Material material;

	// Use this for initialization
	void Start()
    {
        if (material != null)
        {
            return;
        }

        meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer != null)
        {
            material = meshRenderer.material;
            if (material != null)
            {
                Debug.Log("material not null");
            }
            else
            {
                Debug.LogWarning("material is null!");
            }
        }
	}
	
	// Update is called once per frame
	void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //meshRenderer.enabled = !meshRenderer.enabled;
            if (material != null)
            {
                material.color = new Color(1, 0, 0);
            }
        }
	}
}
