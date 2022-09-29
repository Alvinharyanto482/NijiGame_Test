using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using I2.Loc;
public class UIText_GameObject : MonoBehaviour
{
    public TextMeshProUGUI m_Text;
    public Button[] m_Button;
    string m_String = "Term1";


    private void Start()
    {
        m_Button[0].onClick.AddListener(() => ClickButton(0));
        m_Button[1].onClick.AddListener(() => ClickButton(1));
        m_Button[2].onClick.AddListener(() => ClickButton(2));
    }
    
    void ClickButton(int p_Int)
    {
        if (p_Int == 0)
        {
            AlvinManager_Manager.instance.f_SettingLanguage(AlvinManager_Manager.Language.ENGLISH);
           
        }
        else if (p_Int == 1)
        {
            AlvinManager_Manager.instance.f_SettingLanguage(AlvinManager_Manager.Language.FRENCH);
        }
        else
        {
            AlvinManager_Manager.instance.f_SettingLanguage(AlvinManager_Manager.Language.RUSSIA);

        }
        m_Text.text = LocalizationManager.GetTranslation(m_String);
    }
}
