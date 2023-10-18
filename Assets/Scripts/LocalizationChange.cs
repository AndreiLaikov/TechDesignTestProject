using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocalizationChange : MonoBehaviour
{
    public int LocalizationIndex = 0;

    [ContextMenu("ChangeLocal")]
    public void Change()
    {
        LocalizationIndex++;
        if (LocalizationIndex >= 3)
        {
            LocalizationIndex = 0;
        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[LocalizationIndex];
    }
}
