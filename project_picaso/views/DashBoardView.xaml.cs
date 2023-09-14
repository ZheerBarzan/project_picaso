using project_picaso.Models;
using System.Collections.ObjectModel;

namespace project_picaso.views;

public partial class DashBoardView : ContentPage
{
	public ObservableCollection<Profile> Profiles { get; set; }

	public ObservableCollection<GeneratedImage> generatedImages { get; set; }
	public DashBoardView()
	{
		InitializeComponent();
		LoadData();
		BindingContext = this;
	}

	public void LoadData()
	{
		Profiles = new ObservableCollection<Profile>()
		{
			new Profile
			{
				Name = "Zheer",
				ProfileImage = "",
				NoPhotos=10

			},
			new Profile
			{
				Name = "rahand",
				ProfileImage = "",
				NoPhotos=11

			},
			new Profile
			{
				Name = "shadyar",
				ProfileImage = "",
				NoPhotos=12

			},
		};
		generatedImages = new ObservableCollection<GeneratedImage>()
		{
		new	GeneratedImage{
			ImagePath = "picture_l.jpg",
			MainKeyword = "Castle",
			Keyword = new List<string>
			{
				"Epic", "Hill", "Nature", "Tree", "Blue Sky"
			}

			}

		};





		generatedImages = new ObservableCollection<GeneratedImage>();


	}
}