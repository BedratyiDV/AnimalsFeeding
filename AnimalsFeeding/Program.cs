namespace AnimalsFeeding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating instances of AnimalPlace object
            var ap1 = new AnimalPlace("Jack", "Pedigree");
            var ap2 = new AnimalPlace("Tom", "Whiskas");
            var ap3 = new AnimalPlace("Puma", "Kitekat");

            //Creating instance of AnimalsFeedProcessor object
            using (var afp = new AnimalsFeedProcessor())
            {
                //Adding new places to the list
                afp.AddNewAnimalPlace(ap1);
                afp.AddNewAnimalPlace(ap2);
                afp.AddNewAnimalPlace(ap3);

                //Calling the method to feed all the animals
                afp.FeedAll();
            }
        }
    }
}