using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
/// <summary>
/// We have defined the Service Contract Interface
/// </summary>
namespace HelloWorldService
{
    [ServiceContract]
    public interface IHelloWorldService
    {
        [OperationContract]
        string GetMessage(string name);
    }
}
