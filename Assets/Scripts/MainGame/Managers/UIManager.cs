using TMPro;
using UnityEngine;
// removed unnesscerys uisings 

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI hpText;
    
    [SerializeField] private PlayerCharacterController bobby;
    [SerializeField] private SkillButtonUI[] skillsButtonUI; // -


    public void RefreshHPText(int newHP)
    {
        hpText.text = newHP.ToString();
    }

    private void Awake()
    {
        bobby.onTakeDamageEventAction += RefreshHPText;
    }

    private void Start()
    {
        hpText.text = bobby.Hp.ToString();

        // got rid of get componets + moved to start 
        for (int i = 0; i < skillsButtonUI.Length; i++)
        {
            skillsButtonUI[i].skillIcon.sprite = skillsButtonUI[i].skillIcons[i];
            skillsButtonUI[i].skillNameText.text = "Skill " + (i + 1);
        }
    }

    //skillsHolder = GameObject.Find("Skills Group");  - Not Relevent coz skill buttons Ui are SerializeField
    //GameObject[] skillsButtonUI = skillsHolder.GetComponentsInChildren<GameObject>(); - chanegd to SerializeField
    // removed update to reduce callbacks
}
