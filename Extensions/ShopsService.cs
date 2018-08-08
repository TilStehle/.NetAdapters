using DE.Myparcelservice.App.OSAPIInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelservicePricing.ConvertedWindowsPhone.extensions
{

    public class ExtendedShopsService : DE.Myparcelservice.App.Services.ShopsService
    {
        public ExtendedShopsService(ISharedPreferences preferencesAdapter, IDownloadTaskCreator downloadTaskCreator)
            : base(preferencesAdapter, downloadTaskCreator)
        { }
        protected internal override string CreateshopfinderUrl(GeoPoint center)
        {
            return base.CreateshopfinderUrl(center).Replace(',','.');

        }
    }
}
