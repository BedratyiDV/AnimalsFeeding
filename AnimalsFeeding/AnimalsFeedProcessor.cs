using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsFeeding
{
    // <summary>
    ///Managing class for animals feed process
    /// </summary>
    public class AnimalsFeedProcessor :IDisposable

    {
      /// <summary>
     /// Property of List type for collecting animal place objects
     /// </summary>
        private List<AnimalPlace> _placeCollection;

        /// <summary>
        ///Constructor for creating a new instance of AnimalsFeedProcessor object
        /// </summary>
        public AnimalsFeedProcessor()
        {
            _placeCollection = new List<AnimalPlace>();
        }
        /// <summary>
        ///Method for adding a new place to collection. Also performs other actions according the homework tasks
        /// </summary>
        /// <param name="place"> </param>  
        public void AddNewAnimalPlace(AnimalPlace place)
        {
            place.FoodFinished += FeedAnimal;
            _placeCollection.Add(place);
            place.CallFeedEvent();
            place.Feed(75);
           
        }
        /// <summary>
        /// Method feeds all the animals from all animal places located in the list
        /// </summary>
        public void FeedAll()
        {
            foreach (AnimalPlace place in _placeCollection) 
            {
                place.Feed(50);
            }
        }
        /// <summary>
        /// Method is called when the event is rised
        /// </summary>
        /// <param name="animal"> </param>  
        /// <param name="food"> </param>   
        public static void FeedAnimal(AnimalPlace animal, string food)

        {
            Console.WriteLine($"{animal.AnimalName} needs to be feeded with {animal.Food} now");
        }
        /// <summary>
        /// Method-handler that implements IDisposable interface
        /// </summary>
        public void Dispose() 
        
        {
            foreach (AnimalPlace place in _placeCollection)
            {
                place.FoodFinished -= FeedAnimal;
            }
            Console.WriteLine("AnimalFeedProcessor is now signed off from all the animal apartments' events");
        }
    }
}
