using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Desi_Ojas.Resources;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections.Generic;
using Desi_Ojas.Models;

namespace Desi_Ojas.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.TopItems = new ObservableCollection<TopViewModel>();
            this.PopularItems = new ObservableCollection<PopularViewModel>();
        }

        /// <summary>
        /// A collection for TopViewModel objects.
        /// </summary>
        public ObservableCollection<TopViewModel> TopItems { get; private set; }

        /// <summary>
        /// A collection for PopularViewModel objects.
        /// </summary>
        public ObservableCollection<PopularViewModel> PopularItems { get; private set; }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few TopViewModel objects into the Items collection.
        /// </summary>
        public async void LoadData()
        {
            DataAccessLayer.LoadData loadData = new DataAccessLayer.LoadData();
            // Gets the top data from data access layer
            string desi_responseTops = await loadData.GetTopsData();
            List<TopResponseDto> tops = JsonConvert.DeserializeObject<List<TopResponseDto>>(desi_responseTops);
            foreach (var it in tops)
            {
                if (it.off_percent != string.Empty)
                {
                    this.TopItems.Add(new TopViewModel { Title = it.title, OriginalPrice = "Rs ." + it.original_price.ToString(), Url = it.image_thumb, Discount = "(" + it.off_percent + "% off" + ")", CurrentPrice = it.current_price.ToString() });
                }
                else
                {
                    this.TopItems.Add(new TopViewModel { Title = it.title, OriginalPrice = "Rs ." + it.original_price.ToString(), Url = it.image_thumb, Discount = "(" + it.off_percent + "% off" + ")", CurrentPrice = it.current_price.ToString() });
                }
            }


            // Gets the Popular data list , need to be separated in different view model
            string popular_responseTops = await loadData.GetPopularData();
            List<PopularResponseDto> popular = JsonConvert.DeserializeObject<List<PopularResponseDto>>(popular_responseTops);
            foreach (var it in popular)
            {
                if (it.off_percent != string.Empty)
                {
                    this.PopularItems.Add(new PopularViewModel { Title = it.title, OriginalPrice = "Rs ." + it.original_price.ToString(), Url = it.image_thumb, Discount = "(" + it.off_percent + "% off" + ")", CurrentPrice = it.current_price.ToString() });
                }
                else
                {
                    this.PopularItems.Add(new PopularViewModel { Title = it.title, OriginalPrice = "Rs ." + it.original_price.ToString(), Url = it.image_thumb, Discount = "(" + it.off_percent + "% off" + ")", CurrentPrice = it.current_price.ToString() });
                }
            }
            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}