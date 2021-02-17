using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    internal class ErrorResult: IDataResult<Product>
    {
        private object maintenanceTime;

        public ErrorResult(object maintenanceTime)
        {
            this.maintenanceTime = maintenanceTime;
        }

        public Product Data => throw new System.NotImplementedException();

        public bool Success => throw new System.NotImplementedException();

        public string Message => throw new System.NotImplementedException();
    }
}