using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalsFeeding
{
    /// <summary>
    ///Animal place class
    /// </summary>
    public class AnimalPlace
    {
        /// <summary>
        ///Event that signals that the animal should be fed
        /// </summary>
        public event Action<AnimalPlace, string> FoodFinished;

        private string _animalName;
        private string _food;

        /// <summary>
        ///Get method for private property _animalName
        /// </summary>
        public string AnimalName
        {
            get => _animalName;
        }
        /// <summary>
        ///Get method for private property _food
        /// </summary>
        public string Food
        {
            get => _food;
        }
        /// <summary>
        ///Constructor for creating a new instance of AnimalPlace object
        /// </summary>
        /// <param name="animalName"> </param> 
        /// <param name="food"> </param> 
        public AnimalPlace(string animalName, string food)
        {
            _animalName = animalName;
            _food = food;
        }
        /// <summary>
        ///Method that feeds an animal
        /// </summary>
        /// <param name="amount"> </param> 
        public void Feed(int amount)
        {
            Console.WriteLine($"{_animalName} received {amount} units of food");
        }
        /// <summary>
        ///Method invokes the event to initiate animal feeding
        /// </summary>
        public void CallFeedEvent()

        {

            if (FoodFinished != null)

            {
                if (1 > 0)
                {
                    // Raise (call) the event
                    FoodFinished(this, this._food);
                }
            }
    }
}

}
