using Nancy;
using PlacesBeen.Objects;
using System.Collections.Generic;

namespace PlacesBeen
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Place> allPlaces = Place.GetAll();
        return View["index.cshtml", allPlaces];
      };
      // Get["/places"] = _ => {
      //   List<Place> allPlaces = Place.GetAll();
      //   return View["places.cshtml", allPlaces];
      // };
      Get["/goForm"] = _ => {
        return View["addPlace.cshtml"];
      };
      Post["/addPlace"] = _ => {
        Place newPlace = new Place(Request.Form["city"],Request.Form["year"],Request.Form["adj"],Request.Form["imageLink"]);
        List<Place> allPlaces = Place.GetAll();
        return View["index.cshtml", allPlaces];
      };
    }
  }
}
