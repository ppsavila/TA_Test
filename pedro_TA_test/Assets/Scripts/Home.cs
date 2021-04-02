using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;

public class Home : MonoBehaviour
{
    [SerializeField]
    Transform buttom_parent, title_parent;

    [SerializeField]
    RectTransform logo_rect_BG, logo_rect_Title, logo_rect_Line, logo_rect_Fana, home_button_rect;

    [SerializeField]
    Graphic logo_graphic_BG, logo_graphic_Title, logo_graphic_Line, logo_graphic_Fana, home_button_graphic;

    [SerializeField]
    TextMeshProUGUI contiue_text;

    private void Start()
    {
        Sequence titleSequence = DOTween.Sequence();

        //background
        titleSequence.Join(logo_graphic_BG.DOFade(1f, 1f).SetEase(Ease.InQuint));

        //titulo alpha+scale 
        titleSequence.Append(logo_graphic_Title.DOFade(1f, 1f).SetEase(Ease.InQuint));
        titleSequence.Join(logo_rect_Title.DOScale(1F, 1.3f));

        //fana
        titleSequence.Join(logo_graphic_Fana.DOFade(1f, 1f).SetEase(Ease.InQuint));
        titleSequence.Join(logo_rect_Fana.DOAnchorPosY(352f, 1.3f, true));

        //line
        titleSequence.Join(logo_graphic_Line.DOFade(1f, 1f).SetEase(Ease.InQuint));
        titleSequence.Join(logo_rect_Line.DOAnchorPosY(120f, 1f, true));

        //botao continue
        titleSequence.Append(home_button_graphic.DOFade(1f, 1f).SetEase(Ease.InQuint));
        titleSequence.Join(contiue_text.rectTransform.DOAnchorPosY(1f, .5f, true).From());
        titleSequence.Join(contiue_text.DOFade(1f, 1f).SetEase(Ease.InQuint));
    }

    public void StartGame()
    {
        Sequence startSequence = DOTween.Sequence();

        //background
        startSequence.Join(logo_graphic_BG.DOFade(0f, 1.2f).SetEase(Ease.InQuint));

        //titulo alpha+scale 
        startSequence.Join(logo_graphic_Title.DOFade(0f, 1.3f).SetEase(Ease.InQuint));


        //fana
        startSequence.Join(logo_graphic_Fana.DOFade(0f, 1.3f).SetEase(Ease.InQuint));
        startSequence.Join(logo_rect_Fana.DOAnchorPosY(352f, 1.3f, true));

        //line
        startSequence.Join(logo_graphic_Line.DOFade(0f, 1.3f).SetEase(Ease.InQuint));
        startSequence.Join(logo_rect_Line.DOAnchorPosY(120f, 1.3f, true));

        //botao continue
            //startSequence.Append(buttom_parent.DOScale(new Vector3(0, 0, 0), 1.3f));
        startSequence.Append(home_button_graphic.DOFade(0f, 1.3f).SetEase(Ease.InQuint));

        startSequence.Join(contiue_text.DOFade(0f, 1.3f).SetEase(Ease.InQuint));
        

    }



}
