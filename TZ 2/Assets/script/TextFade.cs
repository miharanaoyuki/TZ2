using System.Collections;
using TMPro;
using UnityEngine;
[RequireComponent(typeof(TextMeshProUGUI))]
public class TextFade : MonoBehaviour
{
    [SerializeField]
    private float _interval = 0.5f;

    private IEnumerator Start()
    {
        var component = GetComponent<TMP_Text>();

        component.ForceMeshUpdate();

        var textInfo = component.textInfo;
        // 頂点カラーは Color32 で管理されているので変換
        Color32 baseColor = component.color;

        var cc = textInfo.characterCount;
        // まずは全部を非表示に
        for (var i = 0; i < cc; i++)
        {
            ChangeColor(i, 0);
        }

        for (var i = 0; i < cc; i++)
        {
            for (var alpha = 0; alpha <= 255; alpha++)
            {
                ChangeColor(i, (byte)alpha);
                yield return new WaitForSeconds(_interval / 255f);
            }
        }
        void ChangeColor(int index, byte alpha)
        {
            var characterInfo = textInfo.characterInfo[index];

            if (!characterInfo.isVisible)
                return;

            // 現在の文字の Material と 頂点 の位置を取得
            var materialIndex = characterInfo.materialReferenceIndex;
            var vertexIndex = characterInfo.vertexIndex;

            var colors = textInfo.meshInfo[materialIndex].colors32;
            baseColor.a = alpha;
            for (var i = 0; i < 4; i++)
            {
                colors[vertexIndex + i] = baseColor;
            }

            // Mesh に Color が変更された通知
            component.UpdateVertexData(TMP_VertexDataUpdateFlags.Colors32);
        }
    }
}