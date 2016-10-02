using Xamarin.Forms;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace wildwood
{
	public partial class wildwoodPage : ContentPage
	{
		ObservableCollection<Tweet> tweets = new ObservableCollection<Tweet>();
		public wildwoodPage()
		{
			InitializeComponent();
			SearchButton.Clicked += this.SearchButton_Click;
			tweets.Add(new Tweet
			{
				Text = "No items to display"
			});
			TweetsListView.ItemsSource = tweets;
		}

		protected async void SearchButton_Click(object sender, EventArgs e)
		{
			var searchTerm = SearchEditor.Text;
			var httpClient = new HttpClient();
			var url = $"https://morning-wildwood-22288.herokuapp.com/search/{searchTerm}";
			var resultString = await httpClient.GetStringAsync(url);
			var sanitizedResultString = resultString.Replace($",\"{searchTerm}\"", "");
			var result = JsonConvert.DeserializeObject<List<Tweet>>(sanitizedResultString);

			this.tweets.Clear();
			foreach (var tweet in result)
			{
				tweets.Add(tweet);
			}
		}
	}
}
