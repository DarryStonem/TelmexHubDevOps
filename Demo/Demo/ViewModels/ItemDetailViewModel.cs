using System;
using System.Collections.Generic;
using System.Windows.Input;
using Demo.Models;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace Demo.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ICommand LogCommand { get; }

        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;

            LogCommand = new Command(LogTheApp);
        }

        private void LogTheApp(object obj)
        {
            try
            {
                Analytics.TrackEvent("User enter to Item Detail");
                throw new Exception("Item Detail crash");
            }
            catch (Exception ex)
            {
                var properties = new Dictionary<string, string> {
                    { "Title", Item.Text },
                    { "Description", Item.Description }
                };

                Crashes.TrackError(ex, properties);
            }
        }
    }
}
