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
        // ���_�J���[�� Color32 �ŊǗ�����Ă���̂ŕϊ�
        Color32 baseColor = component.color;

        var cc = textInfo.characterCount;
        // �܂��͑S�����\����
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

            // ���݂̕����� Material �� ���_ �̈ʒu���擾
            var materialIndex = characterInfo.materialReferenceIndex;
            var vertexIndex = characterInfo.vertexIndex;

            var colors = textInfo.meshInfo[materialIndex].colors32;
            baseColor.a = alpha;
            for (var i = 0; i < 4; i++)
            {
                colors[vertexIndex + i] = baseColor;
            }

            // Mesh �� Color ���ύX���ꂽ�ʒm
            component.UpdateVertexData(TMP_VertexDataUpdateFlags.Colors32);
        }
    }
}