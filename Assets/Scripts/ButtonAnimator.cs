using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonAnimator : MonoBehaviour
{
    public Button Text;
    public AudioClip sound;
    public Animator beakerAnim;
    public Canvas yourcanvas;



    void Start()
    {
        Text = Text.GetComponent<Button>();
        beakerAnim.enabled = false;
        yourcanvas.enabled = true;
    }


    public void Press()

    {
        Text.enabled = true;
        AudioSource.PlayClipAtPoint(sound, transform.position);
        beakerAnim.enabled = true;
        Destroy(Text, 1);
        yourcanvas.enabled = false;

    }
}