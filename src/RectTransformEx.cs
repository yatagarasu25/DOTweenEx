using DG.Tweening;
using MathEx;
using UnityEngine;



namespace DOTweenEx
{
	public static class RectTransformEx
	{
		public static Tweener DOOffset(this RectTransform target, Rect from, Rect to, float duration)
		{
			return DOTween.To(a => {
				Rect ar = a.Lerp(from, to);
				target.offsetMin = ar.position;
				target.offsetMax = ar.position + ar.size;
			}, 0.0f, 1.0f, duration);
		}
	}
}
