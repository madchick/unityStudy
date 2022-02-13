using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    public Rigidbody2D rigid;

    public AudioSource audioSource;
    public AudioClip clip;

    public float jumpHeight;
    int jumpCount = 0;
    int limitJumpCount = 2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (jumpCount < limitJumpCount)
            {
                jumpCount = jumpCount + 1;
                rigid.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            jumpCount = 0;
        }
        else if (collision.gameObject.tag == "enemy")
        {
            EnemySaurus enemy = collision.gameObject.GetComponent<EnemySaurus>();
            enemy.OnDamage();
            rigid.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);

            audioSource.volume = SoundManager.I.effectVolume;
            audioSource.clip = clip;
            audioSource.Play();
        }
    }
}



