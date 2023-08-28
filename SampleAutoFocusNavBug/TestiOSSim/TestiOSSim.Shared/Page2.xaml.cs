using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TestiOSSim
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Page2 : Page
	{
		public Page2()
		{
			this.InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Frame.GoBack();
		}
	}
}
