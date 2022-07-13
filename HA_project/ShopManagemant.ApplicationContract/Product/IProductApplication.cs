using _0_Framework.Application;

namespace ShopManagemant.ApplicationContract.Product
{
    public interface IProductApplication
    {
        OperationResult Create(Create command);
        OperationResult Edit(EditProducts command);
        EditProducts details(long id);
        List<productviewmodel> search(SearchModel command);

        OperationResult Instock(long id);
        OperationResult NotInstock(long id);
        List<productviewmodel> All();
    }
}
