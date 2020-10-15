
namespace Netezos.Rpc.Queries
{
    public class BigMapIDQuery : RpcQuery
    {
        public BigMapStringQuery this[int bigMapsID] => new BigMapStringQuery(this, $"{bigMapsID}/");

        internal BigMapIDQuery(RpcQuery baseQuery, string append) : base(baseQuery, append) { }
    }
}
