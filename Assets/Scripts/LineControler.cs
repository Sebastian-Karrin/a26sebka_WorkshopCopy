using UnityEngine;

public class LineControler : MonoBehaviour
{
    
    private LineRenderer lineRenderer;

    [SerializeField] private Transform[] marbleTransforms;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        
        lineRenderer.positionCount = marbleTransforms.Length;
        for (int i = 0; i < marbleTransforms.Length; i++)
        {
            lineRenderer.SetPosition(i, marbleTransforms[i].position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
