
namespace Netezos.Rpc.Queries
{
    public class BigMapStringQuery : RpcQuery
    {
        public RpcObject this[string bigMapStr] => new RpcObject(this, $"{bigMapStr}/");

        internal BigMapStringQuery(RpcQuery baseQuery, string append) : base(baseQuery, append) { }
    }
}
