using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pants : MonoBehaviour {

    SpriteRenderer spriteRenderer;
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }
    public void LoadNextPants(int nextIndex)
    {
        ButtonsManager.instance.playerPants[nextIndex].spriteRenderer.enabled = true;
        Debug.Log("Shirt number: " + nextIndex + " is enabeld");
        StartCoroutine(ChangePants());
    }

    IEnumerator ChangePants()
    {
        anim.SetBool("Animate", true);
        yield return new WaitForSeconds(0.2f);
        spriteRenderer.enabled = false;
        anim.SetBool("Animate", false);
        transform.position = Vector3.zero;
    }
}
