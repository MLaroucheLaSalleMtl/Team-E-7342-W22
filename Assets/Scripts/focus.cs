using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class focus : MonoBehaviour
{
    [SerializeField] private float maxDistance = 20.0f;
    [SerializeField] private LayerMask focusLayer;
    [SerializeField] private PostProcessVolume vol;
    private DepthOfField _DOF;
    const float transitionSpeed = 0.9f;



    // Start is called before the first frame update
    void Start()
    {
        vol.sharedProfile.TryGetSettings<DepthOfField>(out _DOF);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        float pos = maxDistance;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance, focusLayer))
        {
            pos = hit.distance;
        }
        if (_DOF)
        {
            _DOF.focusDistance.value = Mathf.Lerp(_DOF.focusDistance.value, pos, transitionSpeed);
        }
    }
}
