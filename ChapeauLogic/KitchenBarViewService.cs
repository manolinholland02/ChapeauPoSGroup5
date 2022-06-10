using System.Collections.Generic;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauLogic
{
    public class KitchenBarViewService
    {
        //Declaring static object of my Service class
        private static KitchenBarViewService _uniqueInstance;
        private KitchenBarViewModelDao _kitchenBarViewModelDb;

        //Set the constructor to private
        private KitchenBarViewService() 
        {
            //Calling the unique instance of the KitchenBarViewModelDao class
            _kitchenBarViewModelDb = KitchenBarViewModelDao.GetInstance();
        }

        //Using the Singleton design pattern I create a static method that ensures only one (unique) instance
        //of class KitchenBarViewService can be created
        public static KitchenBarViewService GetInstance()
        {
            if (_uniqueInstance == null) _uniqueInstance = new KitchenBarViewService();

            return _uniqueInstance;
        }

        //Method to get all incoming order items
        public List<KitchenBarViewModel> GetAllIncomingOrderItems(string menuItemType)
        {
            return _kitchenBarViewModelDb.GetAllIncomingOrderItems(menuItemType);
        }

        //Method to get all past order items from today
        public List<KitchenBarViewModel> GetPastOrderItemsForToday(string menuItemType)
        {
            return _kitchenBarViewModelDb.GetPastOrderItemsForToday(menuItemType);
        }

        //Method that updates the status of an OrderItem
        public void SetOrderItemAsPrepared(int orderItemId, Status status, string timeElapsed)
        {
            _kitchenBarViewModelDb.SetOrderItemAsPrepared(orderItemId, status, timeElapsed);
        }
    }
}
