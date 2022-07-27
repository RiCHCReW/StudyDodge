using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private Rigidbody m_rigidbody;
  public float m_fMoveSpeed;
  // Start is called before the first frame update
  void Start()
  {
    m_rigidbody = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    if (m_rigidbody != null)
    {       
      Vector3 v3NewVelocity = new Vector3(Input.GetAxisRaw("Horizontal") * m_fMoveSpeed, 0, Input.GetAxisRaw("Vertical") * m_fMoveSpeed);
      m_rigidbody.velocity = v3NewVelocity;
    }
  }
}
