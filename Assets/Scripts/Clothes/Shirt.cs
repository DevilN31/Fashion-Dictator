using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shirt : MonoBehaviour {

    SpriteRenderer spriteRenderer;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }
    public void LoadNextShirt(int nextIndex)
    {
        ButtonsManager.instance.playerShirts[nextIndex].spriteRenderer.enabled = true;
        Debug.Log("Shirt number: " + nextIndex + " is enabeld");
        StartCoroutine(ChangeShirt());
    }

    IEnumerator ChangeShirt()
    {
        anim.SetBool("Animate", true);
        yield return new WaitForSeconds(0.2f);
        spriteRenderer.enabled = false;
        anim.SetBool("Animate", false);
        transform.position = Vector3.zero;
    }
}
