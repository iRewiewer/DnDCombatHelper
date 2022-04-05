using DnDCombatHelper.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DnDCombatHelper.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}