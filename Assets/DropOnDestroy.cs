using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOnDestroy : MonoBehaviour
{
    [SerializeField] GameObject healthhPickup;
    [SerializeField][Range(0f, 1f)] float chance = 1f;

    private void OnDestroy()
    {

        if (Random.value < chance)
        {
            Transform t = Instantiate(healthhPickup).transform;
            t.position = transform.position;
        }

    }
}
