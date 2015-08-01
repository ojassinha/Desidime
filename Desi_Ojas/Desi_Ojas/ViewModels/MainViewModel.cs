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
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public async void LoadData()
        {
            // Sample data; replace with real data
           
            List<TopResponseDto> res = JsonConvert.DeserializeObject<List<TopResponseDto>>(ResponseString);
            foreach (var it in res)
            {
                if (it.off_percent != string.Empty)
                {
                    this.Items.Add(new ItemViewModel { LineOne = it.title, LineTwo = "Rs ." + it.original_price.ToString(), Url = it.image_thumb, LineThree = "(" + it.off_percent + "% off" + ")", LineFour = it.current_price.ToString() });
                }
                else
                {
                    this.Items.Add(new ItemViewModel { LineOne = it.title, LineTwo = "Rs ." + it.original_price.ToString(), Url = it.image_thumb, LineThree = "(" + it.off_percent + "% off" + ")", LineFour = it.current_price.ToString() });
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