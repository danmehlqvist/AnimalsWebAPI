using AnimalsWebAPI.DTOs;

namespace AnimalsWebAPI.Classes
{
    public class PaginationResult<T>
    {

        public List<T> DataToReturn;
        public int TotalPages;
        public int CurrentPage;
        public int TotalItems;

        public PaginationResult(
            List<T> animals,
            int ItemsPerPage = 10,
            int currentPage = 1)
        {
            DataToReturn = animals
                .Skip((currentPage - 1) * ItemsPerPage)
                .Take(ItemsPerPage)
                .ToList();
            TotalPages = animals.Count / ItemsPerPage +1;
            CurrentPage = currentPage;
            TotalItems = animals.Count;
        }



    }
}
