using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;

namespace MarvelCards
{
    public class MainViewModel
    {
        public ObservableCollection<HeroModel> Heroes { get; } = new ObservableCollection<HeroModel>();

        public MainViewModel()
        {
            Heroes.Add(new HeroModel
            {
                Alias = "Iron Man",
                Name = "Tony Stark",
                Image = ImageSource.FromResource("iron.png", GetType().Assembly),
                Color = new GradientStopCollection
                {
                    new GradientStop { Color = Color.FromHex("#DA1F28"), Offset = 0f },
                    new GradientStop { Color = Color.Transparent, Offset = 0.1f },
                    new GradientStop { Color = Color.Transparent, Offset = 0.6f },
                    new GradientStop { Color = Color.FromHex("#DA1F28"), Offset = 1f }
                },
                Facts = "• Genius\n• Billionaire\n• Playboy\n• Philanthropist"
            });
            Heroes.Add(new HeroModel
            {
                Alias = "Thor",
                Name = "Thor Odinson",
                Image = ImageSource.FromResource("thor.png", GetType().Assembly),
                Color = new GradientStopCollection
                {
                    new GradientStop { Color = Color.FromHex("#87CEEB"), Offset = 0f },
                    new GradientStop { Color = Color.Transparent, Offset = 0.1f },
                    new GradientStop { Color = Color.Transparent, Offset = 0.6f },
                    new GradientStop { Color = Color.FromHex("#87CEEB"), Offset = 1f }
                }
            });
            Heroes.Add(new HeroModel
            {
                Alias = "Captain America",
                Name = "Steve Rogers",
                Image = ImageSource.FromResource("cap.png", GetType().Assembly),
                Color = new GradientStopCollection
                {
                    new GradientStop { Color = Color.FromHex("#AA1428"), Offset = 0f },
                    new GradientStop { Color = Color.Transparent, Offset = 0.1f },
                    new GradientStop { Color = Color.Transparent, Offset = 0.6f },
                    new GradientStop { Color = Color.FromHex("#AA1428"), Offset = 1f }
                }
            });
            Heroes.Add(new HeroModel
            {
                Alias = "Hulk",
                Name = "Bruce Banner",
                Image = ImageSource.FromResource("hulk.png", GetType().Assembly),
                Color = new GradientStopCollection
                {
                    new GradientStop { Color = Color.FromHex("#A2CD48"), Offset = 0f },
                    new GradientStop { Color = Color.Transparent, Offset = 0.1f },
                    new GradientStop { Color = Color.Transparent, Offset = 0.6f },
                    new GradientStop { Color = Color.FromHex("#A2CD48"), Offset = 1f }
                }
            });
            Heroes.Add(new HeroModel
            {
                Alias = "Hawkeye",
                Name = "Clint Barton",
                Image = ImageSource.FromResource("hawk.png", GetType().Assembly),
                Color = new GradientStopCollection
                {
                    new GradientStop { Color = Color.FromHex("#4A3C9B"), Offset = 0f },
                    new GradientStop { Color = Color.Transparent, Offset = 0.1f },
                    new GradientStop { Color = Color.Transparent, Offset = 0.6f },
                    new GradientStop { Color = Color.FromHex("#4A3C9B"), Offset = 1f }
                }
            });
            Heroes.Add(new HeroModel
            {
                Alias = "Black Widow",
                Name = "Natalia Romanova",
                Image = ImageSource.FromResource("nat.png", GetType().Assembly),
                Color = new GradientStopCollection
                {
                    new GradientStop { Color = Color.FromHex("#000000"), Offset = 0f },
                    new GradientStop { Color = Color.Transparent, Offset = 0.1f },
                    new GradientStop { Color = Color.Transparent, Offset = 0.6f },
                    new GradientStop { Color = Color.FromHex("#000000"), Offset = 1f }
                }
            });
        }
    }

    public class HeroModel
    {
        public string Alias { get; set; }
        public string Name { get; set; }
        public ImageSource Image { get; set; }
        public GradientStopCollection Color { get; set; }
        public string Facts { get; set; }
    }
}
