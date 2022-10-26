
using Microsoft.AspNetCore.Components;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Parameter = Nethereum.ABI.FunctionEncoding.Attributes.ParameterAttribute;
using Nethereum.Contracts;
using System.Numerics;


public class StorageContractDeployment : ContractDeploymentMessage
{
  private static string BYTECODE { get; set; } =
  "608060405234801561001057600080fd5b5060c78061001f6000396000f3fe6080604052348015600f57600080fd5b506004361060325760003560e01c80632e64cec11460375780636057361d146053575b600080fd5b603d607e565b6040518082815260200191505060405180910390f35b607c60048036036020811015606757600080fd5b81019080803590602001909291905050506087565b005b60008054905090565b806000819055505056fea2646970667358221220960ef13a252ff3e92bd554718fb5beb2c8365796092cce8e2f12ad471204577164736f6c63430007040033";
  public StorageContractDeployment() : base(BYTECODE) { }

  [Parameter("uint256", "totalSupply")]
  public BigInteger TotalSupply { get; set; }

}

[Function("store")]

public class StoreFunction : FunctionMessage
{

  [Parameter("uint256", "num", 1)]
  public BigInteger Num { get; set; }
}

[Function("retrieve", "uint256")]
public class RetrieveFunction : FunctionMessage { }