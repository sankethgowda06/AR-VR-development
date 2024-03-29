using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Michsky.UI.Frost
{
    public class UIElementSound : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler
    {
        [Header("RESOURCES")]
        public AudioClip hoverSound;
        public AudioClip clickSound;
        [Header("SETTINGS")]
        public bool enableHoverSound = true;
        public bool enableClickSound = true;
        private AudioSource HoverSource { get { return GetComponent<AudioSource>(); } }
        private AudioSource ClickSource { get { return GetComponent<AudioSource>(); } }
        
        void Start()
        {
            gameObject.AddComponent<AudioSource>();
            HoverSource.clip = hoverSound;
            ClickSource.clip = clickSound;

            HoverSource.playOnAwake = false;
            ClickSource.playOnAwake = false;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (enableHoverSound == true)
            {
                HoverSource.PlayOneShot(hoverSound);
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (enableClickSound == true)
            {
                ClickSource.PlayOneShot(clickSound);
            }
        }
    }
}
