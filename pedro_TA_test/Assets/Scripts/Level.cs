using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField]
    RectTransform header_rect_BG, footer_rect_BG, left_level_select_rect, right_level_select_rect, title_level_select_rect,
        chapter_select_rect, header_icon_player_rect, header_icon_stamina_rect, header_icon_leader_rect, header_icon_achiev_rect, header_icon_menu_rect,
        footer_icon_home_rect, footer_icon_fases_rect, footer_icon_social_rect, footer_icon_shop_rect, 
        header_separator_1, header_separator_2, header_separator_3, header_separator_4;

    [SerializeField]
    List<Graphic> levels_buttons = new List<Graphic>();

    [SerializeField]
    Graphic levelTitle_graphic_BG, left_level_select_graphic, right_level_select_graphic;

    [SerializeField]
    TextMeshProUGUI title_level_select_text, chapter_select_text;

    private void Start()
    {
        Sequence startSequence = DOTween.Sequence();

        startSequence.Join(header_rect_BG.DOAnchorPosY(569f, 1f, true));
        startSequence.Join(footer_rect_BG.DOAnchorPosY(-575f, 1f, true));


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


        foreach (Graphic levelB in levels_buttons)
        {
            startSequence.Join(levelB.DOFade(1f, .1f).SetEase(Ease.InQuint));
            startSequence.Join(levelB.rectTransform.DOScale(1F, .7f));
        }



       


    }




}
