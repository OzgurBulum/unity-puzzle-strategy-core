using UnityEngine;

public class PlayerGridMovement : MonoBehaviour
{
    void Update()
    {
        // TODO: Yön belirle
        // W -> yukarı (0,1)
        Vector3 direction = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector3.up;
        }
        // S -> aşağı (0,-1)
        if (Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector3.down;
        }
        // A -> sol (-1,0)
        if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector3.left;
        }
        // D -> sağ (1,0)
        if (Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector3.right;
        }
        // TODO: yön sıfır değilse hedef pozisyonu hesapla
        
        // hedef pozisyon = mevcut pozisyon + yön
        if ( direction != Vector3.zero)
        {
            Vector3 targetPosition = transform.position + direction;
            Collider2D hit = Physics2D.OverlapPoint(targetPosition);

            if (hit == null)
            {
                LevelManager.Instance.SaveState();
                transform.position = targetPosition;
            }
            else if (hit.CompareTag("Box"))
            {
               Vector3 boxTargetPosition = hit.transform.position + direction;
               Collider2D nextCellHit = Physics2D.OverlapPoint(boxTargetPosition);
              
               if (nextCellHit == null)
               {
                  LevelManager.Instance.SaveState();
                  hit.transform.position = boxTargetPosition;
                  transform.position = targetPosition;
               }
            }
        }
    }
}