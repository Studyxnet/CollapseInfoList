using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DetailList
{
	public partial class ListCollapsed : ContentPage
	{
		public ListCollapsed ()
		{
			InitializeComponent ();

			BindingContext = new List<Person> () {
				new Person () {
					Name = "Rafael",
					Surname = "Moura",
					Age = 21,
					Visible = false
				},
				new Person () {
					Name = "Leonardo",
					Surname = "Lima",
					Age = 20,
					Visible = false
				},
				new Person () {
					Name = "Albert",
					Surname = "Tanure",
					Age = 28,
					Visible = false
				}
			};
		}

		void SelectedList (object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null) {
				(e.SelectedItem as Person).ChangeVisible ();


			}

			(sender as ListView).SelectedItem = null;
		}
	}
}

