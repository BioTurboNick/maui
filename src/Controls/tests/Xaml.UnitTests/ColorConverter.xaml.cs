using Microsoft.Maui.Controls.Core.UnitTests;
using Microsoft.Maui.Graphics;
using NUnit.Framework;

namespace Microsoft.Maui.Controls.Xaml.UnitTests
{
	public partial class ColorConverter : ContentPage
	{
		class Data
		{
			public string ButtonBackground => "#fc87ad";
		}

		public ColorConverter()
		{
			InitializeComponent();
		}

		public ColorConverter(bool useCompiledXaml)
		{
			//this stub will be replaced at compile time
		}

		[TestFixture]
		public class Tests
		{
			[TestCase(false)]
			[TestCase(true)]
			public void StringsAreValidAsColor(bool useCompiledXaml)
			{
				var page = new ColorConverter(useCompiledXaml);
				page.BindingContext = new Data();

				var expected = Color.FromArgb("#fc87ad");
				Assert.AreEqual(expected, page.Button0.BackgroundColor);
			}
		}
	}
}
