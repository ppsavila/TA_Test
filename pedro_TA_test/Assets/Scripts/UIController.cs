using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [Header("Home Graphics Elements"), Space(5)]
        [SerializeField] Graphic logo_graphic_BG;
        [SerializeField] Graphic logo_graphic_Title;
        [SerializeField] Graphic logo_graphic_Line;
        [SerializeField] Graphic logo_graphic_Fana;
        [SerializeField] Graphic home_button_graphic;

    [Header("Home Rect Elements"), Space(5)]
        [SerializeField] RectTransform logo_rect_BG;
        [SerializeField] RectTransform logo_rect_Title;
        [SerializeField] RectTransform logo_rect_Line;
        [SerializeField] RectTransform logo_rect_Fana;
        [SerializeField] RectTransform home_button_rect;

    [Header("Home Others Elements"), Space(5)]
        [SerializeField]TextMeshProUGUI contiue_text;
        [SerializeField] Transform buttom_parent;
        [SerializeField] Transform title_parent;
        [SerializeField] GameObject homeParent;

    [Header("Level Graphics Elements"), Space(15)]
        [SerializeField] Graphic levelTitle_graphic_BG;
        [SerializeField] Graphic left_level_select_graphic;
        [SerializeField] Graphic right_level_select_graphic;
        [SerializeField] List<Graphic> levels_buttons = new List<Graphic>();

    [Header("Level Rect Elements"), Space(5)]
        [SerializeField] RectTransform header_rect_BG;
        [SerializeField] RectTransform footer_rect_BG;
        [SerializeField] RectTransform left_level_select_rect;
        [SerializeField] RectTransform right_level_select_rect;
        [SerializeField] RectTransform title_level_select_rect;
        [SerializeField] RectTransform chapter_select_rect;
        [SerializeField] RectTransform header_icon_player_rect;
        [SerializeField] RectTransform header_icon_stamina_rect;
        [SerializeField] RectTransform header_icon_leader_rect;
        [SerializeField] RectTransform header_icon_achiev_rect;
        [SerializeField] RectTransform header_icon_menu_rect;
        [SerializeField] RectTransform footer_icon_home_rect;
        [SerializeField] RectTransform footer_icon_fases_rect;
        [SerializeField] RectTransform footer_icon_social_rect;
        [SerializeField] RectTransform footer_icon_shop_rect;
        [SerializeField] RectTransform header_separator_1;
        [SerializeField] RectTransform header_separator_2;
        [SerializeField] RectTransform header_separator_3;
        [SerializeField] RectTransform header_separator_4;

    [Header("Level Other Elements"), Space(5)]
        [SerializeField] TextMeshProUGUI title_level_select_text;
        [SerializeField] TextMeshProUGUI chapter_select_text;
        [SerializeField] GameObject levelParent;
        [SerializeField] GameObject levelBG;


    void Start()
    {
       HomeStart();
    }


    void HomeStart()
    {
        Sequence titleSequence = DOTween.Sequence();

        //background
        titleSequence.Join(logo_graphic_BG.DOFade(1f, 1f).SetEase(Ease.InQuint));

        //titulo alpha+scale 
        titleSequence.Append(logo_graphic_Title.DOFade(1f, 1f).SetEase(Ease.InQuint));
        titleSequence.Join(logo_rect_Title.DOScale(1F, 1f));

        //fana
        titleSequence.Join(logo_graphic_Fana.DOFade(1f, 1f).SetEase(Ease.InQuint));
        titleSequence.Join(logo_rect_Fana.DOAnchorPosY(352f, 1f, true));

        //line
        titleSequence.Join(logo_graphic_Line.DOFade(1f, 1f).SetEase(Ease.InQuint));
        titleSequence.Join(logo_rect_Line.DOAnchorPosY(120f, 1f, true));

        //botao continue
        titleSequence.Append(home_button_graphic.DOFade(1f, 1f).SetEase(Ease.InQuint));
        titleSequence.Join(contiue_text.rectTransform.DOAnchorPosY(1f, .5f, true).SetEase(Ease.OutBounce));
        titleSequence.Join(contiue_text.DOFade(1f, 1f).SetEase(Ease.InQuint));
    }

    public void HomeEnd()
    {
        Sequence endSequence = DOTween.Sequence();

        //background
        endSequence.Join(logo_graphic_BG.DOFade(0f, 1.2f).SetEase(Ease.InQuint));

        //titulo alpha+scale 
        endSequence.Join(logo_graphic_Title.DOFade(0f, 1.3f).SetEase(Ease.InQuint));


        //fana
        endSequence.Join(logo_graphic_Fana.DOFade(0f, 1.3f).SetEase(Ease.InQuint));
        endSequence.Join(logo_rect_Fana.DOAnchorPosY(352f, 1.3f, true));

        //line
        endSequence.Join(logo_graphic_Line.DOFade(0f, 1.3f).SetEase(Ease.InQuint));
        endSequence.Join(logo_rect_Line.DOAnchorPosY(120f, 1.3f, true));

        //botao continue
        endSequence.Join(home_button_graphic.DOFade(0f, 1.3f).SetEase(Ease.InQuint));

        endSequence.Join(contiue_text.DOFade(0f, 1.3f).SetEase(Ease.InQuint)).OnComplete(LevelStart);

    }

    void LevelStart()
    {
        levelBG.SetActive(true);
        Sequence startSequence = DOTween.Sequence();
        
        //Backgrounds 
        startSequence.Join(header_rect_BG.DOAnchorPosY(569f, 1f, true));
        startSequence.Join(footer_rect_BG.DOAnchorPosY(-575f, 1f, true));

        //Icons
        startSequence.Append(header_icon_player_rect.DOAnchorPosY(-50f, .2f, true).SetEase(Ease.OutBounce));
        startSequence.Join(footer_icon_home_rect.DOAnchorPosY(-567f, .2f, true).SetEase(Ease.OutBounce));
        startSequence.Join(header_separator_1.DOScale(1f, .2f));
        startSequence.Append(header_icon_stamina_rect.DOAnchorPosY(-50f, .2f, true).SetEase(Ease.OutBounce));
        startSequence.Join(footer_icon_fases_rect.DOAnchorPosY(-567f, .2f, true).SetEase(Ease.OutBounce));
        startSequence.Join(header_separator_2.DOScale(1f, .2f));
        startSequence.Append(header_icon_leader_rect.DOAnchorPosY(577f, .2f, true).SetEase(Ease.OutBounce));
        startSequence.Join(footer_icon_social_rect.DOAnchorPosY(-567f, .2f, true).SetEase(Ease.OutBounce));
        startSequence.Join(header_separator_3.DOScale(1f, .2f));
        startSequence.Append(header_icon_achiev_rect.DOAnchorPosY(577f, .2f, true).SetEase(Ease.OutBounce));
        startSequence.Join(footer_icon_shop_rect.DOAnchorPosY(-567f, .2f, true).SetEase(Ease.OutBounce));
        startSequence.Join(header_separator_4.DOScale(1f, .2f));
        startSequence.Append(header_icon_menu_rect.DOAnchorPosY(577f, .2f, true).SetEase(Ease.OutBounce));

        //Titles
        startSequence.Join(levelTitle_graphic_BG.DOFade(1f, 1f).SetEase(Ease.InQuint));
        startSequence.Append(left_level_select_rect.DOAnchorPosX(-302, 1f, true));
        startSequence.Join(right_level_select_rect.DOAnchorPosX(314, 1f, true));
        startSequence.Join(left_level_select_graphic.DOFade(1f, .5f).SetEase(Ease.InQuint));
        startSequence.Join(right_level_select_graphic.DOFade(1f, .5f).SetEase(Ease.InQuint));
        startSequence.Join(right_level_select_graphic.DOFade(1f, .5f).SetEase(Ease.InQuint));

        startSequence.Join(title_level_select_text.DOFade(1f, 1f).SetEase(Ease.InQuint));
        startSequence.Join(title_level_select_rect.DOAnchorPosY(334.92f, .5f, true));

        startSequence.Join(chapter_select_text.DOFade(1f, 1f).SetEase(Ease.InQuint));
        startSequence.Join(chapter_select_rect.DOAnchorPosY(376.8f, .5f, true));
        
        //Buttons levels
        foreach (Graphic levelB in levels_buttons)
        {
            startSequence.Join(levelB.DOFade(1f, .1f).SetEase(Ease.InQuint));
            startSequence.Join(levelB.rectTransform.DOScale(1F, .7f));
            startSequence.Join(levelB.GetComponentInChildren<TextMeshProUGUI>().DOFade(1f, .5f).SetEase(Ease.InQuint));

        }

    }


}
