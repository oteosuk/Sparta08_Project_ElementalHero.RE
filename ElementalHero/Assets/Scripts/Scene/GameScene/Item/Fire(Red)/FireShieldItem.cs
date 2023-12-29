using UnityEngine;

public class FireShieldItem : Item
{
    public GameObject skill;
    
    void Update()
    {
        //sizeBounceEffect();
    }
    
    public override void Use(GameObject target)
    {
        AudioManager.instance.PlaySFX("FireShieldSkill");
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, 0);

        Instantiate(skill, newPos, Quaternion.identity);

        Destroy(gameObject);
    }
}
