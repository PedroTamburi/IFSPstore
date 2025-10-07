
namespace IFSPstore.Domain.Base
{
    public abstract class BaseEntitiy<TId>: IBaseEntity
    {
        public BaseEntitiy(TId id)
        {
            Id = id;
        }
        public TId Id { get; set; }
        protected BaseEntitiy()
        {
        }
    }
}
