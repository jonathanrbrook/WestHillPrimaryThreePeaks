using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThreePeaksMvc.Service
{
    public class FlickrService
    {
        public string GetAllEvents()
        {
            var client = new HttpClient();
            client.DefaultHeaders.Authorization = new Credential("ArbitraryAuthHeader");
            client.DefaultHeaders.Date = DateTime.Now;
            client.DefaultHeaders.Accept.Add("application/xml");

            var response = client.Get("http://api.flickr.com/services/rest/?method=flickr.photosets.getPhotos&api_key=feed122b7c1eed8ad03b49a2e27ab867&photoset_id=72157630635240178&format=rest");

            return response.Content.ReadAsString();

        }
    }
}