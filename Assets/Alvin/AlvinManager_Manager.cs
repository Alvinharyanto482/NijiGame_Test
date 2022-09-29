using I2.Loc;
using SIDGIN.Patcher.Unity;
using UnityEngine;

public class AlvinManager_Manager : MonoBehaviour
{
    public static AlvinManager_Manager instance;
    public UIText_GameObject m_TextScript;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        loader = GetComponent<SGPatcherLoader>();
    }

    #region LANGUAGE

    string m_LanguageString;
    public enum Language
    {
        ENGLISH = 0,
        FRENCH = 1,
        ARABIC = 2,
        RUSSIA = 3   
    };

    public Language e_LanguageSelect;
    //ganti languagenya dengan pilihan dari enum yang tersedia
    public void f_SettingLanguage(Language p_Language)
    {
        
        if (p_Language == Language.ENGLISH)
        {
            m_LanguageString = "English";
        }else if (p_Language == Language.FRENCH)
        {
            m_LanguageString = "French";
        }
        else if (p_Language == Language.RUSSIA)
        {
            m_LanguageString = "Russian";
        }
        else
        {
            m_LanguageString = "Arabic";
        }

        if (LocalizationManager.HasLanguage(m_LanguageString))
        {
            LocalizationManager.CurrentLanguage = m_LanguageString;

        }

        
    }
    #endregion  

    #region SG_PATCHER

    SGPatcherLoader loader;

    //untuk load game dari SG patcher
    public void f_LoadGame()
    {
        loader.LoadGame();
    }
    //untuk install package yang akan digunakan menggunakan paramater yang diperlukan
    public void f_IntallPackage(string p_PackageName)
    {
        loader.InstallPackage(p_PackageName);
    }

    //untuk meng-update game jika sudah berganti version dari 1 ke 2
    public void f_UpdateGame()
    {
        loader.UpdateGame();
    }
    #endregion

}