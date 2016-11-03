using System;
namespace Xamarin.Ui
{
	public static class Extensions
	{
		public static T ToVariable<T>(this T self, out T variable)
		{
			variable = self;
			return self;
		}
	}
}
