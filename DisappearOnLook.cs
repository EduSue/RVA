using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnLook : MonoBehaviour
{
    public float lookDuration = 3f;
    private float lookTimer = 0f;
    private bool isLookingAtObject = false;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && hit.transform.CompareTag("Desaparecer"))
        {
            isLookingAtObject = true;
            lookTimer += Time.deltaTime;

            if (lookTimer >= lookDuration)
            {
                Destroy(hit.transform.gameObject);
            }
        }
        else
        {
            isLookingAtObject = false;
            lookTimer = 0f;
        }
    }
}
