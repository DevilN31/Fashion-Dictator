using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat : Clothes
{
    SpriteRenderer spriteRenderer;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }
	public void LoadNextHat(int nextIndex)
    {
        ButtonsManager.instance.playerHats[nextIndex].spriteRenderer.enabled = true;
        Debug.Log("Hat number: " + nextIndex + " is enabeld");
        StartCoroutine(ChangeHat());
    }

    IEnumerator ChangeHat()
    {
        anim.SetBool("Animate", true);
        yield return new WaitForSeconds(0.2f);
        spriteRenderer.enabled = false;
        anim.SetBool("Animate", false);
        transform.position = Vector3.zero;
    }
}
