using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desi_Ojas.Models
{
    public class TopResponseDto
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the image_thumb.
        /// </summary>
        /// <value>
        /// The image_thumb.
        /// </value>
        public string image_thumb { get; set; }

        /// <summary>
        /// Gets or sets the off_percent.
        /// </summary>
        /// <value>
        /// The off_percent.
        /// </value>
        public string off_percent { get; set; }

        /// <summary>
        /// Gets or sets the current_price.
        /// </summary>
        /// <value>
        /// The current_price.
        /// </value>
        public double current_price { get; set; }

        /// <summary>
        /// Gets or sets the original_price.
        /// </summary>
        /// <value>
        /// The original_price.
        /// </value>
        public double original_price { get; set; }

        /// <summary>
        /// Gets or sets the shipping_charge.
        /// </summary>
        /// <value>
        /// The shipping_charge.
        /// </value>
        public double shipping_charge { get; set; }

        #endregion
    }
}
