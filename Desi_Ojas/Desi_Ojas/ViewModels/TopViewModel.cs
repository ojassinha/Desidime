using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Desi_Ojas.ViewModels
{
    public class TopViewModel : INotifyPropertyChanged
    {
        #region Private Properties

        private string title;
        private string originalPrice;
        private string discount;
        private string _url;
        private string currentPrice;

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value != title)
                {
                    title = value;
                    NotifyPropertyChanged("Title");
                }
            }
        }

        

        /// <summary>
        /// Gets or sets the original price.
        /// </summary>
        /// <value>
        /// The original price.
        /// </value>
        public string OriginalPrice
        {
            get
            {
                return originalPrice;
            }
            set
            {
                if (value != originalPrice)
                {
                    originalPrice = value;
                    NotifyPropertyChanged("OriginalPrice");
                }
            }
        }

        

        /// <summary>
        /// Gets or sets the discount.
        /// </summary>
        /// <value>
        /// The discount.
        /// </value>
        public string Discount
        {
            get
            {
                return discount;
            }
            set
            {
                if (value != discount)
                {
                    discount = value;
                    NotifyPropertyChanged("Discount");
                }
            }
        }

      
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                if (value != _url)
                {
                    _url = value;
                    NotifyPropertyChanged("Url");
                }
            }
        }

        

        /// <summary>
        /// Gets or sets the current price.
        /// </summary>
        /// <value>
        /// The current price.
        /// </value>
        public string CurrentPrice
        {
            get
            {
                return currentPrice;
            }
            set
            {
                if (value != currentPrice)
                {
                    currentPrice = value;
                    NotifyPropertyChanged("CurrentPrice");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}