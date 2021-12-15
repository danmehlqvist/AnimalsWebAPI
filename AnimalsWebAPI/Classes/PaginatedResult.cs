using AnimalsWebAPI.DTOs;

namespace AnimalsWebAPI.Classes
{
    public class PaginatedResult<T>
    {

        public List<T> DataToReturn;
        public int TotalPages;
        public int CurrentPage;
        public int TotalItems;

        public PaginatedResult(
            List<T> data,
            int totalItems,
            int itemsPerPage,
            int currentPage
            )
        {
            DataToReturn = data;
            TotalPages = totalItems / itemsPerPage + 1;
            CurrentPage = currentPage;
            TotalItems = totalItems;
        }
    }
}
