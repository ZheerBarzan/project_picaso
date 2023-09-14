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
				ProfileImage = "dotnet_bot.svg",
				NoPhotos=10

			},
			new Profile
			{
				Name = "rahand",
				ProfileImage = "dotnet_bot.svg",
				NoPhotos=11

			},
			new Profile
			{
				Name = "shadyar",
				ProfileImage = "dotnet_bot.svg",
				NoPhotos=12

			},
		};
		generatedImages = new ObservableCollection<GeneratedImage>()
		{
		new	GeneratedImage{
			ImagePath = "dotnet_bot.svg",
			MainKeyword = "Castle",
			Keyword = new List<string>
			{
				"Epic", "Hill", "Nature", "Tree", "Blue Sky"
			}

			},

        new GeneratedImage{
            ImagePath = "dotnet_bot.svg",
            MainKeyword = "Sea",
            Keyword = new List<string>
            {
                "Epic", "Hill", "Nature", "Tree", "Blue Sky"
            }

            },

        new GeneratedImage{
            ImagePath = "dotnet_bot.svg",
            MainKeyword = "City",
            Keyword = new List<string>
            {
                "Epic", "Hill", "Nature", "Tree", "Blue Sky"
            }

            }

        };
		generatedImages = new ObservableCollection<GeneratedImage>();


	}
}