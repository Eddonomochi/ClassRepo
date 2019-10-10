namespace StartupExample
{
    public class TacoStand : IFoodService
    {
        private decimal _totalAmountEarned;

        public Food GetFood(decimal payment)
        {
            this._totalAmountEarned += payment;

            return new Food("Taco");
        }
    }
}