using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class SanityBar : MonoBehaviour
    {
        public Image fillImage;

        // value debe ir entre 0 y 1
        public void ActualizarBarra(float value)
        {
            fillImage.fillAmount = value;
        }
    }
}
